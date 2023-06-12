using Contacts.Data;
using Contacts.DataContext;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var init = BuildWebHost(args);
            using (var scope = init.Services.CreateScope())
            {
                var s = scope.ServiceProvider;
                var c = s.GetRequiredService<ContactsDbContext>();
                InitDb.Initialize(c);
            }
            init.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
            .UseUrls("http://localhost:5000", "http://*:80")
               .UseStartup<Startup>()
            .ConfigureLogging(log => log.AddConsole())
               .Build();
    }
}
