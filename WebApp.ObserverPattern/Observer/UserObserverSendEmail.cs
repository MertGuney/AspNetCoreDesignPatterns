using AspNetCoreDesignPatterns.BaseProject.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Net.Mail;

namespace WebApp.ObserverPattern.Observer
{
    public class UserObserverSendEmail : IUserObserver
    {
        private readonly IServiceProvider _serviceProvider;

        public UserObserverSendEmail(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void UserCreated(AppUser appUser)
        {
            var logger = _serviceProvider.GetRequiredService<ILogger<UserObserverSendEmail>>();

            var mailMessage = new MailMessage();

            var smtpClient = new SmtpClient(""); // sunucu(hosting) mail bilgisi bilgisi

            mailMessage.From = new MailAddress("deneme@mertguney.com"); // kimden mail gidecek

            mailMessage.To.Add(new MailAddress(appUser.Email)); // kime mail gidecek

            mailMessage.Subject = "Sitemize hoş geldiniz.";
            mailMessage.Body = "<p>Sitemizin genel kuralları: ............ </p>";
            mailMessage.IsBodyHtml = true;

            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("deneme@mertguney.com", "Password*-1"); // mail için oluşturduğumuz şifre
            smtpClient.Send(mailMessage);
            logger.LogInformation($"Email was send to user : {appUser.UserName}");
        }
    }
}
