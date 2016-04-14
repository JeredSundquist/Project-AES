using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using AES.Entities.Shared.Net45.Models;
using WebApiRestService;

namespace AES.WebApplication.Client
{
    public class QuestionSVCClient : WebApiClient<Question>
    {
        public static readonly WebApiClientOptions options = new WebApiClientOptions()
        {
            BaseAddress = "http://localhost:" + "59095" + "/",
            ContentType = ContentType.Json,
            Timeout = 80000,
            Controller = "api/Question"
        };

        /// <summary>
        /// Creates an instance of QuestionClient using default options
        /// </summary>
        public QuestionSVCClient()
            : this(options)
        {
        }

        /// <summary>
        /// Creates an instance of QuestionClient using explicit options
        /// </summary>
        private QuestionSVCClient(WebApiClientOptions options)
            : base(options)
        {
        }

        public async Task<IEnumerable<Question>> GetQuestions()
        {
            return await GetManyAsync();
        }

        public async Task<Question> GetQuestionById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            try
            {
                return await GetOneAsync(id);
            }
            catch (WebApiClientException e)
            {
                if (e.StatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw e;
            }
        }

        public async Task<Question> CreateQuestion(Question Question)
        {
            return await CreateAsync(Question);
        }

        public async Task<Question> EditQuestion(Question Question)
        {
            return await EditAsync(Question);
        }

        public async Task DeleteQuestion(int id)
        {
            await DeleteAsync(id);
        }
    }
}