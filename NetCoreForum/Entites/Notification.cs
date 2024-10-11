using Microsoft.AspNetCore.Identity;

namespace NetCoreForum.Entites
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public string NotificationContent { get; set; }
        public string NotificationType { get; set; }
        public bool NotificationIsRead { get; set; } = false;
        public DateTime NotificationCreatedAt { get; set; } = DateTime.Now;
        public AppUser AppUser { get; set; }
        public string AppUserID { get; set; }
    }
}
