﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PathfinderCharacter;

namespace PathfinderCharacter.Migrations
{
    [DbContext(typeof(PathfinderContext))]
    [Migration("20170509140725_PartiallyNormalized")]
    partial class PartiallyNormalized
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PathfinderCharacter.Models.Bloodline", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Bloodlines");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.BloodlineSpell", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("BloodlineId");

                    b.Property<int>("level");

                    b.HasKey("Id");

                    b.HasIndex("BloodlineId");

                    b.ToTable("BloodlineSpell");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.CastingTime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CastingTime");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Components", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Material");

                    b.Property<Guid?>("MaterialCostId");

                    b.Property<string>("Name");

                    b.Property<Guid?>("SpellId");

                    b.Property<string>("Symbol");

                    b.HasKey("Id");

                    b.HasIndex("MaterialCostId");

                    b.HasIndex("SpellId");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Currency", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<Guid?>("CurrencyUnitId");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyUnitId");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.CurrencyUnit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("NameShort");

                    b.Property<int>("ValueFactor");

                    b.HasKey("Id");

                    b.ToTable("CurrencyUnits");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Descriptor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid?>("SpellId");

                    b.HasKey("Id");

                    b.HasIndex("SpellId");

                    b.ToTable("SpellDescriptors");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Domain", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid?>("SpellId");

                    b.HasKey("Id");

                    b.HasIndex("SpellId");

                    b.ToTable("Domains");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Duration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BaseAmount");

                    b.Property<int>("BonusAmount");

                    b.Property<int>("LevelsToBonus");

                    b.Property<Guid?>("TimeUnitId");

                    b.HasKey("Id");

                    b.HasIndex("TimeUnitId");

                    b.ToTable("Duration");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Effect", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("SpellId");

                    b.HasKey("Id");

                    b.HasIndex("SpellId");

                    b.ToTable("Effect");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.HeroClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("HeroClasses");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Patron", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Patrons");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.RawSpell", b =>
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

            modelBuilder.Entity("PathfinderCharacter.Models.ReferenceSource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ReferenceSource");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.SavingThrow", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid?>("SpellId");

                    b.HasKey("Id");

                    b.HasIndex("SpellId");

                    b.ToTable("SavingThrows");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.School", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Spell", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Area");

                    b.Property<string>("AugmentedText");

                    b.Property<Guid?>("BloodlineSpellId");

                    b.Property<Guid?>("CastingTimeId");

                    b.Property<string>("Description");

                    b.Property<Guid?>("DurationId");

                    b.Property<string>("Effect");

                    b.Property<string>("HTMLDescription");

                    b.Property<string>("HTMLFullDescription");

                    b.Property<bool>("Mythic");

                    b.Property<string>("MythicText");

                    b.Property<string>("Name");

                    b.Property<string>("Range");

                    b.Property<Guid?>("ReferenceSourceId");

                    b.Property<Guid?>("SchoolId");

                    b.Property<string>("ShortDescription");

                    b.Property<int>("SpellLikeAbilityLevel");

                    b.Property<bool>("SpellResistance");

                    b.Property<bool>("SpellResistanceHarmless");

                    b.Property<bool>("SpellResistanceObject");

                    b.Property<string>("Targets");

                    b.HasKey("Id");

                    b.HasIndex("BloodlineSpellId");

                    b.HasIndex("CastingTimeId");

                    b.HasIndex("DurationId");

                    b.HasIndex("ReferenceSourceId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Spells");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.SpellClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClassLevel");

                    b.Property<Guid?>("HeroClassId");

                    b.Property<Guid?>("SpellId");

                    b.HasKey("Id");

                    b.HasIndex("HeroClassId");

                    b.HasIndex("SpellId");

                    b.ToTable("SpellClass");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Subschool", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid?>("SpellId");

                    b.HasKey("Id");

                    b.HasIndex("SpellId");

                    b.ToTable("Subschools");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.TimeUnit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("TimeInSeconds");

                    b.HasKey("Id");

                    b.ToTable("TimeUnits");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.BloodlineSpell", b =>
                {
                    b.HasOne("PathfinderCharacter.Models.Bloodline", "Bloodline")
                        .WithMany()
                        .HasForeignKey("BloodlineId");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Components", b =>
                {
                    b.HasOne("PathfinderCharacter.Models.Currency", "MaterialCost")
                        .WithMany()
                        .HasForeignKey("MaterialCostId");

                    b.HasOne("PathfinderCharacter.Models.Spell")
                        .WithMany("Components")
                        .HasForeignKey("SpellId");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Currency", b =>
                {
                    b.HasOne("PathfinderCharacter.Models.CurrencyUnit", "CurrencyUnit")
                        .WithMany()
                        .HasForeignKey("CurrencyUnitId");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Descriptor", b =>
                {
                    b.HasOne("PathfinderCharacter.Models.Spell")
                        .WithMany("Descriptor")
                        .HasForeignKey("SpellId");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Domain", b =>
                {
                    b.HasOne("PathfinderCharacter.Models.Spell")
                        .WithMany("Domains")
                        .HasForeignKey("SpellId");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Duration", b =>
                {
                    b.HasOne("PathfinderCharacter.Models.TimeUnit", "TimeUnit")
                        .WithMany()
                        .HasForeignKey("TimeUnitId");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Effect", b =>
                {
                    b.HasOne("PathfinderCharacter.Models.Spell")
                        .WithMany("Effects")
                        .HasForeignKey("SpellId");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.SavingThrow", b =>
                {
                    b.HasOne("PathfinderCharacter.Models.Spell")
                        .WithMany("SavingThrows")
                        .HasForeignKey("SpellId");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Spell", b =>
                {
                    b.HasOne("PathfinderCharacter.Models.BloodlineSpell", "BloodlineSpell")
                        .WithMany()
                        .HasForeignKey("BloodlineSpellId");

                    b.HasOne("PathfinderCharacter.Models.CastingTime", "CastingTime")
                        .WithMany()
                        .HasForeignKey("CastingTimeId");

                    b.HasOne("PathfinderCharacter.Models.Duration", "Duration")
                        .WithMany()
                        .HasForeignKey("DurationId");

                    b.HasOne("PathfinderCharacter.Models.ReferenceSource", "ReferenceSource")
                        .WithMany()
                        .HasForeignKey("ReferenceSourceId");

                    b.HasOne("PathfinderCharacter.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.SpellClass", b =>
                {
                    b.HasOne("PathfinderCharacter.Models.HeroClass", "HeroClass")
                        .WithMany()
                        .HasForeignKey("HeroClassId");

                    b.HasOne("PathfinderCharacter.Models.Spell")
                        .WithMany("Classes")
                        .HasForeignKey("SpellId");
                });

            modelBuilder.Entity("PathfinderCharacter.Models.Subschool", b =>
                {
                    b.HasOne("PathfinderCharacter.Models.Spell")
                        .WithMany("Subschools")
                        .HasForeignKey("SpellId");
                });
        }
    }
}
