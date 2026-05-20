using System;

namespace Assignment3WinForm
{
    public enum CategoryType
    {
        Food,
        Electrics,
        Tools
    }

    public class Product
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public int Pieces { get; set; }
        public CategoryType Category { get; set; }

        // Constructor
        public Product(string name,double weight,double price,int pieces,CategoryType category)
        {
            Name = name;
            Weight = weight;
            Price = price;
            Pieces = pieces;
            Category = category;
        }

        public override string ToString()// Override ToString to provide a string representation of the product
        {
            return $"{Name} - {Price}";
        }

        // Static method to create products
        public static Product[] CreateTestProducts()
        {
            const int max = 50;

            Product[] itemArray = new Product[max]; // Create an array of products with a maximum size of 50

            for (int i = 0; i < 5; i++)
            {
                int j = i * 10;

                itemArray[0 + j] = new Product("Milk, Gen Food " + (i + 1).ToString(), 1.0, 17.95, 6, CategoryType.Food);

                itemArray[1 + j] = new Product("Egg, organic " + (i + 1).ToString(), 5.0, 60.55, 20, CategoryType.Food);

                itemArray[2 + j] =new Product("Dish Washer " + (i + 1).ToString(),15, 5990, 1, CategoryType.Electrics);

                itemArray[3 + j] =new Product("Shaving machine " + (i + 1).ToString(),200, 750, 2, CategoryType.Electrics);

                itemArray[4 + j] =new Product("Screwdriver machine " + (i + 1).ToString(),780, 459, 3, CategoryType.Tools);

                itemArray[5 + j] =new Product("Tigersaw " + (i + 1).ToString(),450, 2000, 3, CategoryType.Tools);

                itemArray[6 + j] =new Product("Milk, Gen Food " + (i + 1).ToString(),1.0, 19.85, 6, CategoryType.Food);

                itemArray[7 + j] =new Product("Egg Gen Food " + (i + 1).ToString(),5.0, 60.55, 20, CategoryType.Food);

                itemArray[8 + j] =new Product("Dish Washer, Global El " + (i + 1).ToString(),15, 5990, 1, CategoryType.Electrics);

                itemArray[9 + j] =new Product("Shaving machine, Home Tools " + (i + 1).ToString(),220, 750, 2, CategoryType.Electrics);
            }

            return itemArray;
        }
    }
}