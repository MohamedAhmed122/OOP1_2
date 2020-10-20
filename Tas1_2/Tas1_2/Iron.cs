using System;
using System.Collections.Generic;
using System.Text;

namespace Tas1_2
{
    class Iron : ProductBase
    {
        public Iron(string name, float price, float weight, int quantity, string description, ProductType type)
            : base(name, price, weight, quantity, description, type)
        {

        }
    }
}
