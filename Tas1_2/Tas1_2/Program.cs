using System;
using System.Collections.Generic;

namespace Tas1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var homeProductType = new ProductType("Home & Beauty");
            var accessoriesProductType = new ProductType("Accessories");
            var photoVideoEquipmentsProductType = new ProductType("Photos & Videos Equipment");

            var highResolution  = new ResolutionInfo("High Resolution");
            var veryHighResolution = new ResolutionInfo("Very High Resolution");

            var catalog = new List<ProductBase>
            {
                new Camera(
                    "Nikon Camera", 
                    1, 
                    200,
                    200, 
                    "Best Camera in the Market 2020",
                    photoVideoEquipmentsProductType, 
                    24, 
                    "new Diaphram",
                    highResolution),
                new PhotoPrinter(
                    "Philips Photo Printer V12",
                    1200,
                    5,
                    208,
                    "Photo Printer Works absoutely Fast",
                    accessoriesProductType,
                    "With New Cartridge",
                    120,
                    "Good ",
                    veryHighResolution
                    ),
                new Router("D-Link-Router",
                    1200,
                    2,
                    400,
                    "the best Router since 2007",
                    photoVideoEquipmentsProductType,
                    "50Hz",
                    75,
                    "Good Standards",
                    "Blue",
                    "Safe Security Protocol"),
                new Iron(
                    "Beko Iron",
                    110,
                    91,
                    70,
                    "High Quality Iron",
                    homeProductType)
            };
            var cart = new List<ProductBase>();

            Console.WriteLine("Welcome in Products catalog.");

            Console.WriteLine("Id\tName\tWeight\tPrice\tType\tQuantity In Stock\tSensitivity\tMega Pixels\tDiaphragm\tVideo Resolution");
            Console.WriteLine("----\t------\t--------\t------\t-----------\t--------------\t------------\t------------------\t--------------");

            // display catalog. it doesnot work //
            catalog.DisplayToConsole();
        }
    }
}
