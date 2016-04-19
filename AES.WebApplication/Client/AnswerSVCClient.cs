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
    public class AnswerSVCClient : WebApiClient<Answer>
    {
        public static readonly WebApiClientOptions options = new WebApiClientOptions()
        {
            BaseAddress = "http://localhost:" + "59095" + "/",
            ContentType = ContentType.Json,
            Timeout = 80000,
            Controller = "api/Answer"
        };

        /// <summary>
        /// Creates an instance of AnswerClient using default options
        /// </summary>
        public AnswerSVCClient()
            : this(options)
        {
        }

        /// <summary>
        /// Creates an instance of AnswerClient using explicit options
        /// </summary>
        private AnswerSVCClient(WebApiClientOptions options)
            : base(options)
        {
        }

        public async Task<IEnumerable<Answer>> GetAnswers()
        {
            return await GetManyAsync();
        }

        public async Task<Answer> GetAnswerById(int? id)
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

        public async Task<Answer> CreateAnswer(Answer Answer)
        {
            return await CreateAsync(Answer);
        }

        public async Task<Answer> EditAnswer(Answer Answer)
        {
            return await EditAsync(Answer);
        }

        public async Task DeleteAnswer(int id)
        {
            await DeleteAsync(id);
        }
    }
}