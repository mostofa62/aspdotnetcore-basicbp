using Microsoft.AspNetCore.Mvc;

namespace basicbp.Controllers
{
    public class TestController:Controller    {
        [Route("Start")]
        public IActionResult index(){
            return View();
        }

        [Route("Bypass/{name?}")]
        public IActionResult param(string name){
            ViewData["Message"] = "And something cames...: "+name;
            return View();
        }
    }
}