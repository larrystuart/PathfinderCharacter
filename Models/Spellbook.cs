using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathfinderCharacter.Models
{

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
}
