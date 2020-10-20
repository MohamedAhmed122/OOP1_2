using System;
using System.Collections.Generic;
using System.Text;

namespace Tas1_2
{
    class Router : ProductBase
    {
        private readonly string Frequency;
        private readonly string Standards;
        private readonly int LanPortsCount;
        private readonly string SecurityProtocol;
        private readonly string Color;

        public Router(string name, float price, float weight, int quantity, string description,
            ProductType type, string frequency, int lanPortsCount, string standards,
            string color, string securityProtocol
            )
            : base(name, price, weight, quantity, description, type)
        {
            this.SecurityProtocol = securityProtocol;
            this.Standards = standards;
            this.SecurityProtocol = securityProtocol;
            this.Color = color;
            this.LanPortsCount = lanPortsCount;
            this.Frequency = frequency;
        }
        public override void DisplayToConsole() =>
            Console.Write($"\tStandards: {Standards}\tLan Ports: {LanPortsCount}\tSecurity Protocol: {SecurityProtocol}\tFrequency: {Frequency}\tColor: {Color}\n");
    }
}
