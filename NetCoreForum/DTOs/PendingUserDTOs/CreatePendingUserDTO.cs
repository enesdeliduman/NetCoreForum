using NetCoreForum.Entites;

namespace NetCoreForum.DTOs.PendingUserDTOs
{
    public class CreatePendingUserDTO
    {
        public DateTime RegistrationDate { get; set; }
        public AppUser AppUser { get; set; }
        public string AppUserID { get; set; }
    }
}
