using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarioKart7Builder.Migrations
{
    public partial class floattypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "weight",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "watrHandling",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "waterSpeed",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "stabiliy",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "offRoad",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "miniTurbo",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "landSpeed",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "landHandling",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "drift",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "airSpeed",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "airHandling",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "acceleration",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "weight",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "watrHandling",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "waterSpeed",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "stabiliy",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "offRoad",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "miniTurbo",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "landSpeed",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "landHandling",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "drift",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "airSpeed",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "airHandling",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "acceleration",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "weight",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "watrHandling",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "waterSpeed",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "stabiliy",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "offRoad",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "miniTurbo",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "landSpeed",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "landHandling",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "drift",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "airSpeed",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "airHandling",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "acceleration",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "weight",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "watrHandling",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "waterSpeed",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "stabiliy",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "offRoad",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "miniTurbo",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "landSpeed",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "landHandling",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "drift",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "airSpeed",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "airHandling",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "acceleration",
                table: "bodys",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "weight",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "watrHandling",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "waterSpeed",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "stabiliy",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "offRoad",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "miniTurbo",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "landSpeed",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "landHandling",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "drift",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "airSpeed",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "airHandling",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "acceleration",
                table: "tires",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "weight",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "watrHandling",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "waterSpeed",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "stabiliy",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "offRoad",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "miniTurbo",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "landSpeed",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "landHandling",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "drift",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "airSpeed",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "airHandling",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "acceleration",
                table: "gliders",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "weight",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "watrHandling",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "waterSpeed",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "stabiliy",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "offRoad",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "miniTurbo",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "landSpeed",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "landHandling",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "drift",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "airSpeed",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "airHandling",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "acceleration",
                table: "characters",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "weight",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "watrHandling",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "waterSpeed",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "stabiliy",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "offRoad",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "miniTurbo",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "landSpeed",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "landHandling",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "drift",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "airSpeed",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "airHandling",
                table: "bodys",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "acceleration",
                table: "bodys",
                nullable: false);
        }
    }
}
