using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Assignment3WinForm;

public partial class MainForm : Form
{
    private Storage storage;

    private Producer producer1;
    private Producer producer2;
    private Producer producer3;

    private Consumer consumer1;
    private Consumer consumer2;
    private Consumer consumer3;

    // Producer threads
    private Thread pThread1;
    private Thread pThread2;
    private Thread pThread3;

    // Consumer threads
    private Thread cThread1;
    private Thread cThread2;
    private Thread cThread3;

    // Product array to be used by producers
    private Product[] itemArray;

    /// <summary>
    /// Constructor.
    /// </summary>
    public MainForm()
    {
        InitializeComponent();

        storage = new Storage(); // Create a new storage instance
        itemArray = Product.CreateTestProducts(); // Initialize the product array
    }

    /// <summary>
    /// Start  producer 1
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStartGenProd_Click(object sender, EventArgs e)
    {
        // Prevent multiple starts
        if (pThread1 == null || !pThread1.IsAlive)
        {
            producer1 = new Producer(storage, itemArray); // Create a new producer instance with the storage and product array

            pThread1 = new Thread(producer1.Run); // Create a new thread for the producer's Run method

            pThread1.Start();

            MessageBox.Show("Producer 1 started");
        }
    }

    /// <summary>
    /// Start producer 2
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStartElProducts_Click(object sender, EventArgs e)
    {
        if (pThread2 == null || !pThread2.IsAlive)
        {
            producer2 = new Producer(storage, itemArray);
            pThread2 = new Thread(producer2.Run);
            pThread2.Start();
            MessageBox.Show("Producer 2 started");
        }   
    }

    /// <summary>
    /// Start  producer 3
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStartFoodProducts_Click(object sender, EventArgs e)
    {
        if (pThread3 == null || !pThread3.IsAlive)
        {
            producer3 = new Producer(storage, itemArray);
            pThread3 = new Thread(producer3.Run);
            pThread3.Start();
            MessageBox.Show("Producer 3 started");
        }
    }

    /// <summary>
    /// Stop  producer´1
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStopGenProduct_Click(object sender, EventArgs e)
    {
        producer1?.Stop(); // if producer1 is not null, call the Stop method to signal the thread to stop

        MessageBox.Show("Producer 1 stopped");
    }

    /// <summary>
    /// Stop  producer 2
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStopElProducts_Click(object sender, EventArgs e)
    {
        producer2?.Stop(); // if producer2 is not null, call the Stop method to signal the thread to stop
        MessageBox.Show("Producer 2 stopped");
    }

    /// <summary>
    /// Stop producer 3
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStopFoodProducts_Click(object sender, EventArgs e)
    {
        producer3?.Stop(); // if producer3 is not null, call the Stop method to signal the thread to stop
        MessageBox.Show("Producer 3 stopped");
    }
    /// <summary>
    /// Start consumer 1
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStartGen_Click(object sender, EventArgs e)
    {
        if (cThread1 == null || !cThread1.IsAlive)
        {
            consumer1 = new Consumer(storage);

            cThread1 = new Thread(consumer1.Run);

            cThread1.Start();

            MessageBox.Show("Consumer 1 started");
        }
    }

    /// <summary>
    /// Stop thread 1
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStopGen_Click(object sender, EventArgs e)
    {

        //Use the following patter to invoke updating of a control by other threads
        //lblIcaStatus.Invoke((MethodInvoker)(() => lblIcaStatus.Text = 
        //xxThread.IsAlive ? "alive" : "dead"));
        consumer1?.Stop();

        MessageBox.Show("Consumer 1 stopped");


    }

    /// <summary>
    /// Start  consumer 2
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStartCoop_Click(object sender, EventArgs e)
    {
        if (cThread2 == null || !cThread2.IsAlive)
        {
            consumer2 = new Consumer(storage);
            cThread2 = new Thread(consumer2.Run);
            cThread2.Start();
            MessageBox.Show("Consumer 2 started");
        }
    }

    private void lstIca_SelectedIndexChanged(object sender, EventArgs e)
    {
       // lblIcaStatus.Invoke((MethodInvoker)(() => 
        //lblIcaStatus.Text = xxThread.IsAlive ? "alive" : "dead"));

    }

    /// <summary>
    /// Stop  thread 2
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStopCoop_Click(object sender, EventArgs e)
    {
        consumer2?.Stop();
        MessageBox.Show("Consumer 2 stopped");
    }

    /// <summary>
    /// Start consumer 3
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStartFoods_Click(object sender, EventArgs e)
    {
        if (cThread3 == null || !cThread3.IsAlive)
        {
            consumer3 = new Consumer(storage);
            cThread3 = new Thread(consumer3.Run);
            cThread3.Start();
            MessageBox.Show("Consumer 3 started");
        }
    }

    /// <summary>
    /// Stop thread 3
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStopFoods_Click(object sender, EventArgs e)
    {
        consumer3?.Stop();
        MessageBox.Show("Consumer 3 stopped");
    }
}
