using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathfinderCharacter.Models
{
    public class RawSpell
    {
        public RawSpell()
        {
            name = "";
            school = "";
            subschool = "";
            descriptor = "";
            spell_level = "";
            casting_time = "";
            components = "";
            range = "";
            area = "";
            effect = "";
            targets = "";
            duration = "";
            saving_throw = "";
            spell_resistence = "";
            description = "";
            description_formated = "";
            source = "";
            full_text = "";
            deity = "";
            domain = "";
            short_description = "";
            linktext = "";
            bloodline = "";
            patron = "";
            mythic_text = "";
            augmented = "";
            haunt_statistics = "";
        } 

        public int id { get; set; }
        public string name  { get; set; }
        public string school { get; set; }
        public string subschool { get; set; }
        public string descriptor { get; set; }
        public string spell_level { get; set; }
        public string casting_time { get; set; }
        public string components { get; set; }
        public bool? costly_components { get; set; }
        public string range { get; set; }
        public string area { get; set; }
        public string effect { get; set; }
        public string targets { get; set; }
        public string duration { get; set; }
        public bool? dismissible { get; set; }
        public bool? shapeable { get; set; }
        public string saving_throw { get; set; }
        public string spell_resistence { get; set; }
        public string description { get; set; }
        public string description_formated { get; set; }
        public string source { get; set; }
        public string full_text { get; set; }
        public bool? verbal { get; set; }
        public bool? somatic { get; set; }
        public bool? material { get; set; }
        public bool? focus { get; set; }
        public bool? divine_focus { get; set; }
        public int? sor { get; set; }
        public int? wiz { get; set; }
        public int? cleric { get; set; }
        public int? druid { get; set; }
        public int? ranger { get; set; }
        public int? bard { get; set; }
        public int? paladin { get; set; }
        public int? alchemist { get; set; }
        public int? summoner { get; set; }
        public int? witch { get; set; }
        public int? inquisitor { get; set; }
        public int? oracle { get; set; }
        public int? antipaladin { get; set; }
        public int? magus { get; set; }
        public int? adept { get; set; }
        public string deity { get; set; }
        public int? SLA_Level { get; set; }
        public string domain { get; set; }
        public string short_description { get; set; }
        public bool? acid { get; set; }
        public bool? air { get; set; }
        public bool? chaotic { get; set; }
        public bool? cold { get; set; }
        public bool? curse { get; set; }
        public bool? darkness { get; set; }
        public bool? death { get; set; }
        public bool? disease { get; set; }
        public bool? earth { get; set; }
        public bool? electricity { get; set; }
        public bool? emotion { get; set; }
        public bool? evil { get; set; }
        public bool? fear { get; set; }
        public bool? fire { get; set; }
        public bool? force { get; set; }
        public bool? good { get; set; }
        public bool? language_dependent { get; set; }
        public bool? lawful { get; set; }
        public bool? light { get; set; }
        public bool? mind_affecting { get; set; }
        public bool? pain { get; set; }
        public bool? poison { get; set; }
        public bool? shadow { get; set; }
        public bool? sonic { get; set; }
        public bool? water { get; set; }
        public string linktext { get; set; }
        public int? material_costs { get; set; }
        public string bloodline { get; set; }
        public string patron { get; set; }
        public string mythic_text  { get; set; }
        public string augmented { get; set; }
        public bool? mythic { get; set; }
        public int? bloodrager { get; set; }
        public int? shaman { get; set; }
        public int? psychic { get; set; }
        public int? medium { get; set; }
        public int? mesmerist { get; set; }
        public int? occultist { get; set; }
        public int? spiritualist { get; set; }
        public int? skald { get; set; }
        public int? investigator { get; set; }
        public int? hunter { get; set; }
        public string haunt_statistics { get; set; }
        public bool? ruse { get; set; }
        public bool? draconic { get; set; }
        public bool? meditative { get; set; }
    
    }
}
