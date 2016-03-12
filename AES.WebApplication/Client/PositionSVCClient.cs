using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AES.Entities.Shared.Net45.Models;
using WebApiRestService;

namespace AES.WebApplication.Client
{
    public class PositionSVCClient : WebApiClient<Position>
    {
        public static readonly WebApiClientOptions options = new WebApiClientOptions()
        {
            BaseAddress = "http://localhost:" + "59095" + "/",
            ContentType = ContentType.Json,
            Timeout = 80000,
            Controller = "api/Position"
        };

        /// <summary>
        /// Creates an instance of positionClient using default options
        /// </summary>
        public PositionSVCClient()
            : this(options)
        {
        }

        /// <summary>
        /// Creates an instance of positionClient using explicit options
        /// </summary>
        private PositionSVCClient(WebApiClientOptions options)
            : base(options)
        {
        }

        public async Task<IEnumerable<Position>> GetPositions()
        {
            return await GetManyAsync();
        }

        public async Task<Position> GetPositionById(int? id)
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

        public async Task<Position> CreatePosition(Position position)
        {
            return await CreateAsync(position);
        }

        public async Task<Position> EditPosition(Position position)
        {
            return await EditAsync(position);
        }

        public async Task DeletePosition(int id)
        {
            await DeleteAsync(id);
        }
    }
}