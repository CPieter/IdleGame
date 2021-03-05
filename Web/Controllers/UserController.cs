using DataInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserDA _userDA;

        public UserController(IUserDA userDA)
        {
            _userDA = userDA;
        }

        //POST user/{username}
        [HttpPost("{username}")]
        public IActionResult Post(string username)
        {
            string ip = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            User user = new User(Guid.NewGuid(), ip, username);

            user = _userDA.Create(user);
            return StatusCode(201, user);
        }

        //GET user
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userDA.ReadAll();
        }

        //GET user/{idString}
        [HttpDelete("{idString}")]
        public IActionResult Delete(string idString)
        {
            try
            {
                Guid id = Guid.Parse(idString);
                if (_userDA.Delete(id) > 0)
                {
                    return StatusCode(204);
                }
            }
            catch 
            {
                return StatusCode(400);
            }
            return StatusCode(404, "Missing Resource");
        }
    }
}
