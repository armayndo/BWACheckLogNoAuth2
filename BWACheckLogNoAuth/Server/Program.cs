using BWACheckLogNoAuth.Server.Data.Context;
using BWACheckLogNoAuth.Server.Data.SeedData;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWACheckLogNoAuth.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Before update
            //CreateHostBuilder(args).Build().Run();

            //Store reference to CreateHostBuilder and deffer the run till later after seed the data
            var host = CreateHostBuilder(args).Build();

            //datacontext disposeable with using
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                //use trycatch because dont have error handle inside program
                try
                {
                    var context = services.GetRequiredService<AppDbContext>();
                    context.Database.Migrate();
                    Seed.SeedSurveyQuestion(context);
                    Seed.SeedSurveyAnswer(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occured during migration");
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
