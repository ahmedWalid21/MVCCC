using Microsoft.AspNetCore.Mvc;

namespace MVCCC.Controllers
{
    public class HomeController : Controller
    {
        //Veiw:HTML page
        //Razor page: html + C#  
        public IActionResult Index()
        {
            return View();
        }
    }
}
