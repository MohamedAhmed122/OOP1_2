using System;
using System.Collections.Generic;
using System.Text;

namespace Tas1_2
{
    class ProductBase
    {
        private readonly string Name;
        private readonly float Weight;
        private readonly string Description;
        private readonly int QuantityInStock;
        private readonly float Price;
        private readonly ProductType Type;

        public ProductBase() { }

        public ProductBase(string name, float price, float weight, int quantity, string description, ProductType type )
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
            this.Weight = weight;
            this.QuantityInStock = quantity;
            this.Description = description;
        }

        public virtual void DisplayToConsole() => Console.Write($"\tName: {Name}\tWeight: {Weight}\tPrice: {Price}\tType: {Type.GetType()}\tQuantity: {QuantityInStock}");

        public string GetName() => this.Name;
        public float GetPrice() => this.Price;
       
        public int GetQuantity() => this.QuantityInStock;

        public float GetWeight() => this.Weight;

        public new string GetType() => this.Type.GetType();
    }
}
