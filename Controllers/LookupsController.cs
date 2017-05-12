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
    public class LookupsController : Controller
    {
        private IMemoryCache _cache;

        private PathfinderContext pfContext;

        public LookupsController(PathfinderContext pfContext, IMemoryCache memoryCache)
        {
            _cache = memoryCache;
            this.pfContext = pfContext;
        }

        //var rng = new Random();
        //rng.Next(-20, 55)
        //Summary = Summaries[rng.Next(Summaries.Length)]

        [HttpGet("[action]")]
        public IEnumerable<HeroClass> HeroClasses()
        {
            string key = "heroClassCache";
            List<HeroClass> myHeroClasses;

            if (!_cache.TryGetValue(key, out myHeroClasses))
            {
                myHeroClasses = pfContext.HeroClasses.ToList();
                _cache.Set(key, myHeroClasses,
                    new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(30)));
            }
            else
            {
                myHeroClasses = _cache.Get(key) as List<HeroClass>;
            }
            
            return myHeroClasses;
        }

        [HttpGet("[action]")]
        public IEnumerable<School> Schools()
        {
            string key = "schoolCache";
            List<School> mySchools;

            if (!_cache.TryGetValue(key, out mySchools))
            {
                mySchools = pfContext.Schools.ToList();
                _cache.Set(key, mySchools,
                    new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(30)));
            }
            else
            {
                mySchools = _cache.Get(key) as List<School>;
            }

            return mySchools;
        }

        [HttpGet("[action]")]
        public IEnumerable<SavingThrow> SavingThrows()
        {
            string key = "savingThrowCache";
            List<SavingThrow> mySavingThrows;

            if (!_cache.TryGetValue(key, out mySavingThrows))
            {
                mySavingThrows = pfContext.SavingThrows.ToList();
                _cache.Set(key, mySavingThrows,
                    new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(30)));
            }
            else
            {
                mySavingThrows = _cache.Get(key) as List<SavingThrow>;
            }

            return mySavingThrows;
        }

    }
}
