﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using AES.Entities.Shared.Net45.Models;
using WebApiRestService;

namespace AES.WebApplication.Client
{
    public class TestSVCClient : WebApiClient<Test>
    {
        public static readonly WebApiClientOptions options = new WebApiClientOptions()
        {
            BaseAddress = "http://localhost:" + "59095" + "/",
            ContentType = ContentType.Json,
            Timeout = 80000,
            Controller = "api/Test"
        };

        /// <summary>
        /// Creates an instance of TestClient using default options
        /// </summary>
        public TestSVCClient()
            : this(options)
        {
        }

        /// <summary>
        /// Creates an instance of TestClient using explicit options
        /// </summary>
        private TestSVCClient(WebApiClientOptions options)
            : base(options)
        {
        }

        public async Task<IEnumerable<Test>> GetTests()
        {
            return await GetManyAsync();
        }

        public async Task<Test> GetTestById(int? id)
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

        public async Task<Test> CreateTest(Test Test)
        {
            return await CreateAsync(Test);
        }

        public async Task<Test> EditTest(Test Test)
        {
            return await EditAsync(Test);
        }

        public async Task DeleteStore(int id)
        {
            await DeleteAsync(id);
        }
    }
}