namespace Assignment3WinForm;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        groupBox1 = new GroupBox();
        groupBox6 = new GroupBox();
        btnStopAxfood = new Button();
        btnStartAxfood = new Button();
        lblStatusAxfood = new Label();
        label7 = new Label();
        groupBox5 = new GroupBox();
        btnStopArla = new Button();
        btnStartArla = new Button();
        lblStatusArla = new Label();
        label5 = new Label();
        groupBox4 = new GroupBox();
        btnStopScan = new Button();
        btnStartScan = new Button();
        lblStatusScan = new Label();
        label2 = new Label();
        groupBox2 = new GroupBox();
        groupBox11 = new GroupBox();
        lblItems3 = new Label();
        lstFood = new ListBox();
        btnStopCity = new Button();
        btnStartCity = new Button();
        chkCityCont = new CheckBox();
        label16 = new Label();
        lblCityStatus = new Label();
        groupBox9 = new GroupBox();
        lblItems2 = new Label();
        lstCoop = new ListBox();
        btnStopCoop = new Button();
        btnStartCoop = new Button();
        chkCoopCont = new CheckBox();
        label8 = new Label();
        lblCoopStatus = new Label();
        groupBox7 = new GroupBox();
        lblItems1 = new Label();
        lstGen = new ListBox();
        btnStopIca = new Button();
        btnStartIca = new Button();
        chkIcaCont = new CheckBox();
        label6 = new Label();
        lblIcaStatus = new Label();
        groupBox3 = new GroupBox();
        lblItemsProduced = new Label();
        progressItems = new ProgressBar();
        lblMax = new Label();
        groupBox1.SuspendLayout();
        groupBox6.SuspendLayout();
        groupBox5.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox11.SuspendLayout();
        groupBox9.SuspendLayout();
        groupBox7.SuspendLayout();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(groupBox6);
        groupBox1.Controls.Add(groupBox5);
        groupBox1.Controls.Add(groupBox4);
        groupBox1.Location = new Point(23, 28);
        groupBox1.Margin = new Padding(6, 7, 6, 7);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(6, 7, 6, 7);
        groupBox1.Size = new Size(419, 816);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Producers";
        // 
        // groupBox6
        // 
        groupBox6.Controls.Add(btnStopAxfood);
        groupBox6.Controls.Add(btnStartAxfood);
        groupBox6.Controls.Add(lblStatusAxfood);
        groupBox6.Controls.Add(label7);
        groupBox6.Location = new Point(11, 564);
        groupBox6.Margin = new Padding(6, 7, 6, 7);
        groupBox6.Name = "groupBox6";
        groupBox6.Padding = new Padding(6, 7, 6, 7);
        groupBox6.Size = new Size(397, 215);
        groupBox6.TabIndex = 2;
        groupBox6.TabStop = false;
        groupBox6.Text = "Int Equipments";
        // 
        // btnStopAxfood
        // 
        btnStopAxfood.Enabled = false;
        btnStopAxfood.Location = new Point(274, 124);
        btnStopAxfood.Margin = new Padding(6, 7, 6, 7);
        btnStopAxfood.Name = "btnStopAxfood";
        btnStopAxfood.Size = new Size(88, 49);
        btnStopAxfood.TabIndex = 3;
        btnStopAxfood.Text = "Stop";
        btnStopAxfood.UseVisualStyleBackColor = true;
        btnStopAxfood.Click += btnStopFoodProducts_Click;
        // 
        // btnStartAxfood
        // 
        btnStartAxfood.Location = new Point(54, 128);
        btnStartAxfood.Margin = new Padding(6, 7, 6, 7);
        btnStartAxfood.Name = "btnStartAxfood";
        btnStartAxfood.Size = new Size(182, 49);
        btnStartAxfood.TabIndex = 2;
        btnStartAxfood.Text = "Start Producing";
        btnStartAxfood.UseVisualStyleBackColor = true;
        btnStartAxfood.Click += btnStartFoodProducts_Click;
        // 
        // lblStatusAxfood
        // 
        lblStatusAxfood.AutoSize = true;
        lblStatusAxfood.Location = new Point(147, 66);
        lblStatusAxfood.Margin = new Padding(6, 0, 6, 0);
        lblStatusAxfood.Name = "lblStatusAxfood";
        lblStatusAxfood.Size = new Size(168, 28);
        lblStatusAxfood.TabIndex = 1;
        lblStatusAxfood.Text = "NOT PRODUCING";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(78, 66);
        label7.Margin = new Padding(6, 0, 6, 0);
        label7.Name = "label7";
        label7.Size = new Size(69, 28);
        label7.TabIndex = 0;
        label7.Text = "Status:";
        // 
        // groupBox5
        // 
        groupBox5.Controls.Add(btnStopArla);
        groupBox5.Controls.Add(btnStartArla);
        groupBox5.Controls.Add(lblStatusArla);
        groupBox5.Controls.Add(label5);
        groupBox5.Location = new Point(11, 299);
        groupBox5.Margin = new Padding(6, 7, 6, 7);
        groupBox5.Name = "groupBox5";
        groupBox5.Padding = new Padding(6, 7, 6, 7);
        groupBox5.Size = new Size(397, 215);
        groupBox5.TabIndex = 1;
        groupBox5.TabStop = false;
        groupBox5.Text = "Home Electronics";
        // 
        // btnStopArla
        // 
        btnStopArla.Enabled = false;
        btnStopArla.Location = new Point(274, 124);
        btnStopArla.Margin = new Padding(6, 7, 6, 7);
        btnStopArla.Name = "btnStopArla";
        btnStopArla.Size = new Size(88, 49);
        btnStopArla.TabIndex = 3;
        btnStopArla.Text = "Stop";
        btnStopArla.UseVisualStyleBackColor = true;
        btnStopArla.Click += btnStopElProducts_Click;
        // 
        // btnStartArla
        // 
        btnStartArla.Location = new Point(54, 128);
        btnStartArla.Margin = new Padding(6, 7, 6, 7);
        btnStartArla.Name = "btnStartArla";
        btnStartArla.Size = new Size(182, 49);
        btnStartArla.TabIndex = 2;
        btnStartArla.Text = "Start Producing";
        btnStartArla.UseVisualStyleBackColor = true;
        btnStartArla.Click += btnStartElProducts_Click;
        // 
        // lblStatusArla
        // 
        lblStatusArla.AutoSize = true;
        lblStatusArla.Location = new Point(147, 66);
        lblStatusArla.Margin = new Padding(6, 0, 6, 0);
        lblStatusArla.Name = "lblStatusArla";
        lblStatusArla.Size = new Size(168, 28);
        lblStatusArla.TabIndex = 1;
        lblStatusArla.Text = "NOT PRODUCING";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(78, 66);
        label5.Margin = new Padding(6, 0, 6, 0);
        label5.Name = "label5";
        label5.Size = new Size(69, 28);
        label5.TabIndex = 0;
        label5.Text = "Status:";
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(btnStopScan);
        groupBox4.Controls.Add(btnStartScan);
        groupBox4.Controls.Add(lblStatusScan);
        groupBox4.Controls.Add(label2);
        groupBox4.Location = new Point(11, 40);
        groupBox4.Margin = new Padding(6, 7, 6, 7);
        groupBox4.Name = "groupBox4";
        groupBox4.Padding = new Padding(6, 7, 6, 7);
        groupBox4.Size = new Size(397, 215);
        groupBox4.TabIndex = 0;
        groupBox4.TabStop = false;
        groupBox4.Text = "Food Factory";
        // 
        // btnStopScan
        // 
        btnStopScan.Enabled = false;
        btnStopScan.Location = new Point(274, 124);
        btnStopScan.Margin = new Padding(6, 7, 6, 7);
        btnStopScan.Name = "btnStopScan";
        btnStopScan.Size = new Size(88, 49);
        btnStopScan.TabIndex = 3;
        btnStopScan.Text = "Stop";
        btnStopScan.UseVisualStyleBackColor = true;
        btnStopScan.Click += btnStopGenProduct_Click;
        // 
        // btnStartScan
        // 
        btnStartScan.Location = new Point(54, 128);
        btnStartScan.Margin = new Padding(6, 7, 6, 7);
        btnStartScan.Name = "btnStartScan";
        btnStartScan.Size = new Size(182, 49);
        btnStartScan.TabIndex = 2;
        btnStartScan.Text = "Start Producing";
        btnStartScan.UseVisualStyleBackColor = true;
        btnStartScan.Click += btnStartGenProd_Click;
        // 
        // lblStatusScan
        // 
        lblStatusScan.AutoSize = true;
        lblStatusScan.Location = new Point(147, 66);
        lblStatusScan.Margin = new Padding(6, 0, 6, 0);
        lblStatusScan.Name = "lblStatusScan";
        lblStatusScan.Size = new Size(168, 28);
        lblStatusScan.TabIndex = 1;
        lblStatusScan.Text = "NOT PRODUCING";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(78, 66);
        label2.Margin = new Padding(6, 0, 6, 0);
        label2.Name = "label2";
        label2.Size = new Size(69, 28);
        label2.TabIndex = 0;
        label2.Text = "Status:";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(groupBox11);
        groupBox2.Controls.Add(groupBox9);
        groupBox2.Controls.Add(groupBox7);
        groupBox2.Location = new Point(488, 28);
        groupBox2.Margin = new Padding(6, 7, 6, 7);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(6, 7, 6, 7);
        groupBox2.Size = new Size(752, 816);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Consumers";
        // 
        // groupBox11
        // 
        groupBox11.Controls.Add(lblItems3);
        groupBox11.Controls.Add(lstFood);
        groupBox11.Controls.Add(btnStopCity);
        groupBox11.Controls.Add(btnStartCity);
        groupBox11.Controls.Add(chkCityCont);
        groupBox11.Controls.Add(label16);
        groupBox11.Controls.Add(lblCityStatus);
        groupBox11.Location = new Point(34, 564);
        groupBox11.Margin = new Padding(6, 7, 6, 7);
        groupBox11.Name = "groupBox11";
        groupBox11.Padding = new Padding(6, 7, 6, 7);
        groupBox11.Size = new Size(705, 215);
        groupBox11.TabIndex = 2;
        groupBox11.TabStop = false;
        groupBox11.Text = "Food && tools";
        // 
        // lblItems3
        // 
        lblItems3.AutoSize = true;
        lblItems3.Location = new Point(221, 100);
        lblItems3.Margin = new Padding(4, 0, 4, 0);
        lblItems3.Name = "lblItems3";
        lblItems3.Size = new Size(59, 28);
        lblItems3.TabIndex = 10;
        lblItems3.Text = "items";
        lblItems3.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lstFood
        // 
        lstFood.FormattingEnabled = true;
        lstFood.ItemHeight = 28;
        lstFood.Location = new Point(286, 49);
        lstFood.Margin = new Padding(6, 7, 6, 7);
        lstFood.Name = "lstFood";
        lstFood.Size = new Size(407, 144);
        lstFood.TabIndex = 8;
        // 
        // btnStopCity
        // 
        btnStopCity.Enabled = false;
        btnStopCity.Location = new Point(204, 152);
        btnStopCity.Margin = new Padding(6, 7, 6, 7);
        btnStopCity.Name = "btnStopCity";
        btnStopCity.Size = new Size(73, 49);
        btnStopCity.TabIndex = 7;
        btnStopCity.Text = "Stop";
        btnStopCity.UseVisualStyleBackColor = true;
        btnStopCity.Click += btnStopFoods_Click;
        // 
        // btnStartCity
        // 
        btnStartCity.Location = new Point(14, 152);
        btnStartCity.Margin = new Padding(6, 7, 6, 7);
        btnStartCity.Name = "btnStartCity";
        btnStartCity.Size = new Size(148, 49);
        btnStartCity.TabIndex = 6;
        btnStartCity.Text = "Start Loading";
        btnStartCity.UseVisualStyleBackColor = true;
        btnStartCity.Click += btnStartFoods_Click;
        // 
        // chkCityCont
        // 
        chkCityCont.AutoSize = true;
        chkCityCont.Location = new Point(14, 98);
        chkCityCont.Margin = new Padding(6, 7, 6, 7);
        chkCityCont.Name = "chkCityCont";
        chkCityCont.Size = new Size(154, 32);
        chkCityCont.TabIndex = 5;
        chkCityCont.Text = "Continue load";
        chkCityCont.UseVisualStyleBackColor = true;
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(-1, 49);
        label16.Margin = new Padding(6, 0, 6, 0);
        label16.Name = "label16";
        label16.Size = new Size(69, 28);
        label16.TabIndex = 4;
        label16.Text = "Status:";
        // 
        // lblCityStatus
        // 
        lblCityStatus.AutoSize = true;
        lblCityStatus.Location = new Point(66, 49);
        lblCityStatus.Margin = new Padding(6, 0, 6, 0);
        lblCityStatus.Name = "lblCityStatus";
        lblCityStatus.Size = new Size(174, 28);
        lblCityStatus.TabIndex = 3;
        lblCityStatus.Text = "NOT CONSUMING";
        // 
        // groupBox9
        // 
        groupBox9.Controls.Add(lblItems2);
        groupBox9.Controls.Add(lstCoop);
        groupBox9.Controls.Add(btnStopCoop);
        groupBox9.Controls.Add(btnStartCoop);
        groupBox9.Controls.Add(chkCoopCont);
        groupBox9.Controls.Add(label8);
        groupBox9.Controls.Add(lblCoopStatus);
        groupBox9.Location = new Point(34, 299);
        groupBox9.Margin = new Padding(6, 7, 6, 7);
        groupBox9.Name = "groupBox9";
        groupBox9.Padding = new Padding(6, 7, 6, 7);
        groupBox9.Size = new Size(705, 215);
        groupBox9.TabIndex = 1;
        groupBox9.TabStop = false;
        groupBox9.Text = "Coop Market";
        // 
        // lblItems2
        // 
        lblItems2.AutoSize = true;
        lblItems2.Location = new Point(221, 102);
        lblItems2.Margin = new Padding(4, 0, 4, 0);
        lblItems2.Name = "lblItems2";
        lblItems2.Size = new Size(59, 28);
        lblItems2.TabIndex = 10;
        lblItems2.Text = "items";
        lblItems2.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lstCoop
        // 
        lstCoop.FormattingEnabled = true;
        lstCoop.ItemHeight = 28;
        lstCoop.Location = new Point(300, 49);
        lstCoop.Margin = new Padding(6, 7, 6, 7);
        lstCoop.Name = "lstCoop";
        lstCoop.Size = new Size(392, 144);
        lstCoop.TabIndex = 8;
        // 
        // btnStopCoop
        // 
        btnStopCoop.Enabled = false;
        btnStopCoop.Location = new Point(204, 152);
        btnStopCoop.Margin = new Padding(6, 7, 6, 7);
        btnStopCoop.Name = "btnStopCoop";
        btnStopCoop.Size = new Size(73, 49);
        btnStopCoop.TabIndex = 7;
        btnStopCoop.Text = "Stop";
        btnStopCoop.UseVisualStyleBackColor = true;
        btnStopCoop.Click += btnStopCoop_Click;
        // 
        // btnStartCoop
        // 
        btnStartCoop.Location = new Point(28, 152);
        btnStartCoop.Margin = new Padding(6, 7, 6, 7);
        btnStartCoop.Name = "btnStartCoop";
        btnStartCoop.Size = new Size(148, 49);
        btnStartCoop.TabIndex = 6;
        btnStartCoop.Text = "Start Loading";
        btnStartCoop.UseVisualStyleBackColor = true;
        btnStartCoop.Click += btnStartCoop_Click;
        // 
        // chkCoopCont
        // 
        chkCoopCont.AutoSize = true;
        chkCoopCont.Location = new Point(28, 98);
        chkCoopCont.Margin = new Padding(6, 7, 6, 7);
        chkCoopCont.Name = "chkCoopCont";
        chkCoopCont.Size = new Size(154, 32);
        chkCoopCont.TabIndex = 5;
        chkCoopCont.Text = "Continue load";
        chkCoopCont.UseVisualStyleBackColor = true;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(12, 49);
        label8.Margin = new Padding(6, 0, 6, 0);
        label8.Name = "label8";
        label8.Size = new Size(69, 28);
        label8.TabIndex = 4;
        label8.Text = "Status:";
        // 
        // lblCoopStatus
        // 
        lblCoopStatus.AutoSize = true;
        lblCoopStatus.Location = new Point(80, 49);
        lblCoopStatus.Margin = new Padding(6, 0, 6, 0);
        lblCoopStatus.Name = "lblCoopStatus";
        lblCoopStatus.Size = new Size(174, 28);
        lblCoopStatus.TabIndex = 3;
        lblCoopStatus.Text = "NOT CONSUMING";
        // 
        // groupBox7
        // 
        groupBox7.Controls.Add(lblItems1);
        groupBox7.Controls.Add(lstGen);
        groupBox7.Controls.Add(btnStopIca);
        groupBox7.Controls.Add(btnStartIca);
        groupBox7.Controls.Add(chkIcaCont);
        groupBox7.Controls.Add(label6);
        groupBox7.Controls.Add(lblIcaStatus);
        groupBox7.Location = new Point(34, 40);
        groupBox7.Margin = new Padding(6, 7, 6, 7);
        groupBox7.Name = "groupBox7";
        groupBox7.Padding = new Padding(6, 7, 6, 7);
        groupBox7.Size = new Size(705, 215);
        groupBox7.TabIndex = 0;
        groupBox7.TabStop = false;
        groupBox7.Text = "Gen Groceries";
        // 
        // lblItems1
        // 
        lblItems1.AutoSize = true;
        lblItems1.Location = new Point(221, 82);
        lblItems1.Margin = new Padding(4, 0, 4, 0);
        lblItems1.Name = "lblItems1";
        lblItems1.Size = new Size(59, 28);
        lblItems1.TabIndex = 9;
        lblItems1.Text = "items";
        lblItems1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lstGen
        // 
        lstGen.FormattingEnabled = true;
        lstGen.ItemHeight = 28;
        lstGen.Location = new Point(300, 33);
        lstGen.Margin = new Padding(6, 7, 6, 7);
        lstGen.Name = "lstGen";
        lstGen.Size = new Size(392, 144);
        lstGen.TabIndex = 8;
        lstGen.SelectedIndexChanged += lstIca_SelectedIndexChanged;
        // 
        // btnStopIca
        // 
        btnStopIca.Enabled = false;
        btnStopIca.Location = new Point(204, 136);
        btnStopIca.Margin = new Padding(6, 7, 6, 7);
        btnStopIca.Name = "btnStopIca";
        btnStopIca.Size = new Size(73, 49);
        btnStopIca.TabIndex = 7;
        btnStopIca.Text = "Stop";
        btnStopIca.UseVisualStyleBackColor = true;
        btnStopIca.Click += btnStopGen_Click;
        // 
        // btnStartIca
        // 
        btnStartIca.Location = new Point(28, 136);
        btnStartIca.Margin = new Padding(6, 7, 6, 7);
        btnStartIca.Name = "btnStartIca";
        btnStartIca.Size = new Size(148, 49);
        btnStartIca.TabIndex = 6;
        btnStartIca.Text = "Start Loading";
        btnStartIca.UseVisualStyleBackColor = true;
        btnStartIca.Click += btnStartGen_Click;
        // 
        // chkIcaCont
        // 
        chkIcaCont.AutoSize = true;
        chkIcaCont.Location = new Point(28, 82);
        chkIcaCont.Margin = new Padding(6, 7, 6, 7);
        chkIcaCont.Name = "chkIcaCont";
        chkIcaCont.Size = new Size(154, 32);
        chkIcaCont.TabIndex = 5;
        chkIcaCont.Text = "Continue load";
        chkIcaCont.UseVisualStyleBackColor = true;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(12, 33);
        label6.Margin = new Padding(6, 0, 6, 0);
        label6.Name = "label6";
        label6.Size = new Size(69, 28);
        label6.TabIndex = 4;
        label6.Text = "Status:";
        // 
        // lblIcaStatus
        // 
        lblIcaStatus.AutoSize = true;
        lblIcaStatus.Location = new Point(80, 33);
        lblIcaStatus.Margin = new Padding(6, 0, 6, 0);
        lblIcaStatus.Name = "lblIcaStatus";
        lblIcaStatus.Size = new Size(174, 28);
        lblIcaStatus.TabIndex = 3;
        lblIcaStatus.Text = "NOT CONSUMING";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(lblItemsProduced);
        groupBox3.Controls.Add(progressItems);
        groupBox3.Controls.Add(lblMax);
        groupBox3.Location = new Point(23, 858);
        groupBox3.Margin = new Padding(6, 7, 6, 7);
        groupBox3.Name = "groupBox3";
        groupBox3.Padding = new Padding(6, 7, 6, 7);
        groupBox3.Size = new Size(1216, 177);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "Storage";
        // 
        // lblItemsProduced
        // 
        lblItemsProduced.AutoSize = true;
        lblItemsProduced.Location = new Point(1090, 33);
        lblItemsProduced.Margin = new Padding(4, 0, 4, 0);
        lblItemsProduced.Name = "lblItemsProduced";
        lblItemsProduced.Size = new Size(101, 28);
        lblItemsProduced.TabIndex = 9;
        lblItemsProduced.Text = "Max items";
        lblItemsProduced.TextAlign = ContentAlignment.MiddleRight;
        // 
        // progressItems
        // 
        progressItems.ForeColor = Color.Blue;
        progressItems.Location = new Point(285, 80);
        progressItems.Margin = new Padding(6, 7, 6, 7);
        progressItems.Maximum = 50;
        progressItems.Name = "progressItems";
        progressItems.Size = new Size(898, 49);
        progressItems.Style = ProgressBarStyle.Continuous;
        progressItems.TabIndex = 2;
        // 
        // lblMax
        // 
        lblMax.AutoSize = true;
        lblMax.Location = new Point(11, 91);
        lblMax.Margin = new Padding(6, 0, 6, 0);
        lblMax.Name = "lblMax";
        lblMax.Size = new Size(194, 28);
        lblMax.TabIndex = 1;
        lblMax.Text = "Max capacity (items):";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(11F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1262, 1048);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Margin = new Padding(6, 7, 6, 7);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Food Supply System";
        groupBox1.ResumeLayout(false);
        groupBox6.ResumeLayout(false);
        groupBox6.PerformLayout();
        groupBox5.ResumeLayout(false);
        groupBox5.PerformLayout();
        groupBox4.ResumeLayout(false);
        groupBox4.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox11.ResumeLayout(false);
        groupBox11.PerformLayout();
        groupBox9.ResumeLayout(false);
        groupBox9.PerformLayout();
        groupBox7.ResumeLayout(false);
        groupBox7.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ResumeLayout(false);

    }

    #endregion


    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.ProgressBar progressItems;
    private System.Windows.Forms.Label lblMax;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.Button btnStopAxfood;
    private System.Windows.Forms.Button btnStartAxfood;
    private System.Windows.Forms.Label lblStatusAxfood;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.Button btnStopArla;
    private System.Windows.Forms.Button btnStartArla;
    private System.Windows.Forms.Label lblStatusArla;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnStopScan;
    private System.Windows.Forms.Button btnStartScan;
    private System.Windows.Forms.Label lblStatusScan;
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.GroupBox groupBox11;
    private System.Windows.Forms.ListBox lstFood;
    private System.Windows.Forms.Button btnStopCity;
    private System.Windows.Forms.Button btnStartCity;
    private System.Windows.Forms.CheckBox chkCityCont;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label lblCityStatus;
    private System.Windows.Forms.GroupBox groupBox9;
    private System.Windows.Forms.ListBox lstCoop;
    private System.Windows.Forms.Button btnStopCoop;
    private System.Windows.Forms.Button btnStartCoop;
    private System.Windows.Forms.CheckBox chkCoopCont;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label lblCoopStatus;
    private System.Windows.Forms.ListBox lstGen;
    private System.Windows.Forms.Button btnStopIca;
    private System.Windows.Forms.Button btnStartIca;
    private System.Windows.Forms.CheckBox chkIcaCont;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label lblIcaStatus;
    private System.Windows.Forms.Label lblItems1;
    private System.Windows.Forms.Label lblItems3;
    private System.Windows.Forms.Label lblItems2;
    private System.Windows.Forms.Label lblItemsProduced;
}

