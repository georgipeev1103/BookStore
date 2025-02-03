using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookStoreController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult GetBookStores()
        {
            
            var bookStores = new string[] { "BookStore1", "BookStore2", "BookStore3" };
            return Ok(bookStores);
        }

        
        [HttpPost]
        public IActionResult CreateBookStore([FromBody] string storeName)
        {
            
            return CreatedAtAction(nameof(GetBookStores), new { id = 1 }, storeName);
        }

        
    }
}
