using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using basicbp.Models;

namespace basicbp.Controllers
{
    [Route("v1")]
    [ApiController]
    public class TestapiController:ControllerBase
    {
        
        [HttpPost]
        [Route("Additem")]
        public ActionResult<Items> AddItem(Items item){
            return item;
        }
    }
}