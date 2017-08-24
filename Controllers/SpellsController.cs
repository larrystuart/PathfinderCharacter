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
    public class SpellsController : Controller
    {
        private IMemoryCache _cache;

        private PathfinderContext pfContext;

        public SpellsController(PathfinderContext pfContext, IMemoryCache memoryCache)
        {
            _cache = memoryCache;
            this.pfContext = pfContext;
        }

        // /api/Spells/AddSpell/' + spellId + '/tobook/' + spellbookId
        [HttpGet("[action]/{spellId}/tobook/{spellbookId}")]
        public void AddSpell(Guid spellId, Guid spellbookId)
        {
            pfContext.SpellBooks.Find(spellbookId).Spells.Add(new SpellbookSpell() {
                MetaMagics = new List<MetaMagic>(),
                Quantity = 1, 
                Used = 0,
                Spell = pfContext.Spells.Find(spellId)
            });

            pfContext.SaveChanges();
        }

        
        [HttpGet("[action]")]
        public IEnumerable<Spell> Spells()
        {
            string key = "spellCache";
            List<Spell> mySpells;

            if (!_cache.TryGetValue(key, out mySpells))
            {
                //4.fetch the data from the object
                mySpells = pfContext.Spells
                    .Include(s => s.School)
                    .Include(s => s.SpellSubschools)
                        .ThenInclude(ss => ss.Subschool)
                    .Include(s=>s.SpellSavingThrows)
                        .ThenInclude(sst=>sst.SavingThrow)
                    .Include(s => s.Classes)
                        .ThenInclude(c=> c.HeroClass)
                    .Include(s=> s.Components)
                        .ThenInclude(c => c.ComponentType)
                    .Include(s => s.Components)
                        .ThenInclude(c => c.MaterialCost)
                            .ThenInclude(m => m.CurrencyUnit)
                    .ToList();
                //5.Save the received data in cache
                _cache.Set(key, mySpells,
                    new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(30)));
            }
            else
            {
                mySpells = _cache.Get(key) as List<Spell>;
            }
            
            return mySpells;
        }

        [HttpGet("[action]")]
        public string DataMigrate()
        {
            RawSpell tempspell;
            try
            {
                List<RawSpell> rawSpells = pfContext.RawSpells.ToList();
                List<Spell> spells = new List<Spell>();
                List<CurrencyUnit> currencyUnits= pfContext.CurrencyUnits.ToList();
                List<Subschool> subschools = pfContext.Subschools.ToList();
                List<CastingTime> castingTimes = pfContext.CastingTime.ToList();
                List<School> schools = pfContext.Schools.ToList();
                List<Bloodline> bloodlines = pfContext.Bloodlines.ToList();
                List<HeroClass> heroClasses = pfContext.HeroClasses.ToList();
                List<ComponentType> componentTypes = pfContext.ComponentTypes.ToList();
                List<Descriptor> spellDescriptors = pfContext.SpellDescriptors.ToList();
                List<Domain> domains = pfContext.Domains.ToList();
                List<SavingThrow> savingThrows = pfContext.SavingThrows.ToList();
                
                foreach (var rawSpell in rawSpells)
                {
                    tempspell = rawSpell;
                    Spell spell = new Spell()
                    {
                        Area = rawSpell.area,
                        AugmentedText = rawSpell.augmented,
                        CastingTime = castingTimes.FirstOrDefault(c=> c.Name == rawSpell.casting_time),
                        Description = rawSpell.description,
                        Duration = rawSpell.duration,
                        Effect = rawSpell.effect,
                        HTMLDescription = rawSpell.description_formated,
                        Mythic = rawSpell.mythic.HasValue ? rawSpell.mythic.Value : false,
                        MythicText = rawSpell.mythic_text,
                        Name = rawSpell.name,
                        Range = rawSpell.range,
                        ReferenceSource = pfContext.ReferenceSources.FirstOrDefault(c => c.Name == rawSpell.source),
                        School = schools.FirstOrDefault(s => s.Name.ToLower() == rawSpell.school.ToLower()),
                        ShortDescription = rawSpell.short_description,
                        SpellLikeAbilityLevel = rawSpell.SLA_Level.HasValue ? rawSpell.SLA_Level.Value : -1,
                        SpellResistance = !string.IsNullOrEmpty(rawSpell.spell_resistence) ? rawSpell.spell_resistence.ToLower().Contains("yes") : false,
                        SpellResistanceHarmless = !string.IsNullOrEmpty(rawSpell.spell_resistence) ? rawSpell.spell_resistence.ToLower().Contains("harmless") : false,
                        SpellResistanceObject = !string.IsNullOrEmpty(rawSpell.spell_resistence) ? rawSpell.spell_resistence.ToLower().Contains("object") : false,
                        Targets = rawSpell.targets
                    };

                    //Bloodlines
                    if (!string.IsNullOrEmpty(rawSpell.bloodline))
                    { 
                        foreach (var bloodlineString in rawSpell.bloodline.Trim().Replace(" ", "").Split(','))
                        {
                            string bloodline = bloodlineString.Split('(')[0];
                            int level = int.Parse(bloodlineString.Split('(')[1].TrimEnd(")".ToCharArray()));

                            spell.BloodlineSpells.Add(new BloodlineSpell() {
                                Bloodline = bloodlines.FirstOrDefault(b => b.Name == bloodline),
                                level = level
                            });
                        }
                    }

                    //Hero Classes
                    if (rawSpell.adept.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.adept.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Adept")
                        });
                    }
                    if (rawSpell.alchemist.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.alchemist.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Alchemist")
                        });
                    }
                    if (rawSpell.antipaladin.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.antipaladin.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Antipaladin")
                        });
                    }
                    if (rawSpell.bard.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.bard.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Bard")
                        });
                    }
                    if (rawSpell.bloodrager.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.bloodrager.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Bloodrager")
                        });
                    }
                    if (rawSpell.cleric.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.cleric.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Cleric")
                        });
                    }
                    if (rawSpell.druid.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.druid.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Druid")
                        });
                    }
                    if (rawSpell.hunter.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.hunter.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Hunter")
                        });
                    }
                    if (rawSpell.inquisitor.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.inquisitor.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Inquisitor")
                        });
                    }
                    if (rawSpell.investigator.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.investigator.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Investigator")
                        });
                    }
                    if (rawSpell.magus.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.magus.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Magus")
                        });
                    }
                    if (rawSpell.medium.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.medium.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Medium")
                        });
                    }
                    if (rawSpell.mesmerist.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.mesmerist.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Mesmerist")
                        });
                    }
                    if (rawSpell.occultist.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.occultist.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Occultist")
                        });
                    }
                    if (rawSpell.oracle.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.oracle.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Oracle")
                        });
                    }
                    if (rawSpell.paladin.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.paladin.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Paladin")
                        });
                    }
                    if (rawSpell.psychic.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.psychic.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Psychic")
                        });
                    }
                    if (rawSpell.ranger.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.ranger.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Ranger")
                        });
                    }
                    if (rawSpell.shaman.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.shaman.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Shaman")
                        });
                    }
                    if (rawSpell.skald.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.skald.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Skald")
                        });
                    }
                    if (rawSpell.sor.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.sor.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Sorcerer")
                        });
                    }
                    if (rawSpell.spiritualist.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.spiritualist.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Spiritualist")
                        });
                    }
                    if (rawSpell.summoner.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.summoner.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Summoner")
                        });
                    }
                    if (rawSpell.witch.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.witch.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Witch")
                        });
                    }
                    if (rawSpell.wiz.HasValue)
                    {
                        spell.Classes.Add(new SpellClass()
                        {
                            ClassLevel = rawSpell.wiz.Value,
                            HeroClass = heroClasses.FirstOrDefault(h => h.Name == "Wizard")
                        });
                    }

                    //Spell Components
                    string rawComponentString = " , " + rawSpell.components;

                    foreach (var lookupComponent in componentTypes)
                    {
                        string lookupSearch = ", " + lookupComponent.Symbol;
                        if (rawComponentString.Contains(lookupSearch + ",") || rawComponentString.Contains(lookupSearch + " ("))
                        {
                            Currency materialCost = null;
                            string material = "";
                            int index = rawComponentString.IndexOf(lookupSearch + " (");
                            if (index != -1)
                            {
                                material = rawComponentString.Substring(index + lookupSearch.Length + 2).Split(')')[0];
                                materialCost = new Currency()
                                {
                                    Amount = rawSpell.material_costs.HasValue && rawSpell.costly_components.HasValue && rawSpell.costly_components.Value ? rawSpell.material_costs.Value : 0,
                                    CurrencyUnit = currencyUnits.FirstOrDefault(c => c.NameShort == "gp")
                                };
                            }

                            spell.Components.Add(new Component()
                            {
                                ComponentType = lookupComponent,
                                Material = material,
                                MaterialCost = materialCost
                            });
                        }
                    }
                    
                    //Spell Descriptors
                    foreach (var descriptor in spellDescriptors)
                    {
                        if (!string.IsNullOrEmpty(rawSpell.descriptor) && rawSpell.descriptor.ToLower().Contains(descriptor.Name.ToLower()))
                        {
                            spell.Descriptors.Add(descriptor);
                        }
                    }

                    //Spell Domains
                    if (!string.IsNullOrEmpty(rawSpell.domain))
                    { 
                        foreach (var domain in rawSpell.domain.Split(','))
                        {
                            string domainName = domain.Split('(')[0].Trim();
                            int level = int.Parse(domain.Split('(')[1].Split(')')[0].Trim());

                            spell.SpellDomains.Add(new SpellDomain() {
                                Domain = domains.FirstOrDefault(d => d.Name == domainName),
                                Level = level
                            });
                        }
                    }

                    foreach (var savingThrow in savingThrows)
                    {
                        if (!string.IsNullOrEmpty(rawSpell.saving_throw) && rawSpell.saving_throw.ToLower().Contains(savingThrow.Name.ToLower()))
                        {
                            spell.SpellSavingThrows.Add(new SpellSavingThrow() { SavingThrow = savingThrow });
                        }
                    }

                    foreach (var subschool in subschools)
                    {
                        if (!string.IsNullOrEmpty(rawSpell.subschool) && rawSpell.subschool.ToLower().Contains(subschool.Name.ToLower()))
                        {
                            spell.SpellSubschools.Add(new SpellSubschool() { Subschool = subschool });
                        }
                    }
                    spells.Add(spell);
                }

                pfContext.Spells.AddRange(spells);
                pfContext.SaveChanges();
            }
            catch (Exception e)
            {
                
                return e.Message + e.InnerException?.Message;
            }
            
            return "success";
        }

    }
}
