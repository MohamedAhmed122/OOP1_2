using System;
using System.Collections.Generic;
using System.Text;

namespace Tas1_2
{
    class AirConditioning : ProductBase
    {
        public AirConditioning(string name, float price, float weight, int quantity, string description, ProductType type)
           : base(name, price, weight, quantity, description, type)
        {

        }
    }
}
