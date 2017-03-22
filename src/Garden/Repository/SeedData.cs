using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
//using Microsoft.AspNetCore.Identity;
using Garden.Models;
using Garden.Repository;

namespace Garden.Repository
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            GardenDbContext context = app.ApplicationServices.GetRequiredService<GardenDbContext>();

            if (!context.Vegtables.Any())
            {
                Vegtable veg = new Vegtable
                {
                    VegName = "Cucumber", VegFamily = "Cucurbits", FullSun = true,SeedDepth = 1m,SeedSpacing = 10m,
                    ThinTo = 10, PlantsPerFt = 2,RowDistance = 4,IndoorSow = "4 wks before frost",
                    Transplant = "2 wks after last frost",InsectProbblems = "Aphids,cabbage looper,beetle,cutworm",
                    DiseaseProblems = "leaf spot,fungi,wilt,downy mildew",FertilizerNeeds = "10-10-10",
                    DaysGerminationMin = 3,
                    DaysGerminationMax = 10,
                };
                context.Vegtables.Add(veg);
                VegVariety vart = new VegVariety
                {
                    VarietyName = "Japanese Climbing", SupplierName = "Seed Savers", YearPacked = 2017,
                    Description = "Tender, crisp 9 in fruit", SpecialCharacteristics = "Excellent for trellis, slicing and pickling",
                     DaysToHarvest = 58, SpringPlant = true, FallPlant = false,
                    Organic = true, Heirloom = true, 
                };
                vart.VegType = veg;
                context.VegVarieties.Add(vart);

                veg = new Vegtable
                {
                    VegName = "Carrot", VegFamily = "Umbelifers",FullSun = false, SeedDepth = .25m,
                    SeedSpacing = .5m,ThinTo = 2, PlantsPerFt = 16,RowDistance = 16, IndoorSow = "Not adviced",
                    Transplant = "3-4 wks before spring frost",InsectProbblems = "Aphids,Carrot Rust Fly, Weevil, Flea Beetle",
                    DiseaseProblems = "Leaf Blight,Black rot", FertilizerNeeds = "0-10-10",
                    DaysGerminationMin = 7,
                    DaysGerminationMax = 21,
                    Notes = "Row covers can help with germination"
                };
                context.Vegtables.Add(veg);
                vart = new VegVariety
                {
                    VarietyName = "Dragon", SupplierName = "Seed Savers",YearPacked = 2017,
                    Description = "Red-purple exterior yellow-orange inside, spicy flavor",
                    SpecialCharacteristics = "Can survive mellow winters",
                     DaysToHarvest = 90,
                    SpringPlant = true,FallPlant = true, Organic = false,Heirloom = false,
                };
                vart.VegType = veg;
                context.VegVarieties.Add(vart);

                veg = new Vegtable
                {
                    VegName = "Lettuce",
                    VegFamily = "Daisy(Asteraceae)",
                    FullSun = false,
                    SeedDepth = .25m,
                    SeedSpacing = 1m,
                    ThinTo = 6,
                    PlantsPerFt = 4,
                    RowDistance = 16,
                    DaysGerminationMin = 2,
                    DaysGerminationMax = 12,
                    IndoorSow = "Continuously",
                    Transplant = "Through spring and in fall",
                    InsectProbblems = "Slug, Earwig",
                    DiseaseProblems = "Bottom rot,Downy Mildew,Scab",
                    FertilizerNeeds = "10-10-10",
                    Notes = "Best grown in cooler weather."
                };
                context.Vegtables.Add(veg);
                vart = new VegVariety
                {
                    VarietyName = "Baquieu",
                    SupplierName = "Seed Savers",
                    YearPacked = 2017,
                    Description = "French head lettuce with wavy green leaves tinged with maroon.",
                    SpecialCharacteristics = "Good for an early or late crop.",
                    
                    DaysToHarvest = 50,
                    SpringPlant = true,
                    FallPlant = true,
                    Organic = true,
                    Heirloom = false,
                };
                vart.VegType = veg;
                context.VegVarieties.Add(vart);


                context.SaveChanges();
            }
        }
    }
}
