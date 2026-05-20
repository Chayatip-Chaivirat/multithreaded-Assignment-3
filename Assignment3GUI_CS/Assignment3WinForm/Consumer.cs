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
            int currentLoad = 0;

            while (running)
            {
                Product p = storage.Consume();

                listBox.Invoke((MethodInvoker)(() =>
                {
                    listBox.Items.Add(p.ToString());
                }));

                currentLoad++;

                // Truck full
                if (currentLoad >= maxLoad)
                {
                    // Wait configured interval
                    Thread.Sleep(1500);

                    // Stop loading if Continue load is OFF
                    if (!continueLoad)
                    {
                        break;
                    }

                    // Continue load ON:
                    // clear truck and load again
                    listBox.Invoke((MethodInvoker)(() =>
                    {
                        listBox.Items.Clear();
                    }));

                    currentLoad = 0;
                }
            }
        }
    }
    }