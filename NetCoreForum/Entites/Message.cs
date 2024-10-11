namespace NetCoreForum.Entites
{
    public class Message
    {
        public int MessageID { get; set; }
        public string MessageSenderID { get; set; }
        public string MessageReceiverID { get; set; }
        public string MessageContent { get; set; }
        public bool MessageIsRead { get; set; }
        public DateTime MessageSentAt { get; set; } = DateTime.Now;
    }
}
