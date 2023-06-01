using Microsoft.AspNetCore.Mvc;

namespace ProductControllerApp.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

namespace Mvc_Demo.Controllers
{
    public class ProductController : Controller
    {
        public string Index()
        {
            return "Index Action Method";
        }
        public string Details()
        {
            return "Deatils Action Method";
        }
        public string Create()
        {
            return "Create Action Method";
        }
        public string Edit()
        {
            return "Edit Action method ";
        }
        public string Delete()
        {
            return "Delete Action Method";
        }
    }
}











































