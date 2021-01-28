using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Laptop";
            product1.UnitPrice = 5000;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "Telephone",
                UnitPrice = 2000

            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}
