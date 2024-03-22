using Microsoft.AspNetCore.Mvc;
    namespace mvc.controllers{
    
        public class LibrosController : Controller{
            public IActionResult Index(){
                return View();
            }
        }
    }