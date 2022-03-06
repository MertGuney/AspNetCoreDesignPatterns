using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace WebApp.ChainOfResponsibilityPattern.ChainOfResponsibility
{
    public class SendEmailProcessHandler : ProcessHandler
    {
        private readonly string _fileName;
        private readonly string _toEmail;

        public SendEmailProcessHandler(string fileName, string toEmail)
        {
            _fileName = fileName;
            _toEmail = toEmail;
        }

        public override object Handle(object o)
        {
            var zipMemoryStream = o as MemoryStream;
            zipMemoryStream.Position = 0;

            var mailMessage = new MailMessage();

            var smtpClient = new SmtpClient(""); // sunucu(hosting) mail bilgisi bilgisi

            mailMessage.From = new MailAddress("deneme@mertguney.com"); // kimden mail gidecek

            mailMessage.To.Add(new MailAddress(_toEmail)); // kime mail gidecek

            mailMessage.Subject = "Zip Dosyası";
            mailMessage.Body = "<p>Zip Dosyası Ektedir.</p>";

            Attachment attachment = new(zipMemoryStream, _fileName, MediaTypeNames.Application.Zip);
            mailMessage.Attachments.Add(attachment);

            mailMessage.IsBodyHtml = true;

            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("deneme@mertguney.com", "Password*-1"); // mail için oluşturduğumuz şifre
            smtpClient.Send(mailMessage);

            return base.Handle(o);
        }

    }
}
