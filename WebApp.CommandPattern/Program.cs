using AspNetCoreDesignPatterns.BaseProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.CommandPattern.Models;

namespace AspNetCoreDesignPatterns.BaseProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using var scope = host.Services.CreateScope();
            var appIdentityDbContext = scope.ServiceProvider.GetRequiredService<AppIdentityDbContext>(); // AppIdentityDbContext nesne �rne�i almam�za yarar.
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();// UserManager nesne �rne�i almam�za yarar.
            appIdentityDbContext.Database.Migrate();// uygulama aya�a kalkt���nda migrationlar veritaban�na uygulanmad�ysa uygular ve veritaban� yoksa kendisi s�f�rdan olu�turur.
            if (!userManager.Users.Any())
            {
                userManager.CreateAsync(new AppUser()
                {
                    UserName = "SuperAdmin",
                    Email = "SuperAdmin@mail.com"
                }, "Password*-1").Wait();

                Enumerable.Range(1, 30).ToList().ForEach(x =>
                 {
                     appIdentityDbContext.Products.Add(new Product() { Name = $"Kalem{x}", Price = x * 10, Stock = x + 50 });
                 });
                appIdentityDbContext.SaveChanges();
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
