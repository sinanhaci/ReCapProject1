using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers.Autofac;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory()) // Autofac Kullanmak için eklediðimiz satýrlar.
                .ConfigureContainer<ContainerBuilder>(builder =>                // Autofac Kullanmak için eklediðimiz satýrlar.
                {                                                               // Autofac Kullanmak için eklediðimiz satýrlar.
                    builder.RegisterModule(new AutofacBusinessModule());        // Autofac Kullanmak için eklediðimiz satýrlar.
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
