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
                Product p = storage.Consume();

                listBox.Invoke((MethodInvoker)(() =>
                {
                    listBox.Items.Add(p.ToString());
                })); // Update the ListBox on the GUI thread    

                Thread.Sleep(1500);
            }
        }
    }
}