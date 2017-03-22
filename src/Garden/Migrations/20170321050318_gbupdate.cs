using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garden.Migrations
{
    public partial class gbupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BedLoacation",
                table: "GardenBeds");

            migrationBuilder.AddColumn<string>(
                name: "BedLocation",
                table: "GardenBeds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BedZone",
                table: "GardenBeds",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BedLocation",
                table: "GardenBeds");

            migrationBuilder.DropColumn(
                name: "BedZone",
                table: "GardenBeds");

            migrationBuilder.AddColumn<string>(
                name: "BedLoacation",
                table: "GardenBeds",
                nullable: true);
        }
    }
}
