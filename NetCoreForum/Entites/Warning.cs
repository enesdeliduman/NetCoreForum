namespace NetCoreForum.Entites
{
    public class Warning
    {
        public int WarningID { get; set; }
        public string WarningTitle { get; set; }
        public string WarningDescription { get; set; }
        public DateTime WarningCreatedAt { get; set; }

        public AppUser AppUser { get; set; }
        public string AppUserID { get; set; }
    }
}
