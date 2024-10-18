using Microsoft.AspNetCore.Identity;

namespace NetCoreForum.Entites
{
    public class AppUser : IdentityUser
    {
        public string? UserPhoto { get; set; } = "default-user.png";
        public string? UserSignature { get; set; }
        public string? UserBiography { get; set; }
        public bool isActive { get; set; }
        public ICollection<Warning> Warnings { get; set; } = new List<Warning>();
        public ICollection<Reply> Replies { get; set; } = new List<Reply>();
        public ICollection<Topic> Topics { get; set; } = new List<Topic>();
    }
}
