using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AES.Entities.Shared.Net45.Models;
using WebApiRestService;

namespace AES.WebApplication.Client
{
    public class QuestionAnswerSvcClient : WebApiClient<QuestionAnswer>
    {
        public new static readonly WebApiClientOptions Options = new WebApiClientOptions()
        {
            BaseAddress = "http://localhost:" + "59095" + "/",
            ContentType = ContentType.Json,
            Timeout = 80000,
            Controller = "api/QuestionAnswer"
        };

        /// <summary>
        /// Creates an instance of StoreClient using default options
        /// </summary>
        public QuestionAnswerSvcClient()
            : this(Options)
        {
        }

        /// <summary>
        /// Creates an instance of StoreClient using explicit options
        /// </summary>
        private QuestionAnswerSvcClient(WebApiClientOptions options)
            : base(options)
        {
        }

        public async Task<IEnumerable<QuestionAnswer>> GetQuestionAnswers()
        {
            return await GetManyAsync();
        }

        public async Task<QuestionAnswer> GetQuestionAnswerById(int? id)
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

        public async Task<QuestionAnswer> CreateQuestionAnswer(QuestionAnswer questionAnswer)
        {
            return await CreateAsync(questionAnswer);
        }

        public async Task<QuestionAnswer> EditQuestionAnswer(QuestionAnswer questionAnswer)
        {
            return await EditAsync(questionAnswer);
        }

        public async Task DeleteQuestionAnswer(int id)
        {
            await DeleteAsync(id);
        }
    }
}