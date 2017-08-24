using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PathfinderCharacter.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.EntityFrameworkCore;

namespace PathfinderCharacter.Controllers
{
    [Route("api/[controller]")]
    public class SpellbookController : Controller
    {
        private PathfinderContext pfContext;

        public SpellbookController(PathfinderContext pfContext)
        {
            this.pfContext = pfContext;
        }

        [Route("{bookId}")]
        public Spellbook Get(Guid bookId)
        {
            Spellbook spellbook = pfContext.SpellBooks.Include(sb => sb.Spells).ThenInclude(s => s.Spell).First(sb => sb.Id == bookId);

            return spellbook;
        }

        [Route("[action]/{characterId}")]
        public IEnumerable<Spellbook> GetBooks(Guid? characterId)
        {
            Character currentCharacter = pfContext.Characters.Include(c => c.CharacterSpellbooks).ThenInclude(sb => sb.Spells).ThenInclude(s => s.Spell).First(c => c.Id == characterId);

            return currentCharacter.CharacterSpellbooks;
        }

    }
}
