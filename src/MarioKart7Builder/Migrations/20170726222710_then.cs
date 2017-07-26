using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarioKart7Builder.Migrations
{
    public partial class then : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "tireId",
                table: "karts",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "gliderId",
                table: "karts",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "characterId",
                table: "karts",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "bodyId",
                table: "karts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_karts_bodyid",
                table: "karts",
                column: "bodyId");

            migrationBuilder.CreateIndex(
                name: "IX_karts_characterid",
                table: "karts",
                column: "characterId");

            migrationBuilder.CreateIndex(
                name: "IX_karts_gliderid",
                table: "karts",
                column: "gliderId");

            migrationBuilder.CreateIndex(
                name: "IX_karts_tireid",
                table: "karts",
                column: "tireId");

            migrationBuilder.AddForeignKey(
                name: "FK_karts_bodys_bodyid",
                table: "karts",
                column: "bodyId",
                principalTable: "bodys",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_karts_characters_characterid",
                table: "karts",
                column: "characterId",
                principalTable: "characters",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_karts_gliders_gliderid",
                table: "karts",
                column: "gliderId",
                principalTable: "gliders",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_karts_tires_tireid",
                table: "karts",
                column: "tireId",
                principalTable: "tires",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameColumn(
                name: "tireId",
                table: "karts",
                newName: "tireid");

            migrationBuilder.RenameColumn(
                name: "gliderId",
                table: "karts",
                newName: "gliderid");

            migrationBuilder.RenameColumn(
                name: "characterId",
                table: "karts",
                newName: "characterid");

            migrationBuilder.RenameColumn(
                name: "bodyId",
                table: "karts",
                newName: "bodyid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_karts_bodys_bodyid",
                table: "karts");

            migrationBuilder.DropForeignKey(
                name: "FK_karts_characters_characterid",
                table: "karts");

            migrationBuilder.DropForeignKey(
                name: "FK_karts_gliders_gliderid",
                table: "karts");

            migrationBuilder.DropForeignKey(
                name: "FK_karts_tires_tireid",
                table: "karts");

            migrationBuilder.DropIndex(
                name: "IX_karts_bodyid",
                table: "karts");

            migrationBuilder.DropIndex(
                name: "IX_karts_characterid",
                table: "karts");

            migrationBuilder.DropIndex(
                name: "IX_karts_gliderid",
                table: "karts");

            migrationBuilder.DropIndex(
                name: "IX_karts_tireid",
                table: "karts");

            migrationBuilder.AlterColumn<int>(
                name: "tireid",
                table: "karts",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "gliderid",
                table: "karts",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "characterid",
                table: "karts",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "bodyid",
                table: "karts",
                nullable: false);

            migrationBuilder.RenameColumn(
                name: "tireid",
                table: "karts",
                newName: "tireId");

            migrationBuilder.RenameColumn(
                name: "gliderid",
                table: "karts",
                newName: "gliderId");

            migrationBuilder.RenameColumn(
                name: "characterid",
                table: "karts",
                newName: "characterId");

            migrationBuilder.RenameColumn(
                name: "bodyid",
                table: "karts",
                newName: "bodyId");
        }
    }
}
