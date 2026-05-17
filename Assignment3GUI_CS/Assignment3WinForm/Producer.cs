using System;
using System.Collections.Generic;
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

        private Random random = new Random();

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
                int index = random.Next(products.Length); // Randomly select a product from the array

                Product p = products[index]; // Get the selected product

                storage.Produce(p); // Add the product to the storage

                Thread.Sleep(1000);
            }
        }
    }
}
