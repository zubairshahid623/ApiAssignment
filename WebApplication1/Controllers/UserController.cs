using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UserDbContext _userDbContext;

        public UserController(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
      
        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Putbooking(UserData booking)
        {
            // Save the product to the database
            _userDbContext.User_Details.Add(booking);
            _userDbContext.SaveChanges();
            return Ok();
        }
    }
}
