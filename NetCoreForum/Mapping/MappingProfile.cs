using AutoMapper;
using NetCoreForum.DTOs.EmailTemplateDTOs;
using NetCoreForum.DTOs.ErrorMessagesDTOs;
using NetCoreForum.DTOs.PendingUserDTOs;
using NetCoreForum.DTOs.SiteSettingsDTOs;
using NetCoreForum.Entites;
using NetCoreForum.Entities;

namespace NetCoreForum.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SiteSettings, ResultSiteSettingsDTO>();

            CreateMap<EmailTemplate, ResultEmailTemplateDTO>();
            CreateMap<EmailTemplate, GetEmailTemplateByTemplateNameDTO>();

            CreateMap<PendingUser, CreatePendingUserDTO>();
            CreateMap<CreatePendingUserDTO, PendingUser>();

            CreateMap<ErrorMessage, ResultErrorMessageDTO>();
            CreateMap<ErrorMessage, GetErrorMessageByErrorMessageNameDTO>();

        }
    }
}
