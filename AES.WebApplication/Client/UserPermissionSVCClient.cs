using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AES.Entities.Shared.Net45.Models;
using WebApiRestService;

namespace AES.WebApplication.Client
{
    public class UserPermissionSvcClient : WebApiClient<UserPermission>
    {
        public new static readonly WebApiClientOptions Options = new WebApiClientOptions()
        {
            BaseAddress = "http://localhost:" + "53253" + "/",
            ContentType = ContentType.Json,
            Timeout = 80000,
            Controller = "api/UserPermission"
        };

        /// <summary>
        /// Creates an instance of UserPermissionClient using default options
        /// </summary>
        public UserPermissionSvcClient()
            : this(Options)
        {
        }

        /// <summary>
        /// Creates an instance of UserPermissionClient using explicit options
        /// </summary>
        private UserPermissionSvcClient(WebApiClientOptions options)
            : base(options)
        {
        }

        public async Task<IEnumerable<UserPermission>> GetUserPermissions()
        {
            return await GetManyAsync();
        }

        public async Task<UserPermission> GetUserPermissionById(int? id)
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

        public async Task<UserPermission> CreateUserPermission(UserPermission userPermission)
        {
            return await CreateAsync(userPermission);
        }

        public async Task<UserPermission> EditUserPermission(UserPermission userPermission)
        {
            return await EditAsync(userPermission);
        }

        public async Task DeleteUserPermission(int id)
        {
            await DeleteAsync(id);
        }
    }
}