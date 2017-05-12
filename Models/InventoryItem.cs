using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathfinderCharacter.Models
{
    public class InventoryItem
    {
    }

    public class Currency
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public CurrencyUnit CurrencyUnit { get; set; }
    }

    public class CurrencyUnit
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameShort { get; set; }
        public int ValueFactor { get; set; }
    }
}

