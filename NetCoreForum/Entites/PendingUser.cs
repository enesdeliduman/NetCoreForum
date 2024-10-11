namespace NetCoreForum.Entites
{
    public class PendingUser
    {
        public int PendingUserID { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsApproved { get; set; }
        public AppUser AppUser { get; set; } 
        public string AppUserID { get; set; } 
    }
}
