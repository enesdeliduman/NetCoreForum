using Microsoft.AspNetCore.Mvc;
using NetCoreForum.Repositories.Abstract;

namespace NetCoreForum.ViewComponents.DefaultLayout
{
    public class _DefaultLayoutTopicsComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
