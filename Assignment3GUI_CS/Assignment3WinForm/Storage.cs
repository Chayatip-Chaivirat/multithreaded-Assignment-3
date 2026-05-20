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

        private Product[] buffer = new Product[BufferSize];  // Buffer to hold products

        private int inPos = 0; // Position for the next produced item
        private int outPos = 0; // Position for the next consumed item
        private int count = 0; // Count of items currently in the buffer

        private Semaphore empty; // Semaphore to track empty slots in the buffer
        private Semaphore full; // Semaphore to track full slots in the buffer

        private Mutex mutex; // Mutex to protect access to the buffer and count

        private static readonly object lockObj = new object(); // Lock object for synchronizing access to count

        public Storage()
        {
            empty = new Semaphore(BufferSize, BufferSize); // Initialize the empty semaphore with the buffer size, indicating all slots are initially empty
            full = new Semaphore(0, BufferSize); // Initialize the full semaphore with 0, indicating no items are initially produced

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
            get
            {
                mutex.WaitOne(); // Enter critical section to safely read the count
                int current = count; // Store the current count in a local variable
                mutex.ReleaseMutex(); // Exit critical section

                return current; // Return the current count of items in the buffer
            }
        }

        public int MaxCapacity
        {
            get { return BufferSize; }
        }
    }
}
