using NetCoreForum.DTOs.ErrorMessagesDTOs;
using NetCoreForum.Entites;

namespace NetCoreForum.Repositories.Abstract
{
    public interface IErrorMessageRepository
    {
        Task<ResultErrorMessageDTO> GetErrorMessagesAsync();
        Task<GetErrorMessageByErrorMessageNameDTO> GetErrorMessageByErrorMessageNameAsync(string ErrorMessageName);
        Task<string> GetErrorMessageByErrorMessageNameToStringAsync(string ErrorMessageName);
    }
}
