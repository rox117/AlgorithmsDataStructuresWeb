using AlgorithmsDataStructuresWeb.LinkedLists.Util;
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
            LinkedLists.Models.LinkedList list = new LinkedLists.Models.LinkedList();
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };
            foreach (int i in array2)
            {
                list.append(i);
            }

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
