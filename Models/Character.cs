using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathfinderCharacter.Models
{
    public class Character
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public Alignment Alignment { get; set; }
        public string Diety { get; set; }
        public string Homeland { get; set; }
        //public Race Race { get; set; }
        //public Size Size { get; set; }
        public string Gender { get; set; }
        public CharacterStat Age { get; set; }
        public CharacterStat Weight { get; set; }
        public CharacterStat Height { get; set; }
        public string Hair { get; set; }
        public string Eyes { get; set; }
        public CharacterStat FlySpeed { get; set; }
        public CharacterStat WalkSpeed { get; set; }
        public CharacterStat SwimSpeed { get; set; }
        public CharacterStat ClimbSpeed { get; set; }
        public CharacterStat BurrowSpeed { get; set; }
        public CharacterStat MaxHitpoints { get; set; }

        public List<CharacterSkill> CharacterSkills {get;set;}
        public List<CharacterBloodline> CharacterBloodlines { get; set; }
        public List<CharacterHeroClass> CharacterHeroClasses { get; set; }
        public List<CharacterPatron> CharacterPatrons { get; set; }
        public List<Spell> CharacterKnownSpells { get; set; }
        public List<Spell> CharacterSpellbook { get; set; }
    }

    public class CharacterStat
    {
        public Guid Id { get; set; }
        public int Value { get; set; }     
    }

    public class Modifier
    {
        public Guid Id { get; set; }
        public Guid IdToModify { get; set; }
        public int Value { get; set; }
        public string ModifierType { get; set; }
        public bool Stackable { get; set; }
    }

    public class CharacterSkill
    {
        public Guid Id { get; set; }
        public Skill Skill { get; set; }
        public int Ranks { get; set; }
    }

    public class Skill
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Ability AbilityModifierType { get; set; }

    }

    public class Ability
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameShort { get; set; }
    }

    public class CharacterAbility
    {
        public Guid Id { get; set; }
        public Ability Ability { get; set; }
        public int BaseScore { get; set; }
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
