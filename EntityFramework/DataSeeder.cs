using Microsoft.AspNetCore.Builder;
using PathfinderCharacter.Models;
using System.Collections.Generic;

namespace PathfinderCharacter.EntityFramework
{
    public static class DataSeeder
    {
        public static void Seed(this PathfinderContext context)
        {
            // Perform database delete and create
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            // Perform seed operations
            AddBloodlines(context);
            AddBonusTypes(context);
            AddCastingTimes(context);
            AddComponentTypes(context);
            AddCurrencyUnits(context);
            AddDomains(context);
            AddHeroClasses(context);
            AddPatrons(context);
            AddReferenceSources(context);
            AddSavingThrows(context);
            AddSchools(context);
            //AddShapes(context);
            AddStatKeys(context);
            AddSpellDescriptors(context);
            AddSubschools(context);
            AddTimeUnits(context);

            AddDefaultUser(context);
            

            // Save changes and release resources
            context.SaveChanges();
            context.Dispose();
        }

        private static void AddBloodlines(PathfinderContext context)
        {
            context.AddRange(
                new HeroClass { Name = "Aberrant" },
                new HeroClass { Name = "Abyssal" },
                new HeroClass { Name = "Accursed" },
                new HeroClass { Name = "Aquatic" },
                new HeroClass { Name = "Arcane" },
                new HeroClass { Name = "Black Blood" },
                new HeroClass { Name = "Boreal" },
                new HeroClass { Name = "Celestial" },
                new HeroClass { Name = "Daemon" },
                new HeroClass { Name = "Deep Earth" },
                new HeroClass { Name = "Destined" },
                new HeroClass { Name = "Div" },
                new HeroClass { Name = "Djinni" },
                new HeroClass { Name = "Draconic" },
                new HeroClass { Name = "Dreamspun" },
                new HeroClass { Name = "Efreeti" },
                new HeroClass { Name = "Elemental" },
                new HeroClass { Name = "Fey" },
                new HeroClass { Name = "Ghoul" },
                new HeroClass { Name = "Harrow" },
                new HeroClass { Name = "Imperious" },
                new HeroClass { Name = "Impossible" },
                new HeroClass { Name = "Infernal" },
                new HeroClass { Name = "Kobold" },
                new HeroClass { Name = "Kobold Sorcerer" },
                new HeroClass { Name = "Kyton" },
                new HeroClass { Name = "Maestro" },
                new HeroClass { Name = "Marid" },
                new HeroClass { Name = "Martyred" },
                new HeroClass { Name = "Naga" },
                new HeroClass { Name = "Nanite" },
                new HeroClass { Name = "Oni" },
                new HeroClass { Name = "Orc" },
                new HeroClass { Name = "Pestilence" },
                new HeroClass { Name = "Possessed" },
                new HeroClass { Name = "Protean" },
                new HeroClass { Name = "Rakshasa" },
                new HeroClass { Name = "Serpentine" },
                new HeroClass { Name = "Shadow" },
                new HeroClass { Name = "Shaitan" },
                new HeroClass { Name = "Starsoul" },
                new HeroClass { Name = "Stormborn" },
                new HeroClass { Name = "Undead" },
                new HeroClass { Name = "Verdant" }
            );
        }

        //private static void AddBonusTypes(PathfinderContext context)
        //{
        //    context.AddRange(
        //        new BonusType
        //    );
        //}

        private static void AddCastingTimes(PathfinderContext context)
        {
            context.AddRange(
                new CastingTime { Name = "1 day" },
                new CastingTime { Name = "1 full round" },
                new CastingTime { Name = "1 full-round action" },
                new CastingTime { Name = "1 full-round action, special see below" },
                new CastingTime { Name = "1 hour" },
                new CastingTime { Name = "1 immediate action" },
                new CastingTime { Name = "1 minute" },
                new CastingTime { Name = "1 minute per page" },
                new CastingTime { Name = "1 minute/HD of target" },
                new CastingTime { Name = "1 minute/lb. created" },
                new CastingTime { Name = "1 round" },
                new CastingTime { Name = "1 round; see text" },
                new CastingTime { Name = "1 standard" },
                new CastingTime { Name = "1 standard action" },
                new CastingTime { Name = "1 standard action or immediate action; see text" },
                new CastingTime { Name = "1 standard action or see text" },
                new CastingTime { Name = "1 swift action" },
                new CastingTime { Name = "1 week" },
                new CastingTime { Name = "10 minute/HD of target" },
                new CastingTime { Name = "10 minutes" },
                new CastingTime { Name = "10 minutes (see text)" },
                new CastingTime { Name = "10 minutes or more; see text" },
                new CastingTime { Name = "10 minutes, plus length of memory to be altered" },
                new CastingTime { Name = "10 minutes; see text" },
                new CastingTime { Name = "12 hours" },
                new CastingTime { Name = "2 hours" },
                new CastingTime { Name = "2 minutes" },
                new CastingTime { Name = "2 rounds" },
                new CastingTime { Name = "24 hours" },
                new CastingTime { Name = "3 full rounds" },
                new CastingTime { Name = "3 rounds" },
                new CastingTime { Name = "30 minutes" },
                new CastingTime { Name = "4 hours" },
                new CastingTime { Name = "6 hours" },
                new CastingTime { Name = "6 rounds" },
                new CastingTime { Name = "8 hours" },
                new CastingTime { Name = "at least 10 minutes; see text" },
                new CastingTime { Name = "Casting time 1 minute" },
                new CastingTime { Name = "full-round action" },
                new CastingTime { Name = "see text" },
                new CastingTime { Name = "standard action" },
                new CastingTime { Name = "1 day" },
                new CastingTime { Name = "1 round" },
                new CastingTime { Name = "1 day" }
            );
        }

        private static void AddComponentTypes(PathfinderContext context)
        {
            context.AddRange(
                new ComponentType { Name = "Verbal", Symbol = "V" },
                new ComponentType { Name = "Somatic", Symbol = "S" },
                new ComponentType { Name = "Material", Symbol = "M" },
                new ComponentType { Name = "Focus", Symbol = "F" },
                new ComponentType { Name = "Focus or Divine Focus", Symbol = "F/DF" },
                new ComponentType { Name = "Divine Focus", Symbol = "DF" },
                new ComponentType { Name = "Material or Divine Focus", Symbol = "M/DF" }
            );
        }

        private static void AddCurrencyUnits(PathfinderContext context)
        {
            context.AddRange(
                new CurrencyUnit { Name = "Copper Pieces", NameShort = "cp", ValueFactor = 1 },
                new CurrencyUnit { Name = "Silver Pieces", NameShort = "sp", ValueFactor = 10 },
                new CurrencyUnit { Name = "Gold Pieces", NameShort = "gp", ValueFactor = 100 },
                new CurrencyUnit { Name = "Platinum Pieces", NameShort = "pp", ValueFactor = 1000 }
            );
        }

        private static void AddDefaultUser (PathfinderContext context)
        {
            User newUser = new User { FirstName = "Larry", LastName = "Stuart", AuthenticationId = "12345-getProperAuth" };

            Character DefaultWizard = new Character(context);
            DefaultWizard.CharacterSpellbooks.Add(new Spellbook() {
                IsActive = true,
                Name = "Default Spellbook"               
            });

            newUser.UserCharacters.Add(DefaultWizard);

            context.Users.Add(newUser);
        }

        private static void AddDomains(PathfinderContext context)
        {
            context.AddRange(
                new Domain { Name = "Aeon" },
                new Domain { Name = "Agathion" },
                new Domain { Name = "Air" },
                new Domain { Name = "Ambush" },
                new Domain { Name = "Ancestors" },
                new Domain { Name = "Animal" },
                new Domain { Name = "Arcane" },
                new Domain { Name = "Archon" },
                new Domain { Name = "Aristocracy" },
                new Domain { Name = "Artifice" },
                new Domain { Name = "Ash" },
                new Domain { Name = "Azata" },
                new Domain { Name = "Blood" },
                new Domain { Name = "Cannibalism" },
                new Domain { Name = "Caves" },
                new Domain { Name = "Chaos" },
                new Domain { Name = "Charm" },
                new Domain { Name = "Cloud" },
                new Domain { Name = "Community" },
                new Domain { Name = "Competition" },
                new Domain { Name = "Construct" },
                new Domain { Name = "Cooperation" },
                new Domain { Name = "Corruption" },
                new Domain { Name = "Daemon" },
                new Domain { Name = "Darkness" },
                new Domain { Name = "Dark Tapestry" },
                new Domain { Name = "Death" },
                new Domain { Name = "Decay" },
                new Domain { Name = "Deception" },
                new Domain { Name = "Defense" },
                new Domain { Name = "Demodand" },
                new Domain { Name = "Demon" },
                new Domain { Name = "Destruction" },
                new Domain { Name = "Devil" },
                new Domain { Name = "Divination" },
                new Domain { Name = "Divine" },
                new Domain { Name = "Dragon" },
                new Domain { Name = "Duels" },
                new Domain { Name = "Earth" },
                new Domain { Name = "Education" },
                new Domain { Name = "Espionage" },
                new Domain { Name = "Evil" },
                new Domain { Name = "Exploration" },
                new Domain { Name = "Fate" },
                new Domain { Name = "Fear" },
                new Domain { Name = "Feather" },
                new Domain { Name = "Ferocity" },
                new Domain { Name = "Fire" },
                new Domain { Name = "Fist" },
                new Domain { Name = "Flotsam" },
                new Domain { Name = "Flowing" },
                new Domain { Name = "Fortifications" },
                new Domain { Name = "Freedom" },
                new Domain { Name = "Friendship" },
                new Domain { Name = "Fur" },
                new Domain { Name = "Glory" },
                new Domain { Name = "Good" },
                new Domain { Name = "Greed" },
                new Domain { Name = "Growth" },
                new Domain { Name = "Hatred" },
                new Domain { Name = "Healing" },
                new Domain { Name = "Honor" },
                new Domain { Name = "Ice" },
                new Domain { Name = "Imagination" },
                new Domain { Name = "Industry" },
                new Domain { Name = "Inevitable" },
                new Domain { Name = "Innuendo" },
                new Domain { Name = "Insanity" },
                new Domain { Name = "Isolation" },
                new Domain { Name = "Judgment" },
                new Domain { Name = "Knowledge" },
                new Domain { Name = "Kyton" },
                new Domain { Name = "Language" },
                new Domain { Name = "Law" },
                new Domain { Name = "Leadership" },
                new Domain { Name = "Liberation" },
                new Domain { Name = "Love" },
                new Domain { Name = "Loyalty" },
                new Domain { Name = "Luck" },
                new Domain { Name = "Lust" },
                new Domain { Name = "Madness" },
                new Domain { Name = "Magic" },
                new Domain { Name = "Martyr" },
                new Domain { Name = "Memory" },
                new Domain { Name = "Metal" },
                new Domain { Name = "Moon" },
                new Domain { Name = "Murder" },
                new Domain { Name = "Night" },
                new Domain { Name = "Nigthmare" },
                new Domain { Name = "Nobility" },
                new Domain { Name = "Oceans" },
                new Domain { Name = "Plant" },
                new Domain { Name = "Protean" },
                new Domain { Name = "Protection" },
                new Domain { Name = "Psychopomp" },
                new Domain { Name = "Purity" },
                new Domain { Name = "Radiation" },
                new Domain { Name = "Rage" },
                new Domain { Name = "Redemption" },
                new Domain { Name = "Repose" },
                new Domain { Name = "Restoration" },
                new Domain { Name = "Resurrection" },
                new Domain { Name = "Revelation" },
                new Domain { Name = "Revolution" },
                new Domain { Name = "Revelry" },
                new Domain { Name = "Riot" },
                new Domain { Name = "Rivers" },
                new Domain { Name = "Ruins" },
                new Domain { Name = "Rune" },
                new Domain { Name = "Saurian" },
                new Domain { Name = "Scalykind" },
                new Domain { Name = "Seasons" },
                new Domain { Name = "Smoke" },
                new Domain { Name = "Solitude" },
                new Domain { Name = "Souls" },
                new Domain { Name = "Stars" },
                new Domain { Name = "Storms" },
                new Domain { Name = "Strength" },
                new Domain { Name = "Sun" },
                new Domain { Name = "Tactics" },
                new Domain { Name = "Thievery" },
                new Domain { Name = "Thought" },
                new Domain { Name = "Toil" },
                new Domain { Name = "Torture" },
                new Domain { Name = "Trade" },
                new Domain { Name = "Trap" },
                new Domain { Name = "Travel" },
                new Domain { Name = "Trickery" },
                new Domain { Name = "Tyranny" },
                new Domain { Name = "Void" },
                new Domain { Name = "Vermin" },
                new Domain { Name = "War" },
                new Domain { Name = "Water" },
                new Domain { Name = "Weather" },
                new Domain { Name = "Wind" }

            );
        }

        private static void AddHeroClasses(PathfinderContext context)
        {
            context.AddRange(
                new HeroClass { Name = "Adept" },
                new HeroClass { Name = "Alchemist" },
                new HeroClass { Name = "Antipaladin" },
                new HeroClass { Name = "Bard" },
                new HeroClass { Name = "Bloodrager" },
                new HeroClass { Name = "Cleric" },
                new HeroClass { Name = "Druid" },
                new HeroClass { Name = "Hunter" },
                new HeroClass { Name = "Inquisitor" },
                new HeroClass { Name = "Investigator" },
                new HeroClass { Name = "Magus" },
                new HeroClass { Name = "Medium" },
                new HeroClass { Name = "Mesmerist" },
                new HeroClass { Name = "Occultist" },
                new HeroClass { Name = "Oracle" },
                new HeroClass { Name = "Paladin" },
                new HeroClass { Name = "Psychic" },
                new HeroClass { Name = "Ranger" },
                new HeroClass { Name = "Shaman" },
                new HeroClass { Name = "Skald" },
                new HeroClass { Name = "Sorcerer" },
                new HeroClass { Name = "Spiritualist" },
                new HeroClass { Name = "Summoner" },
                new HeroClass { Name = "Witch" },
                new HeroClass { Name = "Wizard" }
                );
        }

        private static void Languages(PathfinderContext context)
        {
            context.Languages.AddRange(
                new Language() { Id = LanguageKeys.Aboleth, Name = "Aboleth" },
                new Language() { Id = LanguageKeys.Abyssal, Name = "Abyssal" },
                new Language() { Id = LanguageKeys.Aklo, Name = "Aklo" },
                new Language() { Id = LanguageKeys.Aquan, Name = "Aquan" },
                new Language() { Id = LanguageKeys.Auran, Name = "Auran" },
                new Language() { Id = LanguageKeys.Boggard, Name = "Boggard" },
                new Language() { Id = LanguageKeys.Celestial, Name = "Celestial" },
                new Language() { Id = LanguageKeys.Common, Name = "Common" },
                new Language() { Id = LanguageKeys.Cyclops, Name = "Cyclops" },
                new Language() { Id = LanguageKeys.DarkFolk, Name = "Dark Folk" },
                new Language() { Id = LanguageKeys.Draconic, Name = "Draconic" },
                new Language() { Id = LanguageKeys.DrowSignLanguage, Name = "Drow Sign Language" },
                new Language() { Id = LanguageKeys.Druidic, Name = "Druidic" },
                new Language() { Id = LanguageKeys.Dwarven, Name = "Dwarven" },
                new Language() { Id = LanguageKeys.Dziriak, Name = "Dziriak" },
                new Language() { Id = LanguageKeys.Elven, Name = "Elven" },
                new Language() { Id = LanguageKeys.Giant, Name = "Giant" },
                new Language() { Id = LanguageKeys.Gnoll, Name = "Gnoll" },
                new Language() { Id = LanguageKeys.Gnome, Name = "Gnome" },
                new Language() { Id = LanguageKeys.Goblin, Name = "Goblin" },
                new Language() { Id = LanguageKeys.Grippli, Name = "Grippli" },
                new Language() { Id = LanguageKeys.Halfling, Name = "Halfling" },
                new Language() { Id = LanguageKeys.Ignan, Name = "Ignan" },
                new Language() { Id = LanguageKeys.Infernal, Name = "Infernal" },
                new Language() { Id = LanguageKeys.Necril, Name = "Necril" },
                new Language() { Id = LanguageKeys.Orc, Name = "Orc" },
                new Language() { Id = LanguageKeys.Protean, Name = "Protean" },
                new Language() { Id = LanguageKeys.Sphinx, Name = "Sphinx" },
                new Language() { Id = LanguageKeys.Sylvan, Name = "Sylvan" },
                new Language() { Id = LanguageKeys.Tengu, Name = "Tengu" },
                new Language() { Id = LanguageKeys.Terran, Name = "Terran" },
                new Language() { Id = LanguageKeys.Treant, Name = "Treant" },
                new Language() { Id = LanguageKeys.Undercommon, Name = "Undercommon" },
                new Language() { Id = LanguageKeys.Vegepygmy, Name = "Vegepygmy" }
            );
        }

        private static void AddModificationTypes (PathfinderContext context)
        {
            context.AddRange(
                new ModificationType { Id = ModificationTypes.Ability, Stackable = false },
                new ModificationType { Id = ModificationTypes.Aging, Stackable = false  },
                new ModificationType { Id = ModificationTypes.Armor, Stackable = false  },
                new ModificationType { Id = ModificationTypes.Base, Stackable = true  },
                new ModificationType { Id = ModificationTypes.Circumstancial, Stackable = false  },
                new ModificationType { Id = ModificationTypes.Competence, Stackable = false  },
                new ModificationType { Id = ModificationTypes.Deflect, Stackable = false  },
                new ModificationType { Id = ModificationTypes.Dodge, Stackable = true  },
                new ModificationType { Id = ModificationTypes.Enhancement, Stackable = false  },
                new ModificationType { Id = ModificationTypes.Inherent, Stackable = true  },
                new ModificationType { Id = ModificationTypes.Luck, Stackable = false  },
                new ModificationType { Id = ModificationTypes.Misc, Stackable = false  },
                new ModificationType { Id = ModificationTypes.Morale, Stackable = false  },
                new ModificationType { Id = ModificationTypes.NaturalArmour, Stackable = false  },
                new ModificationType { Id = ModificationTypes.Profane, Stackable = false },
                new ModificationType { Id = ModificationTypes.Resistance, Stackable = false  },
                new ModificationType { Id = ModificationTypes.Sacred, Stackable = false  },
                new ModificationType { Id = ModificationTypes.Shield, Stackable = false  },
                new ModificationType { Id = ModificationTypes.Temp, Stackable = false },
                new ModificationType { Id = ModificationTypes.Trait, Stackable = false  },
                new ModificationType { Id = ModificationTypes.Untyped, Stackable = true  }
            );
        }

        private static void AddPatrons(PathfinderContext context)
        {

            context.AddRange(
                new Patron { Name = "Agility" },
                new Patron { Name = "Ancestors" },
                new Patron { Name = "Animals" },
                new Patron { Name = "Boundaries" },
                new Patron { Name = "Death" },
                new Patron { Name = "Deception" },
                new Patron { Name = "Devotion" },
                new Patron { Name = "Dimensions" },
                new Patron { Name = "Elements" },
                new Patron { Name = "Enchantment" },
                new Patron { Name = "Endurance" },
                new Patron { Name = "Ethereal" },
                new Patron { Name = "Healing" },
                new Patron { Name = "Insanity" },
                new Patron { Name = "Light" },
                new Patron { Name = "Mind" },
                new Patron { Name = "Moon" },
                new Patron { Name = "Mountain" },
                new Patron { Name = "Occult" },
                new Patron { Name = "Peace" },
                new Patron { Name = "Plague" },
                new Patron { Name = "Plant" },
                new Patron { Name = "Portents" },
                new Patron { Name = "Shadow" },
                new Patron { Name = "Spirits" },
                new Patron { Name = "Stars" },
                new Patron { Name = "Storms" },
                new Patron { Name = "Strength" },
                new Patron { Name = "Summer" },
                new Patron { Name = "Thorns" },
                new Patron { Name = "Time" },
                new Patron { Name = "Transformation" },
                new Patron { Name = "Trickery" },
                new Patron { Name = "Vengeance" },
                new Patron { Name = "Water" },
                new Patron { Name = "Winter" },
                new Patron { Name = "Wisdom" }
            );
        }

        private static void AddReferenceSources(PathfinderContext context)
        {
            context.AddRange(
                new ReferenceSource { Name = "Advanced Class Guide" },
                new ReferenceSource { Name = "Advanced Class Origins" },
                new ReferenceSource { Name = "Advanced Race Guide" },
                new ReferenceSource { Name = "Agents Of Evil" },
                new ReferenceSource { Name = "Andoran" },
                new ReferenceSource { Name = "Animal Archive" },
                new ReferenceSource { Name = "AP 102" },
                new ReferenceSource { Name = "AP 107" },
                new ReferenceSource { Name = "AP 110" },
                new ReferenceSource { Name = "AP 113" },
                new ReferenceSource { Name = "AP 115" },
                new ReferenceSource { Name = "AP 116" },
                new ReferenceSource { Name = "AP 29" },
                new ReferenceSource { Name = "AP 30" },
                new ReferenceSource { Name = "AP 35" },
                new ReferenceSource { Name = "AP 42" },
                new ReferenceSource { Name = "AP 50" },
                new ReferenceSource { Name = "AP 55" },
                new ReferenceSource { Name = "AP 56" },
                new ReferenceSource { Name = "AP 62" },
                new ReferenceSource { Name = "AP 64" },
                new ReferenceSource { Name = "AP 65" },
                new ReferenceSource { Name = "AP 67" },
                new ReferenceSource { Name = "AP 68" },
                new ReferenceSource { Name = "AP 69" },
                new ReferenceSource { Name = "AP 71" },
                new ReferenceSource { Name = "AP 74" },
                new ReferenceSource { Name = "AP 77" },
                new ReferenceSource { Name = "AP 78" },
                new ReferenceSource { Name = "AP 80" },
                new ReferenceSource { Name = "AP 81" },
                new ReferenceSource { Name = "AP 82" },
                new ReferenceSource { Name = "AP 84" },
                new ReferenceSource { Name = "AP 86" },
                new ReferenceSource { Name = "AP 89" },
                new ReferenceSource { Name = "AP 91" },
                new ReferenceSource { Name = "AP 93" },
                new ReferenceSource { Name = "AP 95" },
                new ReferenceSource { Name = "AP 99" },
                new ReferenceSource { Name = "APG" },
                new ReferenceSource { Name = "Arcane Anthology" },
                new ReferenceSource { Name = "Armor Masters Handbook" },
                new ReferenceSource { Name = "Black Markets" },
                new ReferenceSource { Name = "Blood Of Shadows" },
                new ReferenceSource { Name = "Blood Of The Beast" },
                new ReferenceSource { Name = "Blood Of The Elements" },
                new ReferenceSource { Name = "Blood Of The Moon" },
                new ReferenceSource { Name = "Blood Of The Night" },
                new ReferenceSource { Name = "Book of the Damned V1" },
                new ReferenceSource { Name = "Book of the Damned V2" },
                new ReferenceSource { Name = "Champions Of Balance" },
                new ReferenceSource { Name = "Champions Of Corruption" },
                new ReferenceSource { Name = "Champions Of Purity" },
                new ReferenceSource { Name = "Cheliax Empire Of Devils" },
                new ReferenceSource { Name = "Chronicle Of The Righteous" },
                new ReferenceSource { Name = "Classic Treasures" },
                new ReferenceSource { Name = "Cohorts & Companions" },
                new ReferenceSource { Name = "Condition Cards" },
                new ReferenceSource { Name = "Curse Of The Crimson Throne Chapter Appendix" },
                new ReferenceSource { Name = "Demon Hunter's Handbook" },
                new ReferenceSource { Name = "Demons Revisited" },
                new ReferenceSource { Name = "Dirty Tactics Toolbox" },
                new ReferenceSource { Name = "Divine Anthology" },
                new ReferenceSource { Name = "Dragon Empires Primer" },
                new ReferenceSource { Name = "Dragonslayer's Handbook" },
                new ReferenceSource { Name = "Dungeoneers Handbook" },
                new ReferenceSource { Name = "Dungeons Of Golarion" },
                new ReferenceSource { Name = "Dwarves of Golarion" },
                new ReferenceSource { Name = "Faction Guide" },
                new ReferenceSource { Name = "Faiths & Philosophies" },
                new ReferenceSource { Name = "Faiths Of Corruption" },
                new ReferenceSource { Name = "Faiths Of Purity" },
                new ReferenceSource { Name = "Familiar Folio" },
                new ReferenceSource { Name = "Giant Hunters Handbook" },
                new ReferenceSource { Name = "Gnomes Of Golarion" },
                new ReferenceSource { Name = "Goblins Of Golarion" },
                new ReferenceSource { Name = "Haunted Heroes Handbook" },
                new ReferenceSource { Name = "Healer's Handbook" },
                new ReferenceSource { Name = "Heroes Of The High Court" },
                new ReferenceSource { Name = "Heroes Of The Streets" },
                new ReferenceSource { Name = "Heroes Of The Wild" },
                new ReferenceSource { Name = "Horror Adventures" },
                new ReferenceSource { Name = "Horsemen Of The Apocalypse" },
                new ReferenceSource { Name = "Humans Of Golarion" },
                new ReferenceSource { Name = "Inner Sea Gods" },
                new ReferenceSource { Name = "Inner Sea Intrigue" },
                new ReferenceSource { Name = "Inner Sea Magic" },
                new ReferenceSource { Name = "Inner Sea Monster Codex" },
                new ReferenceSource { Name = "Inner Sea Races" },
                new ReferenceSource { Name = "Inner Sea Temples" },
                new ReferenceSource { Name = "Inner Sea World Guide" },
                new ReferenceSource { Name = "Knights Of The Inner Sea" },
                new ReferenceSource { Name = "Kobolds Of Golarion" },
                new ReferenceSource { Name = "Legacy Of Dragons" },
                new ReferenceSource { Name = "Lost Kingdoms" },
                new ReferenceSource { Name = "Magic Tactics Toolbox" },
                new ReferenceSource { Name = "Magical Marketplace" },
                new ReferenceSource { Name = "Melee Tactics Toolbox" },
                new ReferenceSource { Name = "Monster Codex" },
                new ReferenceSource { Name = "Monster Hunter's Handbook" },
                new ReferenceSource { Name = "Monster Summoner's Handbook" },
                new ReferenceSource { Name = "Mythic Adventures" },
                new ReferenceSource { Name = "Mythic Origins" },
                new ReferenceSource { Name = "Occult Adventures" },
                new ReferenceSource { Name = "Occult Mysteries" },
                new ReferenceSource { Name = "Occult Origins" },
                new ReferenceSource { Name = "Occult Realms" },
                new ReferenceSource { Name = "Orcs of Golarion" },
                new ReferenceSource { Name = "Osirion, Legacy Of Pharaohs" },
                new ReferenceSource { Name = "Paizo Blog" },
                new ReferenceSource { Name = "Path Of The Hellknight" },
                new ReferenceSource { Name = "Pathfinder Society Field Guide" },
                new ReferenceSource { Name = "Pathfinder Society Primer" },
                new ReferenceSource { Name = "Paths Of The Righteous" },
                new ReferenceSource { Name = "People Of The North" },
                new ReferenceSource { Name = "People Of The River" },
                new ReferenceSource { Name = "People Of The Sands" },
                new ReferenceSource { Name = "People Of The Stars" },
                new ReferenceSource { Name = "PFRPG Core" },
                new ReferenceSource { Name = "PFS S3 - 09" },
                new ReferenceSource { Name = "Pirates Of The Inner Sea" },
                new ReferenceSource { Name = "Planes Of Power" },
                new ReferenceSource { Name = "Psychic Anthology" },
                new ReferenceSource { Name = "Qadira Jewel Of The East" },
                new ReferenceSource { Name = "Quests and Campaigns" },
                new ReferenceSource { Name = "Ranged Tactics Toolbox" },
                new ReferenceSource { Name = "Rival Guide" },
                new ReferenceSource { Name = "RotRL - AE - Appendix" },
                new ReferenceSource { Name = "Sargava" },
                new ReferenceSource { Name = "Seekers of Secrets" },
                new ReferenceSource { Name = "Spymaster's Handbook" },
                new ReferenceSource { Name = "Technology Guide" },
                new ReferenceSource { Name = "The Dragon's Demand" },
                new ReferenceSource { Name = "The First World Realm Of The Fey" },
                new ReferenceSource { Name = "The HarrowHandbook" },
                new ReferenceSource { Name = "Ultimate Combat" },
                new ReferenceSource { Name = "Ultimate Intrigue" },
                new ReferenceSource { Name = "Ultimate Magic" },
                new ReferenceSource { Name = "Undead Slayer's Handbook" },
                new ReferenceSource { Name = "Villain Codex" }
            );
        }

        private static void AddSavingThrows(PathfinderContext context)
        {
            context.AddRange(
                new SavingThrow { Name = "Reflex" },
                new SavingThrow { Name = "Fortitude" },
                new SavingThrow { Name = "Will" },
                new SavingThrow { Name = "None"}
            );
        }

        private static void AddSchools(PathfinderContext context)
        {
            context.AddRange(
                new School { Name = "Abjuration" },
                new School { Name = "Conjuration" },
                new School { Name = "Divination" },
                new School { Name = "Enchantment" },
                new School { Name = "Evocation" },
                new School { Name = "Illusion" },
                new School { Name = "Necromancy" },
                new School { Name = "Transmutation" },
                new School { Name = "Universal" }
                
            );
        }

        //private static void AddShapes(PathfinderContext context)
        //{
        //    context.AddRange(
        //        new School { Name = "Sphere" },
        //        new School { Name = "Cube" },
        //        new School { Name = "Cuboid" },
        //        new School { Name = "Cone" },
        //        new School { Name = "Circle" },
        //        new School { Name = "Cylinder" }
        //    );
        //}
        
        private static void AddStatKeys(PathfinderContext context)
        {
            context.AddRange(
                new StatKey { Id = StatKeys.Dexterity, Name = "Dexterity" },
                new StatKey { Id = StatKeys.Strength, Name = "Strength" },
                new StatKey { Id = StatKeys.Constitution, Name = "Constitution" },
                new StatKey { Id = StatKeys.Intelligence, Name = "Intelligence" },
                new StatKey { Id = StatKeys.Wisdom, Name = "Wisdom" },
                new StatKey { Id = StatKeys.Charisma, Name = "Charisma" },
                new StatKey { Id = StatKeys.HitPoints, Name = "Hit Points" },
                new StatKey { Id = StatKeys.FortitudeSave, Name = "Fortitude Save" },
                new StatKey { Id = StatKeys.WillSave, Name = "Will Save" },
                new StatKey { Id = StatKeys.ReflexSave, Name = "Reflex Save" },
                new StatKey { Id = StatKeys.Damage, Name = "Damage" },
                new StatKey { Id = StatKeys.Armour, Name = "Armour" },
                new StatKey { Id = StatKeys.Size, Name = "Size" },
                new StatKey { Id = StatKeys.ArcaneSpellFailure, Name = "Arcane Spell Failure" },
                new StatKey { Id = StatKeys.SkillChecks, Name = "Skill Checks" },
                new StatKey { Id = StatKeys.LandSpeed, Name = "Land Speed" },
                new StatKey { Id = StatKeys.FlySpeed, Name = "Fly Speed" },
                new StatKey { Id = StatKeys.SwimSpeed, Name = "Swim Speed" },
                new StatKey { Id = StatKeys.BurrowSpeed, Name = "Burrow Speed" },
                new StatKey { Id = StatKeys.ClimbSpeed, Name = "Climb Speed" },
                new StatKey { Id = StatKeys.FireEnergyResistance, Name = "Fire Energy Resistance" },
                new StatKey { Id = StatKeys.ColdEnergyResistance, Name = "Cold Energy Resistance" },
                new StatKey { Id = StatKeys.ElectricityEnergyResistance, Name = "Electricity Energy Resistance" },
                new StatKey { Id = StatKeys.AcidEnergyResistance, Name = "Acid Energy Resistance" },
                new StatKey { Id = StatKeys.SonicEnergyResistance, Name = "Sonic Energy Resistance" },
                new StatKey { Id = StatKeys.Experience, Name = "Experience" },
                new StatKey { Id = StatKeys.DamageReduction, Name = "Damage Reduction" },
                new StatKey { Id = StatKeys.SpellResistance, Name = "Spell Resistance" },
                new StatKey { Id = StatKeys.CriticalMultiplier, Name = "Critical Multiplier" },
                new StatKey { Id = StatKeys.CriticalRange, Name = "Critical Range" },
                new StatKey { Id = StatKeys.ArmourCheckPenalty, Name = "Armour Check Penalty" },
                new StatKey { Id = StatKeys.Initiative, Name = "Initiative" },
                new StatKey { Id = StatKeys.Acrobatics, Name = "Acrobatics" },
                new StatKey { Id = StatKeys.Appraise, Name = "Appraise" },
                new StatKey { Id = StatKeys.Bluff, Name = "Bluff" },
                new StatKey { Id = StatKeys.Climb, Name = "Climb" },
                new StatKey { Id = StatKeys.Craft, Name = "Craft" },
                new StatKey { Id = StatKeys.Diplomacy, Name = "Diplomacy" },
                new StatKey { Id = StatKeys.DisableDevice, Name = "Disable Device" },
                new StatKey { Id = StatKeys.Disguise, Name = "Disguise" },
                new StatKey { Id = StatKeys.EscapeArtist, Name = "Escape Artist" },
                new StatKey { Id = StatKeys.Fly, Name = "Fly" },
                new StatKey { Id = StatKeys.HandleAnimal, Name = "Handle Animal" },
                new StatKey { Id = StatKeys.Heal, Name = "Heal" },
                new StatKey { Id = StatKeys.Intimidate, Name = "Intimidate" },
                new StatKey { Id = StatKeys.KnowledgeArcana, Name = "Knowledge Arcana" },
                new StatKey { Id = StatKeys.KnowledgeDungeoneering, Name = "Knowledge Dungeoneering" },
                new StatKey { Id = StatKeys.KnowledgeEngineering, Name = "Knowledge Engineering" },
                new StatKey { Id = StatKeys.KnowledgeGeography, Name = "Knowledge Geography" },
                new StatKey { Id = StatKeys.KnowledgeHistory, Name = "Knowledge History" },
                new StatKey { Id = StatKeys.KnowledgeLocal, Name = "Knowledge Local" },
                new StatKey { Id = StatKeys.KnowledgeNature, Name = "Knowledge Nature" },
                new StatKey { Id = StatKeys.KnowledgeNobility, Name = "Knowledge Nobility" },
                new StatKey { Id = StatKeys.KnowledgePlanes, Name = "Knowledge Planes" },
                new StatKey { Id = StatKeys.KnowledgeReligion, Name = "Knowledge Religion" },
                new StatKey { Id = StatKeys.Linguistics, Name = "Linguistics" },
                new StatKey { Id = StatKeys.Perception, Name = "Perception" },
                new StatKey { Id = StatKeys.Perform, Name = "Perform" },
                new StatKey { Id = StatKeys.Profession, Name = "Profession" },
                new StatKey { Id = StatKeys.Ride, Name = "Ride" },
                new StatKey { Id = StatKeys.SenseMotive, Name = "Sense Motive" },
                new StatKey { Id = StatKeys.SleightOfHand, Name = "Sleight of Hand" },
                new StatKey { Id = StatKeys.Spellcraft, Name = "Spellcraft" },
                new StatKey { Id = StatKeys.Stealth, Name = "Stealth" },
                new StatKey { Id = StatKeys.Survival, Name = "Survival" },
                new StatKey { Id = StatKeys.Swim, Name = "Swim" },
                new StatKey { Id = StatKeys.UseMagicDevice, Name = "Use Magic Device" }
            );
        }

        private static void AddSpellDescriptors(PathfinderContext context)
        {
            context.AddRange(
                new Descriptor { Name = "Acid" },
                new Descriptor { Name = "Air" },
                new Descriptor { Name = "Chaotic" },
                new Descriptor { Name = "Cold" },
                new Descriptor { Name = "Curse" },
                new Descriptor { Name = "Darkness" },
                new Descriptor { Name = "Death" },
                new Descriptor { Name = "Disease" },
                new Descriptor { Name = "Earth" },
                new Descriptor { Name = "Electricity" },
                new Descriptor { Name = "Emotion" },
                new Descriptor { Name = "Evil" },
                new Descriptor { Name = "Fear" },
                new Descriptor { Name = "Figment" },
                new Descriptor { Name = "Fire" },
                new Descriptor { Name = "Force" },
                new Descriptor { Name = "Good" },
                new Descriptor { Name = "Language-Dependant" },
                new Descriptor { Name = "Lawful" },
                new Descriptor { Name = "Light" },
                new Descriptor { Name = "Mind-affecting" },
                new Descriptor { Name = "Pain" },
                new Descriptor { Name = "Poison" },
                new Descriptor { Name = "Shadow" },
                new Descriptor { Name = "Sonic" },
                new Descriptor { Name = "Water" }
            );
        }

        private static void AddSubschools(PathfinderContext context)
        {
            context.AddRange(
                new Subschool { Name = "Calling" },
                new Subschool { Name = "Charm" },
                new Subschool { Name = "Compulsion" },
                new Subschool { Name = "Creation" },
                new Subschool { Name = "Figment" },
                new Subschool { Name = "Glamer" },
                new Subschool { Name = "Haunted" },
                new Subschool { Name = "Healing" },
                new Subschool { Name = "Light" },
                new Subschool { Name = "Pattern" },
                new Subschool { Name = "Phantasm" },
                new Subschool { Name = "Polymorph" },
                new Subschool { Name = "Scrying" },
                new Subschool { Name = "Shadow" },
                new Subschool { Name = "Summoning" },
                new Subschool { Name = "Teleportation" }

            );
        }

        private static void AddTimeUnits(PathfinderContext context)
        {
            context.AddRange(
                new TimeUnit { Name = "Rounds", TimeInSeconds = 6 },
                new TimeUnit { Name = "Seconds", TimeInSeconds = 1 },
                new TimeUnit { Name = "Minutes", TimeInSeconds = 60 },
                new TimeUnit { Name = "Hours", TimeInSeconds = 3600 },
                new TimeUnit { Name = "Days", TimeInSeconds = 86400 }
            );
        }
    }
}
