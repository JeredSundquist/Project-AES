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

namespace AES.WebApplication.Controllers
{
    public class QuestionAnswerController : Controller
    {
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
