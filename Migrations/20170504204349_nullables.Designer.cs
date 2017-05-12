using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PathfinderCharacter;

namespace PathfinderCharacter.Migrations
{
    [DbContext(typeof(PathfinderContext))]
    [Migration("20170504204349_nullables")]
    partial class nullables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PathfinderCharacter.Core.Models.RawSpell", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("SLA_Level");

                    b.Property<bool?>("acid");

                    b.Property<int?>("adept");

                    b.Property<bool?>("air");

                    b.Property<int?>("alchemist");

                    b.Property<int?>("antipaladin");

                    b.Property<string>("area");

                    b.Property<string>("augmented");

                    b.Property<int?>("bard");

                    b.Property<string>("bloodline");

                    b.Property<int?>("bloodrager");

                    b.Property<string>("casting_time");

                    b.Property<bool?>("chaotic");

                    b.Property<int?>("cleric");

                    b.Property<bool?>("cold");

                    b.Property<string>("components");

                    b.Property<bool?>("costly_components");

                    b.Property<bool?>("curse");

                    b.Property<bool?>("darkness");

                    b.Property<bool?>("death");

                    b.Property<string>("deity");

                    b.Property<string>("description");

                    b.Property<string>("description_formated");

                    b.Property<string>("descriptor");

                    b.Property<bool?>("disease");

                    b.Property<bool?>("dismissible");

                    b.Property<bool?>("divine_focus");

                    b.Property<string>("domain");

                    b.Property<bool?>("draconic");

                    b.Property<int?>("druid");

                    b.Property<string>("duration");

                    b.Property<bool?>("earth");

                    b.Property<string>("effect");

                    b.Property<bool?>("electricity");

                    b.Property<bool?>("emotion");

                    b.Property<bool?>("evil");

                    b.Property<bool?>("fear");

                    b.Property<bool?>("fire");

                    b.Property<bool?>("focus");

                    b.Property<bool?>("force");

                    b.Property<string>("full_text");

                    b.Property<bool?>("good");

                    b.Property<string>("haunt_statistics");

                    b.Property<int?>("hunter");

                    b.Property<int?>("inquisitor");

                    b.Property<int?>("investigator");

                    b.Property<bool?>("language_dependent");

                    b.Property<bool?>("lawful");

                    b.Property<bool?>("light");

                    b.Property<string>("linktext");

                    b.Property<int?>("magus");

                    b.Property<bool?>("material");

                    b.Property<int?>("material_costs");

                    b.Property<bool?>("meditative");

                    b.Property<int?>("medium");

                    b.Property<int?>("mesmerist");

                    b.Property<bool?>("mind_affecting");

                    b.Property<bool?>("mythic");

                    b.Property<string>("mythic_text");

                    b.Property<string>("name");

                    b.Property<int?>("occultist");

                    b.Property<int?>("oracle");

                    b.Property<bool?>("pain");

                    b.Property<int?>("paladin");

                    b.Property<string>("patron");

                    b.Property<bool?>("poison");

                    b.Property<int?>("psychic");

                    b.Property<string>("range");

                    b.Property<int?>("ranger");

                    b.Property<bool?>("ruse");

                    b.Property<string>("saving_throw");

                    b.Property<string>("school");

                    b.Property<bool?>("shadow");

                    b.Property<int?>("shaman");

                    b.Property<bool?>("shapeable");

                    b.Property<string>("short_description");

                    b.Property<int?>("skald");

                    b.Property<bool?>("somatic");

                    b.Property<bool?>("sonic");

                    b.Property<int?>("sor");

                    b.Property<string>("source");

                    b.Property<string>("spell_level");

                    b.Property<string>("spell_resistence");

                    b.Property<int?>("spiritualist");

                    b.Property<string>("subschool");

                    b.Property<int?>("summoner");

                    b.Property<string>("targets");

                    b.Property<bool?>("verbal");

                    b.Property<bool?>("water");

                    b.Property<int?>("witch");

                    b.Property<int?>("wiz");

                    b.HasKey("id");

                    b.ToTable("RawSpells");
                });
        }
    }
}
