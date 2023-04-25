using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PubSub.Entity;
using PubSub.Services;

namespace PubSub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        // Constructor
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult GetAsync()
        {
            return Ok(_userService.GetAsync());
        }

        [HttpPost]
        public IActionResult CreateAsync(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            _userService.CreateAsync(user);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAsync()
        {
            var user = new User();
           return _userService.UpdateAsync(user);
        }

        [HttpDelete]
        public IActionResult DeleteAsync()
        {
                var user = new User();
           return _userService.DeleteAsync(user);
        }
    }
}