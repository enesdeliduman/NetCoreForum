using Microsoft.AspNetCore.Mvc;
using NetCoreForum.Repositories.Abstract;

namespace NetCoreForum.ViewComponents.DefaultLayout
{
    public class _DefaultLayoutHeadComponentPartial : ViewComponent
    {
        private readonly ISiteSettingsRepository _siteSettingsRepository;

        public _DefaultLayoutHeadComponentPartial(ISiteSettingsRepository siteSettingsRepository)
        {
            _siteSettingsRepository = siteSettingsRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _siteSettingsRepository.GetSiteSettingsAsync();
            return View(values);
        }
    }
}
