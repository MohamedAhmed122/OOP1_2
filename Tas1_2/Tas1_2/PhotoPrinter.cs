using System;
using System.Collections.Generic;
using System.Text;

namespace Tas1_2
{
    class PhotoPrinter : ProductBase
    {
        private readonly string PrintFormat;
        private readonly int PrintingTime;
        private readonly ResolutionInfo Resolution;
        private readonly string Cartridge;
        

        public PhotoPrinter(string name, float price, float weight, int quantity, string description, 
            ProductType type,string cartridge ,int printingTime, string printFormat, ResolutionInfo resolution)
            : base(name, price, weight, quantity, description, type)
        {
            this.Cartridge = cartridge;
            this.PrintFormat = printFormat;
            this.PrintingTime = printingTime;
            this.Resolution = resolution;
        }

        public override void DisplayToConsole()
        {
            base.DisplayToConsole();
            Console.Write($"\tPrint Format: {PrintFormat}\tPrinting Time: {PrintingTime}\tCartridge: {Cartridge}\n");
        }
    }
  
}
