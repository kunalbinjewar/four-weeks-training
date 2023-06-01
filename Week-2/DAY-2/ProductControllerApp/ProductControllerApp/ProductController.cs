using Microsoft.AspNetCore.Mvc;

namespace ProductControllerApp
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return Content("Action: Index");
        }
        public IActionResult Details(int id)
        {
            return Content($"Action: Details, ID: {id}");
        }
        public IActionResult Create()
        {
            return Content("Action: Create");
        }
        public IActionResult Edit(int id)
        {
            return Content($"Action: Edit, ID: {id}");
        }
        public IActionResult Delete(int id)
        {
            return Content($"Action: Delete, ID: {id}");
        }
    }
}
















