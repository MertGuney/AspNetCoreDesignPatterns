using WebApp.TemplatePattern.Models;
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

namespace WebApp.TemplatePattern
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
                    Email = "SuperAdmin@mail.com",
                    PictureUrl="/pic/user/prime.jpg",
                    Description= "Maecenas ac posuere est. Donec sollicitudin a nisi auctor eleifend. Morbi vitae cursus felis. Sed accumsan dolor erat, at sagittis arcu tincidunt vitae. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Fusce mattis ullamcorper elit, in tincidunt augue egestas tempor."
                }, "Password*-1").Wait();
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
