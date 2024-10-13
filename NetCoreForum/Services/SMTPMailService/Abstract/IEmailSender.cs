namespace NetCoreForum.Services.SMTPMailServer.Concrete
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string recipientEmail, string subject, string message);
    }

}