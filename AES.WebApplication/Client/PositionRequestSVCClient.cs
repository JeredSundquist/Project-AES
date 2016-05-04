using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AES.Entities.Shared.Net45.Models;
using WebApiRestService;

namespace AES.WebApplication.Client
{
    public class PositionRequestSvcClient : WebApiClient<PositionRequest>
    {
        public new static readonly WebApiClientOptions Options = new WebApiClientOptions()
        {
            BaseAddress = "http://localhost:" + "59095" + "/",
            ContentType = ContentType.Json,
            Timeout = 80000,
            Controller = "api/PositionRequest"
        };

        /// <summary>
        /// Creates an instance of PositionRequestClient using default options
        /// </summary>
        public PositionRequestSvcClient()
            : this(Options)
        {
        }

        /// <summary>
        /// Creates an instance of PositionRequestClient using explicit options
        /// </summary>
        private PositionRequestSvcClient(WebApiClientOptions options)
            : base(options)
        {
        }

        public async Task<IEnumerable<PositionRequest>> GetPositionRequests()
        {
            return await GetManyAsync();
        }

        public async Task<PositionRequest> GetPositionRequestById(int? id)
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

        public async Task<PositionRequest> CreatePositionRequest(PositionRequest positionRequest)
        {
            return await CreateAsync(positionRequest);
        }

        public async Task<PositionRequest> EditPositionRequest(PositionRequest positionRequest)
        {
            return await EditAsync(positionRequest);
        }

        public async Task DeletePositionRequest(int id)
        {
            await DeleteAsync(id);
        }
    }
}