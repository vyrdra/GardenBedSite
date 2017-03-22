using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Garden.Repository;

namespace Garden.Migrations
{
    [DbContext(typeof(GardenDbContext))]
    partial class GardenDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Garden.Models.GardenBed", b =>
                {
                    b.Property<int>("GardenBedID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BedDescription");

                    b.Property<int>("BedLength");

                    b.Property<string>("BedLocation");

                    b.Property<string>("BedName");

                    b.Property<int>("BedWidth");

                    b.Property<string>("BedZone");

                    b.Property<int>("HoursOfSun");

                    b.HasKey("GardenBedID");

                    b.ToTable("GardenBeds");
                });

            modelBuilder.Entity("Garden.Models.Vegtable", b =>
                {
                    b.Property<int>("VegId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DaysGerminationMax");

                    b.Property<int>("DaysGerminationMin");

                    b.Property<string>("DiseaseProblems");

                    b.Property<string>("FertilizerNeeds");

                    b.Property<bool>("FullSun");

                    b.Property<int?>("GardenBedID");

                    b.Property<string>("IndoorSow");

                    b.Property<string>("InsectProbblems");

                    b.Property<string>("Notes");

                    b.Property<int>("PlantsPerFt");

                    b.Property<int>("RowDistance");

                    b.Property<decimal>("SeedDepth");

                    b.Property<decimal>("SeedSpacing");

                    b.Property<int>("SoilTemp");

                    b.Property<int>("ThinTo");

                    b.Property<string>("Transplant");

                    b.Property<string>("VegFamily");

                    b.Property<string>("VegName")
                        .IsRequired();

                    b.HasKey("VegId");

                    b.HasIndex("GardenBedID");

                    b.ToTable("Vegtables");
                });

            modelBuilder.Entity("Garden.Models.VegVariety", b =>
                {
                    b.Property<int>("VarietyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DaysToHarvest");

                    b.Property<string>("Description");

                    b.Property<bool?>("FallPlant");

                    b.Property<bool?>("Heirloom");

                    b.Property<bool?>("Organic");

                    b.Property<string>("SpecialCharacteristics");

                    b.Property<bool?>("SpringPlant");

                    b.Property<string>("SupplierName");

                    b.Property<string>("VarietyName")
                        .IsRequired();

                    b.Property<int>("VegId");

                    b.Property<int>("YearPacked");

                    b.HasKey("VarietyId");

                    b.HasIndex("VegId");

                    b.ToTable("VegVarieties");
                });

            modelBuilder.Entity("Garden.Models.Vegtable", b =>
                {
                    b.HasOne("Garden.Models.GardenBed")
                        .WithMany("Vegtables")
                        .HasForeignKey("GardenBedID");
                });

            modelBuilder.Entity("Garden.Models.VegVariety", b =>
                {
                    b.HasOne("Garden.Models.Vegtable", "VegType")
                        .WithMany("Varietys")
                        .HasForeignKey("VegId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
