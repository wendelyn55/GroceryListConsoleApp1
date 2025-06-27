using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using GroceryListBusinessLogic;


namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroceryListController : ControllerBase
    {
        GroceryListService groceryService = new GroceryListService();

        [HttpGet]
        public List<string> GetItems()
        {
            return groceryService.GetItems();
        }

        [HttpPost]
        public bool AddItem([FromQuery] string item)
        {
            if (string.IsNullOrWhiteSpace(item))
                return false;

            return groceryService.AddItem(item);
        }

        [HttpDelete]
        public bool RemoveItem([FromQuery] string item)
        {
            if (string.IsNullOrWhiteSpace(item))
                return false;

            return groceryService.RemoveItem(item);
        }

        [HttpDelete("clear")]
        public bool ClearAll()
        {
            groceryService.ClearList();
            return true;
        }
    }
}

















