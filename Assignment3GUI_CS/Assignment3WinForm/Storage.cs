using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3WinForm
{
    using System.Threading;

    public class Storage
    {
        private const int BufferSize = 30;

        private Product[] buffer = new Product[BufferSize]; 

        private int inPos = 0;
        private int outPos = 0;
        private int count = 0;

        private Semaphore empty;
        private Semaphore full;

        private Mutex mutex;

        public Storage()
        {
            empty = new Semaphore(BufferSize, BufferSize);
            full = new Semaphore(0, BufferSize);

            mutex = new Mutex();
        }

        public void Produce(Product item)
        {
            empty.WaitOne(); // Wait for an empty slot

            mutex.WaitOne(); // Enter critical section

            buffer[inPos] = item; // Place the item in the buffer
            inPos = (inPos + 1) % BufferSize; // Move to the next position 
            count++;

            mutex.ReleaseMutex(); // Exit critical section

            full.Release();
        }

        public Product Consume()
        {
            full.WaitOne(); // Wait for a full slot

            mutex.WaitOne(); // Enter critical section

            Product item = buffer[outPos]; // Retrieve the item from the buffer

            outPos = (outPos + 1) % BufferSize;
            count--;

            mutex.ReleaseMutex(); // Exit critical section

            empty.Release(); // Signal that an empty slot is available

            return item;
        }

        public int Count
        {
            get { return count; }
        }
    }
}
