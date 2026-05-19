using System.Threading;
using System.Windows.Forms;

namespace Assignment3WinForm
{
    public class Consumer
    {
        private Storage storage;

        private bool running = true;

        private ListBox listBox;

        public Consumer(Storage storage, ListBox listBox)
        {
            this.storage = storage;
            this.listBox = listBox; // Store the ListBox reference for GUI updates
        }

        public void Stop()
        {
            running = false;
        }

        public void Run()
        {
            while (running)
            {
                Product p = storage.Consume(); // Consume a product from storage

                listBox.Invoke((MethodInvoker)(() => // Update the ListBox with the consumed product
                {
                    listBox.Items.Add(p.ToString()); // Add the consumed product to the ListBox
                })); // Update the ListBox on the GUI thread    

                Thread.Sleep(1500);
            }
        }
    }
}