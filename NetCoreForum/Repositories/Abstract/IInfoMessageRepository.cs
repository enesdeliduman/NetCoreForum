using NetCoreForum.DTOs.InfoMessagesDTOs;
using NetCoreForum.Entites;

namespace NetCoreForum.Repositories.Abstract
{
    public interface IInfoMessageRepository
    {
        Task<ResultInfoMessageDTO> GetInfoMessagesAsync();
        Task<GetInfoMessageByInfoMessageNameDTO> GetInfoMessageByInfoMessageNameAsync(string InfoMessageName);
        Task<string> GetInfoMessageByInfoMessageNameToStringAsync(string InfoMessageName);
    }
}
