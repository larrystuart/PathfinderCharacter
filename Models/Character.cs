using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string Hair { get; set; }
        public string Eyes { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }
        public ModifiableStat Age { get; set; }
        public List<CharacterSkill> CharacterSkills { get; set; }
        public List<CharacterAbility> CharacterAbilities { get; set; }
        //public List<Scar> Scars { get; set; }
        
        public List<Language> Languages { get; set; }

        
        public List<CharacterBloodline> CharacterBloodlines { get; set; }
        public List<CharacterHeroClass> CharacterHeroClasses { get; set; }
        public List<CharacterPatron> CharacterPatrons { get; set; }
        public List<Spell> CharacterKnownSpells { get; set; }
        public List<Spellbook> CharacterSpellbooks { get; set; }

        public Character()
        {
            Languages = new List<Language>();
            CharacterBloodlines = new List<CharacterBloodline>();
            CharacterSkills = new List<CharacterSkill>();
            CharacterAbilities = new List<CharacterAbility>();
            CharacterHeroClasses = new List<CharacterHeroClass>();
            CharacterSpellbooks = new List<Spellbook>();
        }

        //    public Character(PathfinderContext context)
        //{
        //    Languages = new List<Language>();
        //    CharacterBloodlines = new List<CharacterBloodline>();
        //    CharacterSkills = new List<CharacterSkill>();
        //    CharacterAbilities = new List<CharacterAbility>();
        //    CharacterHeroClasses = new List<CharacterHeroClass>();
        //    CharacterSpellbooks = new List<Spellbook>();

        //    //Languages.Add(context.Languages.Find(LanguageKeys.Common));
        //}
    }

    //internal struct LanguageKeys
    //{
    //    public static Guid Aboleth = new System.Guid("44e86513-e49d-43ae-b725-1d5c62a3cb2c");
    //    public static Guid Abyssal = new System.Guid("80443263-52a4-4c19-b921-a7e4dc02757d");
    //    public static Guid Aklo = new System.Guid("cc45e467-a2f7-4214-98e8-3bae7efc263b");
    //    public static Guid Aquan = new System.Guid("061bcff5-3193-4152-8330-4dc9b4b76bfa");
    //    public static Guid Auran = new System.Guid("f0210be3-ebf3-4935-81b2-2f0459291fee");
    //    public static Guid Boggard = new System.Guid("121ac9c5-b2e0-479e-95c7-0ee235c9f2e4");
    //    public static Guid Celestial = new System.Guid("63952e18-0b6d-4e9b-b4e5-0557f555c6d7");
    //    public static Guid Common = new System.Guid("d622d55a-21c4-4393-a3c1-3e593ac83351");
    //    public static Guid Cyclops = new System.Guid("1f382d52-6cb8-4a6f-9547-ce20b7d1ff1f");
    //    public static Guid DarkFolk = new System.Guid("9c337829-cc3c-404e-b3da-6b8735321677");
    //    public static Guid Draconic = new System.Guid("8e1e46c0-7023-4714-9e3f-a417a47022a6");
    //    public static Guid DrowSignLanguage = new System.Guid("e3271317-45e6-4f9e-8949-d608db67cb51");
    //    public static Guid Druidic = new System.Guid("121d8d7c-20ca-4b74-ad9e-bb4020d21772");
    //    public static Guid Dwarven = new System.Guid("6d754abd-a1f4-4244-a0ea-4b9b9d3ab9f9");
    //    public static Guid Dziriak = new System.Guid("b98476e1-3fd4-4f3e-b01b-37e9b0bfc80f");
    //    public static Guid Elven = new System.Guid("862c2302-2b6c-40eb-b63b-72ceb2fdb099");
    //    public static Guid Giant = new System.Guid("46035b18-69df-4229-afdd-18795b11b213");
    //    public static Guid Gnoll = new System.Guid("680b3ecf-5600-4b0d-b8dc-2375e2ae781a");
    //    public static Guid Gnome = new System.Guid("40e82672-3cad-476f-b86d-ee4b610bb30d");
    //    public static Guid Goblin = new System.Guid("2a4d0c82-2629-476c-8932-71f743f0f997");
    //    public static Guid Grippli = new System.Guid("8a9c9b6f-f3c9-40de-9dc5-11391eb4ee7a");
    //    public static Guid Halfling = new System.Guid("4f6f6ebc-933b-4963-87b9-c1ea7f8e48eb");
    //    public static Guid Ignan = new System.Guid("bc37860b-8031-47b2-9f77-75fafffdfad8");
    //    public static Guid Infernal = new System.Guid("795d1353-48cc-4ffb-9dbd-2c8f0a981259");
    //    public static Guid Necril = new System.Guid("07c64fd7-61f0-48d0-9c2a-506457a053eb");
    //    public static Guid Orc = new System.Guid("9d87af67-b4f1-481e-aca1-47454d4d4c24");
    //    public static Guid Protean = new System.Guid("8b4b6e6c-427d-42dc-ba16-1686854e94af");
    //    public static Guid Sphinx = new System.Guid("40563e63-c48c-4d45-972d-867505d61185");
    //    public static Guid Sylvan = new System.Guid("45c441d8-e074-44d1-8dc3-4cf9b73cafc5");
    //    public static Guid Tengu = new System.Guid("5280a096-7477-4d12-b340-1bc6807c0809");
    //    public static Guid Terran = new System.Guid("88ca1edc-6cb3-498e-8931-c668d6965a92");
    //    public static Guid Treant = new System.Guid("f3a1f2eb-3a60-4457-9564-c5202c0f7757");
    //    public static Guid Undercommon = new System.Guid("a9a6c3cb-c89c-4c58-9270-1ab321f1b82b");
    //    public static Guid Vegepygmy = new System.Guid("6703b308-621b-4144-a53b-60bd609fa3be");
    //}

    public class Language
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class Spellbook
    {
        public Spellbook()
        {
            Spells = new List<SpellbookSpell>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public List<SpellbookSpell> Spells { get; set; }
    }

    public class SpellbookSpell
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public List<MetaMagic> MetaMagics { get; set; }
        public Spell Spell { get; set; }
        public int Used { get; set; }
    }

    public class MetaMagic
    {
        public Guid Id { get; set; }
        public int LevelModifier { get; set; }
        public string Name { get; set; }
    }

    public class Attack {
        public Guid Id { get; set; }
        public ModifiableStat AttackBonus { get; set; }
        public ModifiableStat Critical { get; set; }
        //public DamageType DamageType { get; set; }
        //public Ammunition Ammunition { get; set; }
        public int D4s { get; set; }
        public int D6s { get; set; }
        public int D8s { get; set; }
        public int D10s { get; set; }
        public int D12s { get; set; }
        public int D20s { get; set; }
        public ModifiableStat BaseDamage { get; set; }
    }
    
    public class ModifiableStat
    {
        public ModifiableStat(PathfinderContext context, Guid ModificationTypeKey, double value)
        {
            ModificationType = context.ModificationTypes.Find(ModificationTypeKey);
            Value = value;
        }

        public Guid Id { get; set; }
        [Required]
        public double Value { get; set; }
        public ModificationType ModificationType { get;set; }
        public StatKey StatKey { get; set; }
    }

    public class ModificationType
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public bool Stackable { get; set; }
    }

    //internal struct ModificationTypes
    //{
    //    public static Guid Inherent = new System.Guid("79d70a6b-0214-499b-a159-dd219917086a");
    //    public static Guid Enhancement = new System.Guid("2e29605e-9aac-4bf6-893f-0ef1cf8ef577");
    //    public static Guid Base = new System.Guid("a1dd9845-b565-4739-bb7e-a87282eb5df0");
    //    public static Guid NaturalArmour = new System.Guid("f37a0e9e-bdab-4c92-b336-7cd1c8a2d82e");
    //    public static Guid Deflect = new System.Guid("2bd83242-805c-40b9-a230-9c8a855e635a");
    //    public static Guid Shield = new System.Guid("a8862a1f-0cc8-464b-8308-b924e3e29d1e");
    //    public static Guid Misc = new System.Guid("5dc3d92b-d57c-4f89-9efd-1068baab9657");
    //    public static Guid Temp = new System.Guid("d35b3b6c-0206-497e-b2da-aeb787d24d1a");
    //    public static Guid Resistance = new System.Guid("afd0bcce-b9a0-42da-a784-8c33b76afe35");
    //    public static Guid Ability = new System.Guid("84c6ab53-3307-46d4-802c-24dab6f08c9e");
    //    public static Guid Luck = new System.Guid("b161e3ef-c5b6-422e-a561-ee66a4af407c");
    //    public static Guid Armor = new System.Guid("8341c2b1-7798-46cd-a3e8-a83f33a1e2f4");
    //    public static Guid Morale = new System.Guid("9834de5d-52cd-4a66-ba42-48344c5ea265");
    //    public static Guid Competence = new System.Guid("d0d551d0-c8fb-4f20-96ff-9c4d6525f903");
    //    public static Guid Sacred = new System.Guid("ca373a4f-64b4-4234-bf9f-2d2a78d0ecc0");
    //    public static Guid Untyped = new System.Guid("a36f4273-9b56-4882-83ef-060e94062155");
    //    public static Guid Circumstancial = new System.Guid("00166482-9d94-49f3-a1c7-50c6e2f6a66b");
    //    public static Guid Aging = new System.Guid("05f13c19-fea2-4eaa-83eb-f08062d8f972");
    //    public static Guid Trait = new System.Guid("86a611ff-e4d3-426a-8141-a8e62659739a");
    //    public static Guid Dodge = new System.Guid("978ae9e0-e44a-4b21-8733-c03c685931ef");
    //    public static Guid Profane = new System.Guid("295b706d-4d87-428d-a165-bb41c84f7a12");
    //    //public static Guid Inherent = new System.Guid("65f987c2-a7a6-453d-a19b-4a5880e87607");
    //    //public static Guid Inherent = new System.Guid("63c23589-a6ee-47fa-b1a4-256a4b05d7ab");
    //    //public static Guid Inherent = new System.Guid("7fbfa9b0-a9d0-424d-8fc9-0e12685bddfc");
    //    //public static Guid Inherent = new System.Guid("aec3d21d-dbce-45f8-9a71-23472f20e5ee");
    //    //public static Guid Inherent = new System.Guid("2d6a3ff4-97b7-41ad-8e0d-dfc82d678661");
    //    //public static Guid Inherent = new System.Guid("ccadcbd9-93be-4059-8861-c78e01fb5c71");
    //    //public static Guid Inherent = new System.Guid("9a54701f-ab31-4e41-a2f2-9bab58038fcd");
    //    //public static Guid Inherent = new System.Guid("67ec9e4f-d112-4da9-9645-92673fb79bd1");
    //    //public static Guid Inherent = new System.Guid("f9d22e12-1a94-4650-9db3-30c919e53c3b");
    //    //public static Guid Inherent = new System.Guid("b7d86688-2d73-416e-9730-7035e688f8f1");
    //    //public static Guid Inherent = new System.Guid("769c5bf2-1ce4-44a4-b446-c78e5ba260e5");
    //    //public static Guid Inherent = new System.Guid("e559ff47-d2cf-42ec-9850-b64be35603e8");
    //    //public static Guid Inherent = new System.Guid("2c221aa3-66b8-401a-8eb1-51366ba59694");
    //}

    public class Modifier
    {
        public Guid Id { get; set; }
        public Guid IdToModify { get; set; }
        public int Value { get; set; }
        public string ModifierType { get; set; }
        public bool Stackable { get; set; }
    }

    public class CharacterSave
    {
        public Guid Id { get; set; }
        public SavingThrow Save { get; set; }
        public ModifiableStat Value { get; set; }
    }

    public class CharacterSkill
    {
        public Guid Id { get; set; }
        public Skill Skill { get; set; }
        public ModifiableStat Value { get; set; }
    }

    public class Skill
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Ability AbilityModifierType { get; set; }
        public bool TrainedOnly { get; set; }
    }

    public class StatKey
    {
        public Guid Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
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
        public ModifiableStat Value { get; set; }
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

    //internal struct StatKeys
    //{
    //    public static Guid Dexterity = new System.Guid("b8625a02-cec2-473f-bec3-3cf75cabdc34");
    //    public static Guid Strength = new System.Guid("498bd756-7d3b-4a57-9769-ef67fa0e5135");
    //    public static Guid Constitution = new System.Guid("08053675-538d-4dc2-8c9e-56d9ed75f4f2");
    //    public static Guid Intelligence = new System.Guid("2120fbcd-aaa8-4544-b6dc-99d24ab26e85");
    //    public static Guid Wisdom = new System.Guid("8aa12ee6-1436-4b58-9807-fc1892882d3a");
    //    public static Guid Charisma = new System.Guid("a9841537-4f5c-4cdf-8473-6a22e82f7f22");
    //    public static Guid HitPoints = new System.Guid("99284b7f-6360-4c72-953f-63969fa7baed");
    //    public static Guid FortitudeSave = new System.Guid("a247ea10-669d-4597-bab6-c523444482d7");
    //    public static Guid WillSave = new System.Guid("e5704683-0774-4ba8-9a43-a511db5a68b0");
    //    public static Guid ReflexSave = new System.Guid("1b51f027-fc74-4d87-ba23-0e2a6c7921bb");
    //    public static Guid Damage = new System.Guid("e82b8093-5d7e-4e66-a90a-37cae91125c4");
    //    public static Guid Armour = new System.Guid("d984787f-bdb7-4186-92ee-e669cd4eb282");
    //    public static Guid Size = new System.Guid("f335fc51-23af-469c-a2a4-bf8b40223659");
    //    public static Guid ArcaneSpellFailure = new System.Guid("d8b99947-e86c-440b-87cf-6e8f5a3c5bee");
    //    public static Guid SkillChecks = new System.Guid("a0d1098a-99e1-455c-8597-d775c7fa6a37");
    //    public static Guid LandSpeed = new System.Guid("e7bdcd11-a112-4c36-b01e-722fc710cbec");
    //    public static Guid FlySpeed = new System.Guid("d544614b-bc5f-416a-bf4d-4f3b6579ec80");
    //    public static Guid SwimSpeed = new System.Guid("6ab6a2e2-7d2e-4909-a45f-87ea9223cfec");
    //    public static Guid BurrowSpeed = new System.Guid("add5f868-d656-43d9-9dfb-e3ea0ad36cf0");
    //    public static Guid ClimbSpeed = new System.Guid("add5f868-d656-43d9-9dfb-e3ea0ad36cf0");
    //    public static Guid FireEnergyResistance = new System.Guid("4fc605b2-e4ba-474a-b34a-ae9205335060");
    //    public static Guid ColdEnergyResistance = new System.Guid("fd78383e-4b2d-4ce4-b647-ff3bc0745c6c");
    //    public static Guid ElectricityEnergyResistance = new System.Guid("d36caa18-3e51-4186-8585-76198bb230ed");
    //    public static Guid AcidEnergyResistance = new System.Guid("42985b6c-0c98-4348-afa5-50d8850c3121");
    //    public static Guid SonicEnergyResistance = new System.Guid("681849c9-587e-428a-ae8c-efed9ec13246");
    //    public static Guid Experience = new System.Guid("655cb2a6-60f2-428d-949c-072b4705d794");
    //    public static Guid DamageReduction = new System.Guid("a32fc1df-42e7-4c59-a84a-540ee919cb0b");
    //    public static Guid SpellResistance = new System.Guid("a809581a-186d-4913-9571-f321bda426bd");
    //    public static Guid CriticalMultiplier = new System.Guid("ffbf32d2-dd41-46be-bef2-99c43a36f0d7");
    //    public static Guid CriticalRange = new System.Guid("7b8e50a8-fba5-4e15-942f-900c38959d31");
    //    public static Guid ArmourCheckPenalty = new System.Guid("bbffb385-18a2-49e4-a1ff-607b3526d006");
    //    public static Guid Initiative = new System.Guid("74fdb66b-49f4-4a89-bc3d-584355a04719");
    //    public static Guid Acrobatics = new System.Guid("5793fc7f-f183-40a5-bce5-14790d118f4c");
    //    public static Guid Appraise = new System.Guid("23b2124f-14c2-4758-9fc1-ee07e3bd743b");
    //    public static Guid Bluff = new System.Guid("7931a769-1d0c-4690-9829-823c0c5412ee");
    //    public static Guid Climb = new System.Guid("0c844083-2c3d-45ce-b5e6-2693c7f6a106");
    //    public static Guid Craft = new System.Guid("e427c36f-33c1-4d43-8582-3423345b58fa");
    //    public static Guid Diplomacy = new System.Guid("14971b2b-79d3-4ffa-b01e-3222ba21e111");
    //    public static Guid DisableDevice = new System.Guid("cd51ee27-e123-42eb-bd76-1c25e63072da");
    //    public static Guid Disguise = new System.Guid("25e485cb-6743-4535-8c12-749a11e1df89");
    //    public static Guid EscapeArtist = new System.Guid("1aeda87e-6e3d-4e3a-aa87-6829d3a0ecf7");
    //    public static Guid Fly = new System.Guid("0ebb0bc9-f64f-4d9a-aac2-189ddfd77fd5");
    //    public static Guid HandleAnimal = new System.Guid("199e7665-9eae-4bcc-abe1-3d7110577155");
    //    public static Guid Heal = new System.Guid("137f4b34-18a3-45a7-b6aa-eaa4bdd99633");
    //    public static Guid Intimidate = new System.Guid("c1385ea6-a749-41c5-a584-d04b2ba0e5f2");
    //    public static Guid KnowledgeArcana = new System.Guid("2dce9637-2333-423d-9b25-4c886377eb92");
    //    public static Guid KnowledgeDungeoneering = new System.Guid("b05cb812-fce3-4bca-98bd-0ad359e34683");
    //    public static Guid KnowledgeEngineering = new System.Guid("7149a1ed-053c-4bea-a8b8-962c6d832608");
    //    public static Guid KnowledgeGeography = new System.Guid("8426f0fe-8c60-4858-9bb8-3d70733b45e8");
    //    public static Guid KnowledgeHistory = new System.Guid("fcc3a97a-8793-4638-9e7c-775e57822469");
    //    public static Guid KnowledgeLocal = new System.Guid("5cb5aad7-d239-49e6-821e-015646b4b756");
    //    public static Guid KnowledgeNature = new System.Guid("f1e851f8-b09f-4c83-825a-7fda79d0aa9e");
    //    public static Guid KnowledgeNobility = new System.Guid("fb939b36-72a2-48f5-a472-812c8668a82b");
    //    public static Guid KnowledgePlanes = new System.Guid("d305c8cb-e045-4f7f-a195-0c2e93d1371f");
    //    public static Guid KnowledgeReligion = new System.Guid("0affba73-183f-43a1-9720-69d0d777734c");
    //    public static Guid Linguistics = new System.Guid("96ed714d-5295-431a-8559-8a7386404164");
    //    public static Guid NonLethalDamage = new System.Guid("07747292-e6c6-4285-9650-f9a8cdb43c99");
    //    public static Guid Perception = new System.Guid("6fd46a90-c4c8-4c42-8c48-8fafd030b64f");
    //    public static Guid Perform = new System.Guid("bfd2cf45-9baf-40ad-89b0-472da7252acc");
    //    public static Guid Profession = new System.Guid("11fef3ca-2a6b-4b88-89fd-0ed6ef1b182b");
    //    public static Guid Ride = new System.Guid("dfd4107b-4208-481c-afd9-02e2ed62726c");
    //    public static Guid SenseMotive = new System.Guid("6e587639-4a99-4af2-9a75-8fa9f600147f");
    //    public static Guid SleightOfHand = new System.Guid("81ba82ec-e76f-43de-b59d-568e236d7677");
    //    public static Guid Spellcraft = new System.Guid("2ae53d16-8f88-4882-b498-59660ee2c7e7");
    //    public static Guid Stealth = new System.Guid("e49c0433-6c70-47e8-a42a-d86a5621aa00");
    //    public static Guid Survival = new System.Guid("f8be30ea-795b-4277-8e6b-d204491eb14a");
    //    public static Guid Swim = new System.Guid("6d88cc35-9922-44f6-9d1f-54720d01474c");
    //    public static Guid UseMagicDevice = new System.Guid("eb06ccd3-7d24-4c5b-9f09-dae98481b9ff");
    //}
}
