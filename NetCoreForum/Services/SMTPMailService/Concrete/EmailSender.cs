using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreForum.Data;
using System.Net;
using System.Net.Mail;

namespace NetCoreForum.Services.SMTPMailServer.Abstract
{
    public class EmailSender : IEmailSender
    {
        private readonly ApplicationDbContext _context;

        public EmailSender(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SendEmailAsync(string recipientEmail, string subject, string message)
        {
            var emailConfig = await _context.EmailConfigurations.FirstOrDefaultAsync();
            if (emailConfig == null)
                throw new Exception("SMTP yapılandırması bulunamadı.");

            var smtpClient = new SmtpClient(emailConfig.SmtpServer)
            {
                Port = emailConfig.Port,
                Credentials = new NetworkCredential(emailConfig.SenderEmail, emailConfig.SenderPassword),
                EnableSsl = emailConfig.UseSSL,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(emailConfig.SenderEmail, emailConfig.SenderName),
                Subject = subject,
                Body = message,
                IsBodyHtml = true,
            };

            mailMessage.To.Add(recipientEmail);
            try
            {
                await smtpClient.SendMailAsync(mailMessage);
            }
            catch (SmtpException smtpEx)
            {
                // SMTP hatası
                Console.WriteLine($"SMTP Hatası: {smtpEx.Message}");
            }
            catch (Exception ex)
            {
                // Genel hata
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }
    }
}