using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PathfinderCharacter.Migrations
{
    public partial class PartiallyNormalized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bloodlines",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bloodlines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CastingTime",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastingTime", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NameShort = table.Column<string>(nullable: true),
                    ValueFactor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeroClasses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patrons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patrons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferenceSource",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceSource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TimeInSeconds = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BloodlineSpell",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BloodlineId = table.Column<Guid>(nullable: true),
                    level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodlineSpell", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BloodlineSpell_Bloodlines_BloodlineId",
                        column: x => x.BloodlineId,
                        principalTable: "Bloodlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    CurrencyUnitId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Currency_CurrencyUnits_CurrencyUnitId",
                        column: x => x.CurrencyUnitId,
                        principalTable: "CurrencyUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Duration",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BaseAmount = table.Column<int>(nullable: false),
                    BonusAmount = table.Column<int>(nullable: false),
                    LevelsToBonus = table.Column<int>(nullable: false),
                    TimeUnitId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Duration_TimeUnits_TimeUnitId",
                        column: x => x.TimeUnitId,
                        principalTable: "TimeUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Area = table.Column<string>(nullable: true),
                    AugmentedText = table.Column<string>(nullable: true),
                    BloodlineSpellId = table.Column<Guid>(nullable: true),
                    CastingTimeId = table.Column<Guid>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DurationId = table.Column<Guid>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    HTMLDescription = table.Column<string>(nullable: true),
                    HTMLFullDescription = table.Column<string>(nullable: true),
                    Mythic = table.Column<bool>(nullable: false),
                    MythicText = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    ReferenceSourceId = table.Column<Guid>(nullable: true),
                    SchoolId = table.Column<Guid>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    SpellLikeAbilityLevel = table.Column<int>(nullable: false),
                    SpellResistance = table.Column<bool>(nullable: false),
                    SpellResistanceHarmless = table.Column<bool>(nullable: false),
                    SpellResistanceObject = table.Column<bool>(nullable: false),
                    Targets = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spells_BloodlineSpell_BloodlineSpellId",
                        column: x => x.BloodlineSpellId,
                        principalTable: "BloodlineSpell",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spells_CastingTime_CastingTimeId",
                        column: x => x.CastingTimeId,
                        principalTable: "CastingTime",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spells_Duration_DurationId",
                        column: x => x.DurationId,
                        principalTable: "Duration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spells_ReferenceSource_ReferenceSourceId",
                        column: x => x.ReferenceSourceId,
                        principalTable: "ReferenceSource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spells_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Material = table.Column<string>(nullable: true),
                    MaterialCostId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SpellId = table.Column<Guid>(nullable: true),
                    Symbol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Components_Currency_MaterialCostId",
                        column: x => x.MaterialCostId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Components_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpellDescriptors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SpellId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellDescriptors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellDescriptors_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Domains",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SpellId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Domains_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Effect",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SpellId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Effect", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Effect_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SavingThrows",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SpellId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingThrows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavingThrows_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpellClass",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ClassLevel = table.Column<int>(nullable: false),
                    HeroClassId = table.Column<Guid>(nullable: true),
                    SpellId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellClass_HeroClasses_HeroClassId",
                        column: x => x.HeroClassId,
                        principalTable: "HeroClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpellClass_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subschools",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SpellId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subschools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subschools_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BloodlineSpell_BloodlineId",
                table: "BloodlineSpell",
                column: "BloodlineId");

            migrationBuilder.CreateIndex(
                name: "IX_Components_MaterialCostId",
                table: "Components",
                column: "MaterialCostId");

            migrationBuilder.CreateIndex(
                name: "IX_Components_SpellId",
                table: "Components",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Currency_CurrencyUnitId",
                table: "Currency",
                column: "CurrencyUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellDescriptors_SpellId",
                table: "SpellDescriptors",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Domains_SpellId",
                table: "Domains",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Duration_TimeUnitId",
                table: "Duration",
                column: "TimeUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Effect_SpellId",
                table: "Effect",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrows_SpellId",
                table: "SavingThrows",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_BloodlineSpellId",
                table: "Spells",
                column: "BloodlineSpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_CastingTimeId",
                table: "Spells",
                column: "CastingTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_DurationId",
                table: "Spells",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_ReferenceSourceId",
                table: "Spells",
                column: "ReferenceSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SchoolId",
                table: "Spells",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellClass_HeroClassId",
                table: "SpellClass",
                column: "HeroClassId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellClass_SpellId",
                table: "SpellClass",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Subschools_SpellId",
                table: "Subschools",
                column: "SpellId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "SpellDescriptors");

            migrationBuilder.DropTable(
                name: "Domains");

            migrationBuilder.DropTable(
                name: "Effect");

            migrationBuilder.DropTable(
                name: "Patrons");

            migrationBuilder.DropTable(
                name: "SavingThrows");

            migrationBuilder.DropTable(
                name: "SpellClass");

            migrationBuilder.DropTable(
                name: "Subschools");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "HeroClasses");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "CurrencyUnits");

            migrationBuilder.DropTable(
                name: "BloodlineSpell");

            migrationBuilder.DropTable(
                name: "CastingTime");

            migrationBuilder.DropTable(
                name: "Duration");

            migrationBuilder.DropTable(
                name: "ReferenceSource");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Bloodlines");

            migrationBuilder.DropTable(
                name: "TimeUnits");
        }
    }
}
