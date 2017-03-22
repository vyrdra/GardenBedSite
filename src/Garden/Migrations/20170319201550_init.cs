using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Garden.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vegtables",
                columns: table => new
                {
                    VegId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DiseaseProblems = table.Column<string>(nullable: true),
                    FertilizerNeeds = table.Column<string>(nullable: true),
                    FullSun = table.Column<bool>(nullable: false),
                    IndoorSow = table.Column<string>(nullable: true),
                    InsectProbblems = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    PlantsPerFt = table.Column<int>(nullable: false),
                    RowDistance = table.Column<int>(nullable: false),
                    SeedDepth = table.Column<decimal>(nullable: false),
                    SeedSpacing = table.Column<decimal>(nullable: false),
                    SoilTemp = table.Column<int>(nullable: false),
                    ThinTo = table.Column<int>(nullable: false),
                    Transplant = table.Column<string>(nullable: true),
                    VegFamily = table.Column<string>(nullable: true),
                    VegName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vegtables", x => x.VegId);
                });

            migrationBuilder.CreateTable(
                name: "VegVarieties",
                columns: table => new
                {
                    VarietyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DaysGerminationMax = table.Column<int>(nullable: false),
                    DaysGerminationMin = table.Column<int>(nullable: false),
                    DaysToHarvest = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    FallPlant = table.Column<bool>(nullable: true),
                    Heirloom = table.Column<bool>(nullable: true),
                    Organic = table.Column<bool>(nullable: true),
                    SpecialCharacteristics = table.Column<string>(nullable: true),
                    SpringPlant = table.Column<bool>(nullable: true),
                    SupplierName = table.Column<string>(nullable: true),
                    VarietyName = table.Column<string>(nullable: true),
                    VegId = table.Column<int>(nullable: false),
                    YearPacked = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VegVarieties", x => x.VarietyId);
                    table.ForeignKey(
                        name: "FK_VegVarieties_Vegtables_VegId",
                        column: x => x.VegId,
                        principalTable: "Vegtables",
                        principalColumn: "VegId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VegVarieties_VegId",
                table: "VegVarieties",
                column: "VegId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VegVarieties");

            migrationBuilder.DropTable(
                name: "Vegtables");
        }
    }
}
