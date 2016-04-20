using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AES.Entities.Shared.Net45.Models;
using WebApiRestService;

namespace AES.WebApplication.Client
{
    public class ApplicationSvcClient : WebApiClient<Application>
    {
        public new static readonly WebApiClientOptions Options = new WebApiClientOptions()
        {
            BaseAddress = "http://localhost:" + "59095" + "/",
            ContentType = ContentType.Json,
            Timeout = 80000,
            Controller = "api/Application"
        };

        /// <summary>
        /// Creates an instance of ApplicationClient using default options
        /// </summary>
        public ApplicationSvcClient()
            : this(Options)
        {
        }

        /// <summary>
        /// Creates an instance of ApplicationClient using explicit options
        /// </summary>
        private ApplicationSvcClient(WebApiClientOptions options)
            : base(options)
        {
        }

        public async Task<IEnumerable<Application>> GetApplications()
        {
            return await GetManyAsync();
        }

        public async Task<Application> GetApplicationById(int? id)
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

        public async Task<Application> CreateApplication(Application application)
        {
            return await CreateAsync(application);
        }

        public async Task<Application> EditApplication(Application application)
        {
            return await EditAsync(application);
        }

        public async Task DeleteApplication(int id)
        {
            await DeleteAsync(id);
        }
    }
}