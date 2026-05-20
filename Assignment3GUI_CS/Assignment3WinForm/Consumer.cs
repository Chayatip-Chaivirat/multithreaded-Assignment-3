using System.Threading;
using System.Windows.Forms;

namespace Assignment3WinForm
{
    public class Consumer
    {
        private Storage storage;

        private bool running = true;

        private ListBox listBox;

        private int maxLoad;   

        public Consumer(Storage storage, ListBox listBox, int maxLoad)
        {
            this.storage = storage;
            this.listBox = listBox; // Store the ListBox reference for GUI updates
            this.maxLoad = maxLoad;
        }

        public void Stop()
        {
            running = false;
        }

        public void Run()
        {
            while (running)
            {
                if (maxLoad <= 0) // Check if the maximum load has been reached
                {
                    break; // Exit the loop if the maximum load is exceeded
                }
                else // If the maximum load is not exceeded, consume a product from storage
                {
                    Product p = storage.Consume(); // Consume a product from storage
                    listBox.Invoke((MethodInvoker)(() => // Update the ListBox with the consumed product
                    {
                        listBox.Items.Add(p.ToString()); // Add the consumed product to the ListBox

                    })); // Update the ListBox on the GUI thread    
                    maxLoad--; // Decrease the maximum load
                }
            }

                Thread.Sleep(1500);
            }
        }
    }