using System.Threading.Tasks;
using basicbp.Models;
using Microsoft.AspNetCore.Mvc;
namespace basicbp.Controllers
{
    public class ItemController:Controller
    {

        public IActionResult index(){

            return View();
        }
        public IActionResult create(){
            return View();
        }

        [HttpPost]
        public async  Task<ActionResult<Items>> create([Bind("Name")]Items item){

            if(ModelState.IsValid){
                return item;
            }
            return View(item);

        }
        
    }
}