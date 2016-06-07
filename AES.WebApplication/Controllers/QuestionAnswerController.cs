using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AES.Entities.Shared.Net45.Models;
using AES.WebApplication.Client;
using AES.WebApplication.Models;


namespace AES.WebApplication.Controllers
{
    public class QuestionAnswerController : Controller
    {
        private AESEntitiesModel db = new AESEntitiesModel();
        public QuestionAnswerSvcClient Client { get; }

        public QuestionAnswerController()
        {
            Client = new QuestionAnswerSvcClient();
        }
        // GET: QuestionAnswer
        public async Task<ActionResult> Index()
        {
            IEnumerable<QuestionAnswer> questionAnswers = await Client.GetQuestionAnswers();

            return View(questionAnswers);
        }

        // GET: QuestionAnswer/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            QuestionAnswer questionAnswer = await Client.GetQuestionAnswerById(id);

            if (questionAnswer == null)
            {
                return HttpNotFound();
            }
            return View(questionAnswer);
        }

        // GET: QuestionAnswer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionAnswer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "QuestionAnswerId,QuestionText,QuestionType,MC_AnswerText1,MC_AnswerText2,MC_AnswerText3,MC_AnswerText4,MC_AnswerText5,WI_Answer,TrueFalse,CorrectAnswer")] QuestionAnswer questionAnswer)
        {
            if (!ModelState.IsValid) return View(questionAnswer);

            await Client.CreateQuestionAnswer(questionAnswer);

            return RedirectToAction("Index");
        }

        // GET: QuestionAnswer/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionAnswer questionAnswer = await Client.GetQuestionAnswerById(id);
            if (questionAnswer == null)
            {
                return HttpNotFound();
            }
            return View(questionAnswer);
        }

        // POST: QuestionAnswer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "QuestionAnswerId,QuestionText,QuestionType,MC_AnswerText1,MC_AnswerText2,MC_AnswerText3,MC_AnswerText4,MC_AnswerText5,WI_Answer,TrueFalse,CorrectAnswer")] QuestionAnswer questionAnswer)
        {
            if (!ModelState.IsValid) return View(questionAnswer);

            await Client.EditQuestionAnswer(questionAnswer);

            return RedirectToAction("Index");
        }


        // GET: QuestionAnswer/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionAnswer questionAnswer = await Client.GetQuestionAnswerById(id);
            if (questionAnswer == null)
            {
                return HttpNotFound();
            }
            return View(questionAnswer);
        }

        // POST: QuestionAnswer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            QuestionAnswer questionAnswer = await Client.GetQuestionAnswerById(id);
            await Client.DeleteQuestionAnswer(id);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> GetQuestionnaire()
        {
            int id = 8;
            IEnumerable<QuestionAnswer> entities = await db.QuestionAnswers
                 // TODO: Add Includes for reference and/or collection properties
                 .ToListAsync();

            Test testEntity = db.Tests.Where(x => x.TestId == id).FirstOrDefault();
            List<QuestionAnswer> QAList = new List<QuestionAnswer>();

            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId01.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId02.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId03.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId04.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId05.Value).FirstOrDefault());

            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId06.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId07.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId08.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId09.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId10.Value).FirstOrDefault());

            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId11.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId12.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId13.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId14.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId15.Value).FirstOrDefault());

            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId16.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId17.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId18.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId19.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId20.Value).FirstOrDefault());

            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId21.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId22.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId23.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId24.Value).FirstOrDefault());
            QAList.Add(db.QuestionAnswers.Where(x => x.QuestionAnswerId == testEntity.QaId25.Value).FirstOrDefault());        

            Questionnaire questionnaire = new Questionnaire();
            foreach (var item in QAList)
            {
                if(item != null)
                { 
                    Question question = new Question();
                    question.type = item.QuestionType;
                    question.Title = item.QuestionText;
                    question.correctAnswer = item.CorrectAnswer;
               
                    // 1-> 5 are 's'
                    if (question.type == "M")
                    { 
                        if( item.MC_AnswerText1 != null)
                            question.answerList.Add(new Answer(item.MC_AnswerText1, "1) "));
                        if (item.MC_AnswerText2 != null)
                            question.answerList.Add(new Answer(item.MC_AnswerText2, "2) "));
                        if (item.MC_AnswerText3 != null)
                            question.answerList.Add(new Answer(item.MC_AnswerText3, "3) "));
                        if (item.MC_AnswerText4 != null)
                            question.answerList.Add(new Answer(item.MC_AnswerText4, "4) "));
                        if (item.MC_AnswerText5 != null)
                            question.answerList.Add(new Answer(item.MC_AnswerText5, "5) "));
                    }
                    else if(question.type == "T")
                    {
                        question.answerList.Add(new Answer("", "1) True"));
                        question.answerList.Add(new Answer("", "2) False"));
                    }
                    else if(question.type == "W")
                    {
                        question.answerList.Add(new Answer("", "Please Explain your answer."));
                    }
                    questionnaire.questionList.Add(question);
                }
            }

            return View(questionnaire);
        }

        [HttpPost]
        public async Task<ActionResult> GetQuestionnaire(Questionnaire questionnaire)
        {
            Questionnaire q = questionnaire;
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Client.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
