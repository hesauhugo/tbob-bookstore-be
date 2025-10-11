using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bookstore.core.Models;
using Microsoft.AspNetCore.Mvc;

namespace bookstore.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = new List<User>()
            {
                new User(1,"Hesau"),
                new User(2,"Rodrigo"),
                new User(3,"Mourão"),
            };

            return Ok(users);
        }
    }
}