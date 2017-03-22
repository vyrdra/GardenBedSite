using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garden.Migrations
{
    public partial class varGerm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaysGerminationMax",
                table: "VegVarieties");

            migrationBuilder.DropColumn(
                name: "DaysGerminationMin",
                table: "VegVarieties");

            migrationBuilder.AddColumn<int>(
                name: "DaysGerminationMax",
                table: "Vegtables",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DaysGerminationMin",
                table: "Vegtables",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaysGerminationMax",
                table: "Vegtables");

            migrationBuilder.DropColumn(
                name: "DaysGerminationMin",
                table: "Vegtables");

            migrationBuilder.AddColumn<int>(
                name: "DaysGerminationMax",
                table: "VegVarieties",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DaysGerminationMin",
                table: "VegVarieties",
                nullable: false,
                defaultValue: 0);
        }
    }
}
