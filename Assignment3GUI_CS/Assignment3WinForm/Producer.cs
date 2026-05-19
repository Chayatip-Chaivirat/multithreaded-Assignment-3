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
                int index = random.Next(products.Length);

                Product p = products[index];

                storage.Produce(p);

                Console.WriteLine($"Produced: {p}");

                Thread.Sleep(1000);
            }
        }
    }
}
