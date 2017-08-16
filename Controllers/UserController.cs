using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PathfinderCharacter.Models;
using Microsoft.EntityFrameworkCore;

namespace PathfinderCharacter.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private PathfinderContext pfContext;

        public UserController(PathfinderContext pfContext)
        {
            this.pfContext = pfContext;
        }

        public User Get(string AuthKey)
        {
            return pfContext.Users.Include(u => u.UserCharacters).FirstOrDefault(u => u.AuthenticationId == AuthKey);
        }
        
    }
}
