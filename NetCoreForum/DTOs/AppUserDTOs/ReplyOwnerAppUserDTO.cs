using Microsoft.AspNetCore.Identity;

namespace NetCoreForum.Entites
{
    public class ReplyOwnerAppUserDTO
    {
        public string? UserPhoto { get; set; }
        public string? UserName { get; set; }
        public string? UserSignature { get; set; }
        public string? UserBiography { get; set; }
    }
}
