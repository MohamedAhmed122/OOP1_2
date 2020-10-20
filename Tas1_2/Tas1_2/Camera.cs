using System;
using System.Collections.Generic;
using System.Text;

namespace Tas1_2
{
    class Camera : ProductBase
    {
        private readonly int Sensitivity;
        private readonly string Diaphragm;
        private readonly ResolutionInfo Resolution;
        private string v1;
        private int v2;
        private int v3;
        private string v4;
        private ProductType photoVideoEquipmentsProductType;
        private int v5;
        private string v6;
        private string v7;

        public Camera(string v1, int v2, int v3, string v4, ProductType photoVideoEquipmentsProductType, int v5, string v6, string v7)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.photoVideoEquipmentsProductType = photoVideoEquipmentsProductType;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
        }

        public Camera(string name, float price, float weight, int quantity, string description, ProductType type,
            int sensitivity, string diaphragm, ResolutionInfo resolution)
            :base(name, price,weight, quantity, description, type)
        {
            this.Sensitivity = sensitivity;
            this.Diaphragm = diaphragm;
            this.Resolution = resolution;
        }

        public override void DisplayToConsole()
        {
            base.DisplayToConsole();
            Console.Write($"\tSensitivity: {Sensitivity}\tDiaphragm: {Diaphragm}\n");
        }
    }
}
