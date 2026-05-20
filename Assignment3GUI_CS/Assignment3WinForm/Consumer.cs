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

        private bool continueLoad;

        public Consumer(Storage storage,ListBox listBox,int maxLoad,bool continueLoad)
        {
            this.storage = storage;
            this.listBox = listBox;
            this.maxLoad = maxLoad;
            this.continueLoad = continueLoad;
        }

        public void Stop()
        {
            running = false;
        }

        public void Run()
        {
            while (running)
            {
                // Stop only if max load reached AND continue load is off
                if (maxLoad <= 0 && !continueLoad)
                {
                    break;
                }

                Product p = storage.Consume();

                listBox.Invoke((MethodInvoker)(() => // Add the consumed product to the list box
                {
                    listBox.Items.Add(p.ToString()); 
                }));

                // Only decrease if not continue load, otherwise we want to keep consuming even if max load is reached
                if (!continueLoad)
                {
                    maxLoad--;
                }
                Thread.Sleep(1500);
            }
        }
    }
    }