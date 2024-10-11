using AutoMapper;
using NetCoreForum.DTOs.SiteSettingsDTOs;
using NetCoreForum.Entites;

namespace NetCoreForum.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SiteSettings, ResultSiteSettingsDto>();
        }
    }
}
