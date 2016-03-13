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
    public class StoreSVCClient : WebApiClient<Store>
    {
            public static readonly WebApiClientOptions options = new WebApiClientOptions()
            {
                BaseAddress = "http://localhost:" + "59095" + "/",
                ContentType = ContentType.Json,
                Timeout = 80000,
                Controller = "api/Store"
            };

            /// <summary>
            /// Creates an instance of StoreClient using default options
            /// </summary>
            public StoreSVCClient()
                : this(options)
            {
            }

            /// <summary>
            /// Creates an instance of StoreClient using explicit options
            /// </summary>
            private StoreSVCClient(WebApiClientOptions options)
                : base(options)
            {
            }

            public async Task<IEnumerable<Store>> GetStores()
            {
                return await GetManyAsync();
            }

            public async Task<Store> GetStoreById(int? id)
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

            public async Task<Store> CreateStore(Store store)
            {
                return await CreateAsync(store);
            }

            public async Task<Store> EditStore(Store store)
            {
                return await EditAsync(store);
            }

            public async Task DeleteStore(int id)
            {
                await DeleteAsync(id);
            }
        }
}