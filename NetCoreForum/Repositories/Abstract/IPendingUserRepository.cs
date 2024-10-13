using NetCoreForum.DTOs.PendingUserDTOs;

namespace NetCoreForum.Repositories.Abstract
{
    public interface IPendingUserRepository
    {
        Task CreatePendingUserAsync(CreatePendingUserDTO createPendingUserDTO);
    }
}
