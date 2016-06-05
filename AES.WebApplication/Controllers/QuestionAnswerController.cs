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

        // GET: QuestionAnswers
        public async Task<ActionResult> Index()
        {
            IEnumerable<QuestionAnswer> questionAnswer = await Client.GetQuestionAnswers();

            return View(questionAnswer);
        }

        // GET: QuestionAnswers/Details/5
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

        // GET: QuestionAnswers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionAnswers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "QuestionAnswerId,Question,MC_Possible_Answer_1,MC_Answer_1_Selected,MC_Possible_Answer_2,MC_Answer_2_Selected,MC_Possible_Answer_3,MC_Answer_3_Selected,MC_Possible_Answer_4,MC_Answer_4_Selected,MC_Possible_Answer_5,MC_Answer_5_Selected,MC_Answer_Num_Selected,MC_Correct_Answer_Num,TF_Answer,WI_Answer,QuestionType")] QuestionAnswer questionAnswer)
        {
            if (!ModelState.IsValid) return View(questionAnswer);
            {
                await Client.CreateQuestionAnswer(questionAnswer);

                return RedirectToAction("Index");
            }
        }

        // GET: QuestionAnswers/Edit/5
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

        // POST: QuestionAnswers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "QuestionAnswerId,Question,MC_Possible_Answer_1,MC_Answer_1_Selected,MC_Possible_Answer_2,MC_Answer_2_Selected,MC_Possible_Answer_3,MC_Answer_3_Selected,MC_Possible_Answer_4,MC_Answer_4_Selected,MC_Possible_Answer_5,MC_Answer_5_Selected,MC_Answer_Num_Selected,MC_Correct_Answer_Num,TF_Answer,WI_Answer,QuestionType")] QuestionAnswer questionAnswer)
        {
            if (!ModelState.IsValid) return View(questionAnswer);
            {
                await Client.EditQuestionAnswer(questionAnswer);

                return RedirectToAction("Index");
            }
        }

        // GET: QuestionAnswers/Delete/5
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

        // POST: QuestionAnswers/Delete/5
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
