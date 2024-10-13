namespace NetCoreForum.Entites
{
    public class EmailConfiguration
    {
        public int EmailConfigurationID { get; set; }
        public string SmtpServer { get; set; }
        public int Port { get; set; }
        public string SenderEmail { get; set; }
        public string SenderName { get; set; }
        public string SenderPassword { get; set; }
        public bool UseSSL { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
