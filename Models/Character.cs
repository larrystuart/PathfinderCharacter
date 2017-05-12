using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathfinderCharacter.Models
{
    public class Character
    {
        public Guid Id { get; set; }
        public List<CharacterBloodline> CharacterBloodlines { get; set; }
        public List<CharacterHeroClass> CharacterHeroClasses { get; set; }
        public List<CharacterPatron> CharacterPatrons { get; set; }
    }

    public class CharacterHeroClass
    {
        public Guid Id { get; set; }
        public int Level { get; set; }
        public HeroClass HeroClass { get; set; }
    }

    public class HeroClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class CharacterBloodline
    {
        public Guid Id { get; set; }
        public Bloodline Bloodline { get; set; }
        public int Level { get; set; }
    }
    public class Bloodline
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class CharacterPatron
    {
        public Guid Id { get; set; }
        public Patron Patron { get; set; }
        public int Level { get; set; }
    }

    public class Patron
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
