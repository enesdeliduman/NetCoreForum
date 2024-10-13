using NetCoreForum.DTOs.SiteSettingsDTOs;
using NetCoreForum.Entites;

namespace NetCoreForum.Repositories.Abstract
{
    public interface ISiteSettingsRepository
    {
        Task<ResultSiteSettingsDTO> GetSiteSettingsAsync();
    }
}
