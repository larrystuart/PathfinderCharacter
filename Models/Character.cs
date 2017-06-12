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
        public ModifiableStat Age { get; set; }
        public ModifiableStat Weight { get; set; }
        public ModifiableStat Height { get; set; }
        public string Hair { get; set; }
        public string Eyes { get; set; }
        public ModifiableStat FlySpeed { get; set; }
        public ModifiableStat WalkSpeed { get; set; }
        public ModifiableStat SwimSpeed { get; set; }
        public ModifiableStat ClimbSpeed { get; set; }
        public ModifiableStat BurrowSpeed { get; set; }
        public ModifiableStat MaxHitpoints { get; set; }
        public ModifiableStat Initiative { get; set; }
        public ModifiableStat DamageReduction { get; set; }
        public int Damage { get; set; }
        public int NonLethatDamage { get; set; }

        //public List<Scar> Scars { get; set; }
        public ModifiableStat ArmorClass { get; set; }
        public ModifiableStat TouchArmorClass { get; set; }
        public ModifiableStat FlatFootedArmorClass { get; set; }
        public ModifiableStat BaseAttackBonus { get; set; }
        //public CharacterSave FortitudeSave { get; set; }
        //public CharacterSave ReflexSave { get; set; }
        //public CharacterSave WillSave { get; set; }
        public ModifiableStat SpellResistance { get; set; }
        public ModifiableStat CombatManeuverBonus { get; set; }

        public ModifiableStat CombatManeuverDefense { get; set; }
        public List<Attack> Attacks { get; set; }
        public List<string> Languages { get; set; }
        public int ExperiencePoints { get; set; }
        public int



        public List<CharacterSkill> CharacterSkills {get;set;}
        public List<CharacterBloodline> CharacterBloodlines { get; set; }
        public List<CharacterHeroClass> CharacterHeroClasses { get; set; }
        public List<CharacterPatron> CharacterPatrons { get; set; }
        public List<Spell> CharacterKnownSpells { get; set; }
        public List<Spell> CharacterSpellbook { get; set; }
    }


    public class Attack {
        public Guid Id { get; set; }
        public ModifiableStat AttackBonus { get; set; }
        public ModifiableStat Critical { get; set; }
        //public DamageType DamageType { get; set; }
        //public Ammunition Ammunition { get; set; }
        public ModifiableStat D4s { get; set; }
        public ModifiableStat D6s { get; set; }
        public ModifiableStat D8s { get; set; }
        public ModifiableStat D10s { get; set; }
        public ModifiableStat D12s { get; set; }
        public ModifiableStat D20s { get; set; }
        public ModifiableStat BaseDamage { get; set; }
    }


    public class ModifiableStat
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
        public bool TrainedOnly { get; set; }
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
