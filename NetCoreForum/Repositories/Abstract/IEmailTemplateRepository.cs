using NetCoreForum.DTOs.EmailTemplateDTOs;
using NetCoreForum.Entites;

namespace NetCoreForum.Repositories.Abstract
{
    public interface IEmailTemplateRepository
    {
        Task<ResultEmailTemplateDTO> GetEmailTemplatesAsync();
        Task<GetEmailTemplateByTemplateNameDTO> GetEmailTemplateByTemplateNameAsync(string TemplateName);
    }
}
