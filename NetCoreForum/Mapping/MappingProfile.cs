using AutoMapper;
using NetCoreForum.DTOs.EmailTemplateDTOs;
using NetCoreForum.DTOs.ErrorMessagesDTOs;
using NetCoreForum.DTOs.PendingUserDTOs;
using NetCoreForum.DTOs.ReplyDTOs;
using NetCoreForum.DTOs.SiteSettingsDTOs;
using NetCoreForum.DTOs.TopicDTOs;
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

            CreateMap<Topic, GetTopicDTO>();

            CreateMap<Reply, ResultReplyDTO>();
            CreateMap<Reply, CreateReplyDTO>();
            CreateMap<CreateReplyDTO, Reply>();

            CreateMap<AppUser, TopicOwnerAppUserDTO>();
            CreateMap<AppUser, ReplyOwnerAppUserDTO>();

            CreateMap<Topic, Last10TopicForHomePageDTO>()
              .ForMember(dest => dest.AppUser, opt => opt.MapFrom(src => src.AppUser.UserName))
              .ForMember(dest => dest.CategoryTitle, opt => opt.MapFrom(src => src.Category.CategoryTitle));

        }
    }
}
