using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PathfinderCharacter.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RawSpells",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SLA_Level = table.Column<int>(nullable: false),
                    acid = table.Column<bool>(nullable: false),
                    adept = table.Column<int>(nullable: false),
                    air = table.Column<bool>(nullable: false),
                    alchemist = table.Column<int>(nullable: false),
                    antipaladin = table.Column<int>(nullable: false),
                    area = table.Column<string>(nullable: true),
                    augmented = table.Column<string>(nullable: true),
                    bard = table.Column<int>(nullable: false),
                    bloodline = table.Column<string>(nullable: true),
                    bloodrager = table.Column<int>(nullable: false),
                    casting_time = table.Column<string>(nullable: true),
                    chaotic = table.Column<bool>(nullable: false),
                    cleric = table.Column<int>(nullable: false),
                    cold = table.Column<bool>(nullable: false),
                    components = table.Column<string>(nullable: true),
                    costly_components = table.Column<bool>(nullable: false),
                    curse = table.Column<bool>(nullable: false),
                    darkness = table.Column<bool>(nullable: false),
                    death = table.Column<bool>(nullable: false),
                    deity = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    description_formated = table.Column<string>(nullable: true),
                    descriptor = table.Column<string>(nullable: true),
                    disease = table.Column<bool>(nullable: false),
                    dismissible = table.Column<bool>(nullable: false),
                    divine_focus = table.Column<bool>(nullable: false),
                    domain = table.Column<string>(nullable: true),
                    draconic = table.Column<bool>(nullable: false),
                    druid = table.Column<int>(nullable: false),
                    duration = table.Column<string>(nullable: true),
                    earth = table.Column<bool>(nullable: false),
                    effect = table.Column<string>(nullable: true),
                    electricity = table.Column<bool>(nullable: false),
                    emotion = table.Column<bool>(nullable: false),
                    evil = table.Column<bool>(nullable: false),
                    fear = table.Column<bool>(nullable: false),
                    fire = table.Column<bool>(nullable: false),
                    focus = table.Column<bool>(nullable: false),
                    force = table.Column<bool>(nullable: false),
                    full_text = table.Column<string>(nullable: true),
                    good = table.Column<bool>(nullable: false),
                    haunt_statistics = table.Column<string>(nullable: true),
                    hunter = table.Column<int>(nullable: false),
                    inquisitor = table.Column<int>(nullable: false),
                    investigator = table.Column<int>(nullable: false),
                    language_dependent = table.Column<bool>(nullable: false),
                    lawful = table.Column<bool>(nullable: false),
                    light = table.Column<bool>(nullable: false),
                    linktext = table.Column<string>(nullable: true),
                    magus = table.Column<int>(nullable: false),
                    material = table.Column<bool>(nullable: false),
                    material_costs = table.Column<int>(nullable: false),
                    meditative = table.Column<bool>(nullable: false),
                    medium = table.Column<int>(nullable: false),
                    mesmerist = table.Column<int>(nullable: false),
                    mind_affecting = table.Column<bool>(nullable: false),
                    mythic = table.Column<bool>(nullable: false),
                    mythic_text = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    occultist = table.Column<int>(nullable: false),
                    oracle = table.Column<int>(nullable: false),
                    pain = table.Column<bool>(nullable: false),
                    paladin = table.Column<int>(nullable: false),
                    patron = table.Column<string>(nullable: true),
                    poison = table.Column<bool>(nullable: false),
                    psychic = table.Column<int>(nullable: false),
                    range = table.Column<string>(nullable: true),
                    ranger = table.Column<int>(nullable: false),
                    ruse = table.Column<bool>(nullable: false),
                    saving_throw = table.Column<string>(nullable: true),
                    school = table.Column<string>(nullable: true),
                    shadow = table.Column<bool>(nullable: false),
                    shaman = table.Column<int>(nullable: false),
                    shapeable = table.Column<bool>(nullable: false),
                    short_description = table.Column<string>(nullable: true),
                    skald = table.Column<int>(nullable: false),
                    somatic = table.Column<bool>(nullable: false),
                    sonic = table.Column<bool>(nullable: false),
                    sor = table.Column<int>(nullable: false),
                    source = table.Column<string>(nullable: true),
                    spell_level = table.Column<string>(nullable: true),
                    spell_resistence = table.Column<string>(nullable: true),
                    spiritualist = table.Column<int>(nullable: false),
                    subschool = table.Column<string>(nullable: true),
                    summoner = table.Column<int>(nullable: false),
                    targets = table.Column<string>(nullable: true),
                    verbal = table.Column<bool>(nullable: false),
                    water = table.Column<bool>(nullable: false),
                    witch = table.Column<int>(nullable: false),
                    wiz = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawSpells", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RawSpells");
        }
    }
}
