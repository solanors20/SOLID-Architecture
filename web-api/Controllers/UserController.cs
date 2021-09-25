using Entities;
using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUser<UserEntity> user;
        public UserController(IUser<UserEntity> user)
        {
            this.user = user;
        }

        [HttpPut]
        public IActionResult Add(UserEntity userEntity)
        {
            user.add(userEntity);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(user.get(5));
        }
    }
}
