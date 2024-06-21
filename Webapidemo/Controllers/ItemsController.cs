using Microsoft.AspNetCore.Mvc;

namespace Webapidemo.Controllers
{
    [ApiController]
    [Route ("/api[Controller]")]
    public class ItemsController : ControllerBase
    {
        [HttpGet]
        public string GetItems()
        {
            return "Read all the items";
        }
        [HttpGet("{id}")]
        public string GetItemsbyid(int id)
        {
            return $"read item number:{id}";
        }
        [HttpPost]
        public string PostItems()
        {
            return "create item";
        }
        
        [HttpPut]
        public string PutItems()
        {
            return "update items";
        }
        [HttpDelete("{id}")]
        public string DeleteItems(int id)
        {
            return $"delete item {id}";
        }
    }


}
