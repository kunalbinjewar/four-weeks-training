using Microsoft.AspNetCore.Mvc;
using MYWEBAPP2.Models;

namespace Mvc_Demo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return Content( "Index Action Method");
            //ViewData["Name"] = "Krunal";

            return View();
           
        }

        public IActionResult Details(Product a)
        {
            //return "Deatils Action Method";
            var kun = new ProductDetailsViewModel
            {
                Product = a,
                DisplayMessage = "this is the product details"
        };
            return View();
         
        }
        public IActionResult Create(Product prd1)
        {
            //return "Create Action Method";
            //return View();
            return Ok(prd1);
        }
        public IActionResult Edit(Product prd2)
        {
            //return "Edit Action method ";
            //return View();
            return Ok(prd2);
        }
        public IActionResult Delete()
        {
            //return "Delete Action Method";
            return View();
            
        }
    }
}



















