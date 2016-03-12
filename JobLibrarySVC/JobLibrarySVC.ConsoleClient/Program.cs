using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using TrackableEntities.Client;
using JobLibrarySVC.Entities.Shared.Net45;


namespace JobLibrarySVC.ConsoleClient
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
            const string serviceBaseAddress = "http://localhost:" + "5161" + "/";
            var client = new HttpClient {BaseAddress = new Uri(serviceBaseAddress)};
        }
    }
}
