using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3WinForm
{
    public class Producer
    {
        private Storage storage;
        private Product[] products;

        private bool running = true;

        private static Random random = new Random(); // Static Random instance to avoid issues with multiple producers creating their own Random instances

        public Producer(Storage storage, Product[] products)
        {
            this.storage = storage;
            this.products = products;
        }

        public void Stop()
        {
            running = false;
        }

        public void Run()
        {
            while (running)
            {
                int index = random.Next(products.Length); // Get a random index for the products array

                Product p = products[index]; // Select a random product from the array

                storage.Produce(p); // Add the product to the storage

                Debug.WriteLine($"Produced: {p}");

                Thread.Sleep(1000);
            }
        }
    }
}
