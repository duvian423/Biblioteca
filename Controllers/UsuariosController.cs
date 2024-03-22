using Microsoft.AspNetCore.Mvc;
    namespace mvc.controllers{
    
        public class UsuariosController : Controller{
            public IActionResult Index(){
                return View();
            }
        }
    }