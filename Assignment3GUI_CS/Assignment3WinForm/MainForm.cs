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

    }

    /// <summary>
    /// Start producer 2
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStartElProducts_Click(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Start  producer 3
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStartFoodProducts_Click(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Stop  producer´1
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStopGenProduct_Click(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Stop  producer 2
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStopElProducts_Click(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Stop producer 3
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStopFoodProducts_Click(object sender, EventArgs e)
    {
    }
    /// <summary>
    /// Start consumer 1
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStartGen_Click(object sender, EventArgs e)
    {

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



    }

    /// <summary>
    /// Start  consumer 2
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStartCoop_Click(object sender, EventArgs e)
    {

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
      }

    /// <summary>
    /// Start consumer 3
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStartFoods_Click(object sender, EventArgs e)
    {


    }

    /// <summary>
    /// Stop thread 3
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStopFoods_Click(object sender, EventArgs e)
    {

    }
}
