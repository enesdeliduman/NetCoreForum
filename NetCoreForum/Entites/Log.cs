namespace NetCoreForum.Entites
{
    public class Log
    {
        public int LogID { get; set; }
        public string ActionType { get; set; }
        public string ActionDetails { get; set; }
        public DateTime LogCreatedAt { get; set; }
        public AppUser AppUser { get; set; }
        public string AppUserID { get; set; }
    }
}
