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
    public class CharacterController : Controller
    {
        private PathfinderContext pfContext;

        public CharacterController(PathfinderContext pfContext)
        {
            this.pfContext = pfContext;

        }

        [Route("{Id}")]
        public Character Get(Guid? Id)
        {
            return pfContext.Characters.Find(Id);
        }
        
    }
}
