using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PathfinderCharacter.Migrations
{
    public partial class FixSavingThrow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavingThrows_Spells_SpellId",
                table: "SavingThrows");

            migrationBuilder.DropIndex(
                name: "IX_SavingThrows_SpellId",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "SpellId",
                table: "SavingThrows");

            migrationBuilder.CreateTable(
                name: "SpellSavingThrow",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SavingThrowId = table.Column<Guid>(nullable: true),
                    SpellId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellSavingThrow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellSavingThrow_SavingThrows_SavingThrowId",
                        column: x => x.SavingThrowId,
                        principalTable: "SavingThrows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpellSavingThrow_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpellSavingThrow_SavingThrowId",
                table: "SpellSavingThrow",
                column: "SavingThrowId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellSavingThrow_SpellId",
                table: "SpellSavingThrow",
                column: "SpellId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpellSavingThrow");

            migrationBuilder.AddColumn<Guid>(
                name: "SpellId",
                table: "SavingThrows",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrows_SpellId",
                table: "SavingThrows",
                column: "SpellId");

            migrationBuilder.AddForeignKey(
                name: "FK_SavingThrows_Spells_SpellId",
                table: "SavingThrows",
                column: "SpellId",
                principalTable: "Spells",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
