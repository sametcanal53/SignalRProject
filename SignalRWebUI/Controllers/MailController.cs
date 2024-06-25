using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SignalRWebUI.Dtos.Mails.Create;

namespace SignalRWebUI.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CreateMailDto createMailDto)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.Subject = createMailDto.Subject;
            var mailboxAddressFrom = new MailboxAddress("SignalR Rezervasyon", "s1ss2as@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            var mailboxAddressTo = new MailboxAddress(createMailDto.Receiver, createMailDto.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = createMailDto.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            var client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("s1ss2as@gmail.com", "zgyf xjlv yyms zeko");

            client.Send(mimeMessage);
            client.Disconnect(true);

            return RedirectToAction("Index", "category");
        }
    }
}
