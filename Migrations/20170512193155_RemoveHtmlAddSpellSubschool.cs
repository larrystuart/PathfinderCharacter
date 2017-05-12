using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PathfinderCharacter.Migrations
{
    public partial class RemoveHtmlAddSpellSubschool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subschools_Spells_SpellId",
                table: "Subschools");

            migrationBuilder.DropIndex(
                name: "IX_Subschools_SpellId",
                table: "Subschools");

            migrationBuilder.DropColumn(
                name: "SpellId",
                table: "Subschools");

            migrationBuilder.DropColumn(
                name: "HTMLFullDescription",
                table: "Spells");

            migrationBuilder.CreateTable(
                name: "SpellSubschool",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SpellId = table.Column<Guid>(nullable: true),
                    SubschoolId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellSubschool", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellSubschool_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpellSubschool_Subschools_SubschoolId",
                        column: x => x.SubschoolId,
                        principalTable: "Subschools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpellSubschool_SpellId",
                table: "SpellSubschool",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellSubschool_SubschoolId",
                table: "SpellSubschool",
                column: "SubschoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpellSubschool");

            migrationBuilder.AddColumn<Guid>(
                name: "SpellId",
                table: "Subschools",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HTMLFullDescription",
                table: "Spells",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subschools_SpellId",
                table: "Subschools",
                column: "SpellId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subschools_Spells_SpellId",
                table: "Subschools",
                column: "SpellId",
                principalTable: "Spells",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
