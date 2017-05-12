using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PathfinderCharacter.Migrations
{
    public partial class MoreNormalized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Domains_Spells_SpellId",
                table: "Domains");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_BloodlineSpell_BloodlineSpellId",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_Duration_DurationId",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_ReferenceSource_ReferenceSourceId",
                table: "Spells");

            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "Duration");

            migrationBuilder.DropTable(
                name: "Effect");

            migrationBuilder.DropIndex(
                name: "IX_Spells_BloodlineSpellId",
                table: "Spells");

            migrationBuilder.DropIndex(
                name: "IX_Spells_DurationId",
                table: "Spells");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReferenceSource",
                table: "ReferenceSource");

            migrationBuilder.DropIndex(
                name: "IX_Domains_SpellId",
                table: "Domains");

            migrationBuilder.DropColumn(
                name: "BloodlineSpellId",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "DurationId",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "SpellId",
                table: "Domains");

            migrationBuilder.RenameTable(
                name: "ReferenceSource",
                newName: "ReferenceSources");

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "Spells",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SpellId",
                table: "BloodlineSpell",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReferenceSources",
                table: "ReferenceSources",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ComponentTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpellDomain",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DomainId = table.Column<Guid>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    SpellId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellDomain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellDomain_Domains_DomainId",
                        column: x => x.DomainId,
                        principalTable: "Domains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpellDomain_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Component",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ComponentTypeId = table.Column<Guid>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    MaterialCostId = table.Column<Guid>(nullable: true),
                    SpellId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Component", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Component_ComponentTypes_ComponentTypeId",
                        column: x => x.ComponentTypeId,
                        principalTable: "ComponentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Component_Currency_MaterialCostId",
                        column: x => x.MaterialCostId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Component_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BloodlineSpell_SpellId",
                table: "BloodlineSpell",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Component_ComponentTypeId",
                table: "Component",
                column: "ComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Component_MaterialCostId",
                table: "Component",
                column: "MaterialCostId");

            migrationBuilder.CreateIndex(
                name: "IX_Component_SpellId",
                table: "Component",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellDomain_DomainId",
                table: "SpellDomain",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellDomain_SpellId",
                table: "SpellDomain",
                column: "SpellId");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodlineSpell_Spells_SpellId",
                table: "BloodlineSpell",
                column: "SpellId",
                principalTable: "Spells",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_ReferenceSources_ReferenceSourceId",
                table: "Spells",
                column: "ReferenceSourceId",
                principalTable: "ReferenceSources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodlineSpell_Spells_SpellId",
                table: "BloodlineSpell");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_ReferenceSources_ReferenceSourceId",
                table: "Spells");

            migrationBuilder.DropTable(
                name: "Component");

            migrationBuilder.DropTable(
                name: "SpellDomain");

            migrationBuilder.DropTable(
                name: "ComponentTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReferenceSources",
                table: "ReferenceSources");

            migrationBuilder.DropIndex(
                name: "IX_BloodlineSpell_SpellId",
                table: "BloodlineSpell");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "SpellId",
                table: "BloodlineSpell");

            migrationBuilder.RenameTable(
                name: "ReferenceSources",
                newName: "ReferenceSource");

            migrationBuilder.AddColumn<Guid>(
                name: "BloodlineSpellId",
                table: "Spells",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DurationId",
                table: "Spells",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SpellId",
                table: "Domains",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReferenceSource",
                table: "ReferenceSource",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_Spells_BloodlineSpellId",
                table: "Spells",
                column: "BloodlineSpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_DurationId",
                table: "Spells",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Domains_SpellId",
                table: "Domains",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Components_MaterialCostId",
                table: "Components",
                column: "MaterialCostId");

            migrationBuilder.CreateIndex(
                name: "IX_Components_SpellId",
                table: "Components",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Duration_TimeUnitId",
                table: "Duration",
                column: "TimeUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Effect_SpellId",
                table: "Effect",
                column: "SpellId");

            migrationBuilder.AddForeignKey(
                name: "FK_Domains_Spells_SpellId",
                table: "Domains",
                column: "SpellId",
                principalTable: "Spells",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_BloodlineSpell_BloodlineSpellId",
                table: "Spells",
                column: "BloodlineSpellId",
                principalTable: "BloodlineSpell",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_Duration_DurationId",
                table: "Spells",
                column: "DurationId",
                principalTable: "Duration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_ReferenceSource_ReferenceSourceId",
                table: "Spells",
                column: "ReferenceSourceId",
                principalTable: "ReferenceSource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
