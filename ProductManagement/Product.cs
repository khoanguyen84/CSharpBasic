using System;
namespace ProductManagement
{
    class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int[] Rate { get; set; }

        public Product(string Name, string Description, double Price)
        {
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
        }

        public void ViewInfo(){
            Console.WriteLine($"{this.Name}\t{this.Description}\t{this.Price}");
        }
    }
}