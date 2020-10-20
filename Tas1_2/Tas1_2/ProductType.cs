using System;
using System.Collections.Generic;
using System.Text;

namespace Tas1_2
{
    class ProductType
    {
        private readonly string name;
        public ProductType(string typeName)
        {
            this.name = typeName;
        }

        public string GetType() => name;
    }
}
