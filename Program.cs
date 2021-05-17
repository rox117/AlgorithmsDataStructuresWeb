using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedLists.Models.LinkedListImpl<int> list = new LinkedLists.Models.LinkedListImpl<int>();
            list.printList();
            list.reverseIterative();
            list.printList();
            list._head=list.reverseRecursive(list._head);
            list.printList();
            CreateHostBuilder(args)
             .ConfigureLogging(logging =>
              {
                  logging.ClearProviders();
                  logging.AddConsole();
                  logging.AddDebug();
              }).Build().Run();

            
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
