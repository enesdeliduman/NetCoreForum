using Microsoft.AspNetCore.Identity;

namespace NetCoreForum.Entites
{
    public class AppUser : IdentityUser
    {
        public string UserPhoto { get; set; }
        public string UserSignature { get; set; }
        public bool isActive { get; set; }
        public ICollection<Warning> Warnings { get; set; }
        public ICollection<Reply> Replies { get; set; }
        public ICollection<Topic> Topics { get; set; }
    }
}
