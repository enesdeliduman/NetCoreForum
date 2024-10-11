using Microsoft.AspNetCore.Mvc;

namespace NetCoreForum.ViewComponents.DefaultLayout
{
    public class _DefaultLayoutScriptsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
