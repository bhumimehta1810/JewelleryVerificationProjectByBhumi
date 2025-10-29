using Microsoft.AspNetCore.Mvc;

namespace JewelleryVerificationProject.Controllers
{
    public class DataEntryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
