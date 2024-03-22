using Microsoft.AspNetCore.Mvc;
    namespace mvc.controllers{
    
        public class HistorialController : Controller{
            public IActionResult Index(){
                return View();
            }
        }
    }