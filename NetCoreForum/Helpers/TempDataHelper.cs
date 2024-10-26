using Microsoft.AspNetCore.Mvc;

namespace NetCoreForum.Helpers
{
    public static class TempDataHelper
    {
        public static void SetTempDataMessage(Controller controller, string message, string type)
        {
            controller.TempData["AlertMessage"] = message;
            controller.TempData["AlertType"] = type;
        }
    }
}