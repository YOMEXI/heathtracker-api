using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dataservice.Data;
using entities.DbSet;
using entities.Dtos.incoming;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }




        [HttpGet]
        public IActionResult GetUsers()
        {

            var users = _context.User.Where(x => x.Status == 1).ToList();

            return Ok(users);

        }

        [HttpPost]

        public IActionResult Adduser(UserDto user)
        {
            var _user = new User();

            _user.FirstName = user.FirstName;
            _user.LastName = user.LastName;
            _user.Email = user.Email;
            _user.Phone = user.Phone;
            _user.DateOfBirth = Convert.ToDateTime(user.DateOfBirth);
            _user.Country = user.Country;
            _user.Status = 1;

            _context.User.Add(_user);
            _context.SaveChanges();

            return Ok();
        }

        [HttpGet]
        [Route("getuser")]
        public IActionResult GetUser(Guid id)
        {
            var user = _context.User.FirstOrDefault(x => x.Id == id);

            return Ok(user);
        }

    }
}