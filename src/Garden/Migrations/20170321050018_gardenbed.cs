using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Garden.Migrations
{
    public partial class gardenbed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GardenBeds",
                columns: table => new
                {
                    GardenBedID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BedDescription = table.Column<string>(nullable: true),
                    BedLength = table.Column<int>(nullable: false),
                    BedLoacation = table.Column<string>(nullable: true),
                    BedName = table.Column<string>(nullable: true),
                    BedWidth = table.Column<int>(nullable: false),
                    HoursOfSun = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GardenBeds", x => x.GardenBedID);
                });

            migrationBuilder.AddColumn<int>(
                name: "GardenBedID",
                table: "Vegtables",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vegtables_GardenBedID",
                table: "Vegtables",
                column: "GardenBedID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vegtables_GardenBeds_GardenBedID",
                table: "Vegtables",
                column: "GardenBedID",
                principalTable: "GardenBeds",
                principalColumn: "GardenBedID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vegtables_GardenBeds_GardenBedID",
                table: "Vegtables");

            migrationBuilder.DropIndex(
                name: "IX_Vegtables_GardenBedID",
                table: "Vegtables");

            migrationBuilder.DropColumn(
                name: "GardenBedID",
                table: "Vegtables");

            migrationBuilder.DropTable(
                name: "GardenBeds");
        }
    }
}
