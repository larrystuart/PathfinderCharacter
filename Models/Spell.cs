using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathfinderCharacter.Models
{
    public class Spell
    {
        public Spell()
        {
            Classes = new List<SpellClass>();
            SpellSubschools = new List<SpellSubschool>();
            Descriptors = new List<Descriptor>();
            Components = new List<Models.Component>();
            SpellSavingThrows = new List<SpellSavingThrow>();
            SpellDomains = new List<SpellDomain>();
            BloodlineSpells = new List<BloodlineSpell>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string HTMLDescription { get; set; }
        public bool Mythic { get; set; }
        public string MythicText { get; set; }
        public string AugmentedText { get; set; }
        public List<SpellClass> Classes { get; set; }
        public int SpellLikeAbilityLevel { get; set; }
        public School School { get; set; }
        public List<SpellSubschool> SpellSubschools { get; set; }
        public List<Descriptor> Descriptors { get; set; }
        public CastingTime CastingTime { get; set; }
        public List<Component> Components { get; set; }
        public ReferenceSource ReferenceSource { get; set; }
        public string Range { get; set; }
        public string Area { get; set; }
        public string Effect { get; set; }
        public string Targets { get; set; }
        public string Duration { get; set; }
        public List<SpellSavingThrow> SpellSavingThrows { get; set; }
        public bool SpellResistance { get; set; }
        public bool SpellResistanceHarmless { get; set; }
        public bool SpellResistanceObject { get; set; }
        public List<SpellDomain> SpellDomains { get; set; }
        public List<BloodlineSpell> BloodlineSpells { get; set; }
    }

    public class ReferenceSource
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class BloodlineSpell
    {
        public Guid Id { get; set; }
        public Bloodline Bloodline { get; set; }
        public int level { get; set; }
    }

    //public class Effect
    //{
    //    public Guid Id { get; set; }
    //    string 
    //}

    public class SpellClass
    {
        public Guid Id { get; set; }
        public HeroClass HeroClass { get; set; }
        public int ClassLevel { get; set; }
    }


    public class School
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class Subschool
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class SpellSubschool
    {
        public Guid Id { get; set; }
        public Subschool Subschool { get; set; }
    }

    public class Descriptor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class CastingTime
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    //public class Range
    //{
    //    public Guid Id { get; set; }
    //    public string Name { get; set; }
    //    public int BaseAmount { get; set; }
    //    public int LevelsToBonus { get; set; }
    //    public int BonusAmount { get; set; }

    //    public int CalculateRange(int level)
    //    {
    //        return BaseAmount + ((int)Math.Floor((decimal)level / LevelsToBonus) * BonusAmount);
    //    }
    //}

    public class ComponentType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
    }

    public class Component
    {
        public Guid Id { get; set; }
        public string Material { get; set; }
        public Currency MaterialCost { get; set; }
        public ComponentType ComponentType { get; set; }
    }

    //public class Area
    //{
    //    public Guid Id { get; set; }
    //    public int Width { get; set; }
    //    public int Height { get; set; }
    //    public int Radius { get; set; }
    //    public Shape Shape { get; set; }

    //}

    //public class Shape
    //{
    //    public Guid Id { get; set; }
    //    public string Name { get; set; }
    //    public bool CenteredOnYou { get; set; }
    //}

    //public class Duration
    //{
    //    public Guid Id { get; set; }
    //    public int BaseAmount { get; set; }
    //    public TimeUnit TimeUnit { get; set; }
    //    public int BonusAmount { get; set; }
    //    public int LevelsToBonus { get; set; }

    //    public string CalculateDuration(int level)
    //    {
    //        return (BaseAmount + ((int)Math.Floor((decimal)level / LevelsToBonus) * BonusAmount)).ToString() + TimeUnit.Name;
    //    }
    //}

    public class TimeUnit
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int TimeInSeconds { get; set; }
    }

    public class SavingThrow
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class SpellSavingThrow
    {
        public Guid Id { get; set; }
        public SavingThrow SavingThrow { get; set; }
    }

    public class SpellDomain
    {
        public Guid Id { get; set; }
        public Domain Domain { get; set; }
        public int Level { get; set; }

    }

    public class Domain
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
