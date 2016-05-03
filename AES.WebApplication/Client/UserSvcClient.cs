using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AES.Entities.Shared.Net45.Models;
using WebApiRestService;

namespace AES.WebApplication.Client
{
    public class UserSvcClient : WebApiClient<User>
    {
        public new static readonly WebApiClientOptions Options = new WebApiClientOptions()
        {
            BaseAddress = "http://localhost:" + "53253" + "/",
            ContentType = ContentType.Json,
            Timeout = 80000,
            Controller = "api/User"
        };

        /// <summary>
        /// Creates an instance of UserClient using default options
        /// </summary>
        public UserSvcClient()
            : this(Options)
        {
        }

        /// <summary>
        /// Creates an instance of UserClient using explicit options
        /// </summary>
        private UserSvcClient(WebApiClientOptions options)
            : base(options)
        {
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await GetManyAsync();
        }

        public async Task<User> GetUserById(int? id)
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

        public async Task<User> CreateUser(User user)
        {
            return await CreateAsync(user);
        }

        public async Task<User> EditUser(User user)
        {
            return await EditAsync(user);
        }

        public async Task DeleteUser(int id)
        {
            await DeleteAsync(id);
        }
    }
}