using Microsoft.AspNetCore.Mvc;

namespace Webapidemo.Controllers
{
    [ApiController]
    public class ItemsController : ControllerBase
    {
        [HttpGet]
        [Route("/items")]
        public string GetItems()
        {
            return "Read all the items";
        }
        [HttpGet]
        [Route("/items/{id}")]
        public string GetItemsbyid(int id)
        {
            return $"read item number:{id}";
        }
        [HttpPost]
        [Route("/item")]

        public string PostItems()
        {
            return "create item";
        }
        [HttpPut]
        [Route("/item")]
        public string PutItems()
        {
            return "update items";
        }
        [HttpDelete]
        [Route("/item")]
        public string DeleteItems(int id)
        {
            return $"delete item {id}";
        }
    }


}
