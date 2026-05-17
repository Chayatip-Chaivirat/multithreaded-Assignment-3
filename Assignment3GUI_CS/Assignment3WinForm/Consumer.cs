using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3WinForm
{
    public class Consumer
    {
        private Storage storage;

        private bool running = true;

        public Consumer(Storage storage)
        {
            this.storage = storage;
        }

        public void Stop()
        {
            running = false;
        }

        public void Run()
        {
            while (running)
            {
                Product p = storage.Consume(); // Retrieve a product from the storage

                Thread.Sleep(1500);
            }
        }
    }
}
