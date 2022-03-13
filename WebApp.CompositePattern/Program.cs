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
using WebApp.CompositePattern.Models;

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
                var newUser = new AppUser() { UserName = "SuperAdmin", Email = "SuperAdmin@mail.com" };
                userManager.CreateAsync(newUser, "Password*-1").Wait();

                var newCategory = new Category { Name = "Su� Romanlar�", ReferanceId = 0, UserId = newUser.Id };
                var newCategory2 = new Category { Name = "Cinayet Romanlar�", ReferanceId = 0, UserId = newUser.Id };
                var newCategory3 = new Category { Name = "Polisiye Romanlar�", ReferanceId = 0, UserId = newUser.Id };

                appIdentityDbContext.Categories.AddRange(newCategory, newCategory2, newCategory3);
                appIdentityDbContext.SaveChanges();

                var subCategory = new Category { Name = "Cinayet Romanlar� 1", ReferanceId = newCategory2.Id, UserId = newUser.Id };
                var subCategory2 = new Category { Name = "Su� Romanlar� 1", ReferanceId = newCategory.Id, UserId = newUser.Id };
                var subCategory3 = new Category { Name = "Polisiye Romanlar� 1", ReferanceId = newCategory3.Id, UserId = newUser.Id };
                appIdentityDbContext.Categories.AddRange(subCategory, subCategory2, subCategory3);
                appIdentityDbContext.SaveChanges();

                var subCategory4 = new Category { Name = "Cinayet Romanlar� 1.1", ReferanceId = subCategory.Id, UserId = newUser.Id };
                appIdentityDbContext.Categories.Add(subCategory4);
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
