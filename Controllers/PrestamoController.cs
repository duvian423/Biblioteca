using Microsoft.AspNetCore.Mvc;
    namespace mvc.controllers{
    
        public class PrestamoController : Controller{
            public IActionResult Index(){
                return View();
            }
        }
    }