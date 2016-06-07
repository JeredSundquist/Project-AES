using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Web.UI.WebControls;
using AES.Entities.Shared.Net45.Models;
using TrackableEntities;
using TrackableEntities.EF6;
using TrackableEntities.Common;

// NOTE: Primary key name and/or type may need to be set manually.

namespace AES.JobLibrarySVC.WebApi.Controllers
{
    public class QuestionAnswerController : ApiController
    {
        private readonly AESEntitiesModel _dbContext = new AESEntitiesModel();

        // GET api/QuestionAnswer
        [ResponseType(typeof(IEnumerable<QuestionAnswer>))]
        public async Task<IHttpActionResult> GetQuestionAnswers()
        {
            IEnumerable<QuestionAnswer> entities = await _dbContext.QuestionAnswers
                // TODO: Add Includes for reference and/or collection properties
                .ToListAsync();

            return Ok(entities);
        }

        /*[ResponseType(typeof(Questionnaire))]
        public async Task<IHttpActionResult> GetQuestionnaire(int Id)
        {
            IEnumerable<QuestionAnswer> entities = await _dbContext.QuestionAnswers
                // TODO: Add Includes for reference and/or collection properties
                .ToListAsync();

            Test testEntity = _dbContext.Tests.Where(x => x.PositionId == Id).FirstOrDefault();
            List<QuestionAnswer> QAList = new List<QuestionAnswer>();

            QAList.Add(_dbContext.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId01.Value).FirstOrDefault());
            QAList.Add(_dbContext.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId02.Value).FirstOrDefault());
            QAList.Add(_dbContext.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId03.Value).FirstOrDefault());
            QAList.Add(_dbContext.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId04.Value).FirstOrDefault());
            QAList.Add(_dbContext.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId05.Value).FirstOrDefault());
            // enter remaining 20 questions here

            Questionnaire questionnaire =  new Questionnaire();
            foreach (var item in QAList)
            {
                Question question = new Question();
                question.type = item.QuestionType;
                question.Title = item.QuestionText;
                question.correctAnswer = item.CorrectAnswer;
                
                // 1-> 5 are 's'
                question.answerList.Add(new Answer(item.MC_AnswerText1, "1"));
                question.answerList.Add(new Answer(item.MC_AnswerText2, "2"));
                question.answerList.Add(new Answer(item.MC_AnswerText3, "3"));
                question.answerList.Add(new Answer(item.MC_AnswerText4, "4"));
                question.answerList.Add(new Answer(item.MC_AnswerText5, "5"));

                questionnaire.questionList.Add(question);
            }
            
            return Ok(questionnaire);
        }*/



        // GET api/QuestionAnswer/5
        [ResponseType(typeof(QuestionAnswer))]
        public async Task<IHttpActionResult> GetQuestionAnswer(int id)
        {
            QuestionAnswer entity = await _dbContext.QuestionAnswers
                // TODO: Add Includes for reference and/or collection properties
                .SingleOrDefaultAsync(e => e.QuestionAnswerId == id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        // POST api/QuestionAnswer
        [ResponseType(typeof(QuestionAnswer))]
        public async Task<IHttpActionResult> PostQuestionAnswer(QuestionAnswer entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            entity.TrackingState = TrackingState.Added;
            _dbContext.ApplyChanges(entity);


            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (_dbContext.QuestionAnswers.Any(e => e.QuestionAnswerId == entity.QuestionAnswerId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return CreatedAtRoute("DefaultApi", new { id = entity.QuestionAnswerId }, entity);
        }

        // PUT api/QuestionAnswer
        [ResponseType(typeof(QuestionAnswer))]
        public async Task<IHttpActionResult> PutQuestionAnswer(QuestionAnswer entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _dbContext.ApplyChanges(entity);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_dbContext.QuestionAnswers.Any(e => e.QuestionAnswerId == entity.QuestionAnswerId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return Ok(entity);
        }

        // DELETE api/QuestionAnswer/5
        public async Task<IHttpActionResult> DeleteQuestionAnswer(int id)
        {
            QuestionAnswer entity = await _dbContext.QuestionAnswers
                // TODO: Include child entities if any
                .SingleOrDefaultAsync(e => e.QuestionAnswerId == id);
            if (entity == null)
            {
                return Ok();
            }

            entity.TrackingState = TrackingState.Deleted;
            _dbContext.ApplyChanges(entity);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_dbContext.QuestionAnswers.Any(e => e.QuestionAnswerId == entity.QuestionAnswerId))
                {
                    return Conflict();
                }
                throw;
            }

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
            base.Dispose(disposing);
        }
    }
}
