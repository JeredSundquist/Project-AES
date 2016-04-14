using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using TrackableEntities.Client;
using AES.Entities.Shared.Net45.Models;

// This is an example which retrieves customers and orders from the Northwind
// sample database. You should alter the code based on your own database schema.

namespace AES.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main method
            
            Console.WriteLine("Press Enter to start");
            Console.ReadLine();

            // Create http client
            // TODO: Replace with port from web project
            const string serviceBaseAddress = "http://localhost:" + "59095" + "/";
            var client = new HttpClient { BaseAddress = new Uri(serviceBaseAddress) };

        }

        // Service methods
         
        private static IEnumerable<Position> GetCustomers(HttpClient client)
        {
            const string request = "api/Position";
            var response = client.GetAsync(request).Result;
            response.EnsureSuccessStatusCode();
            var result = response.Content.ReadAsAsync<IEnumerable<Position>>().Result;
            return result;
        }
    }
}
