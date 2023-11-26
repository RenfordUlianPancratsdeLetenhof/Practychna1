namespace Practychna1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip_unitTests = new System.Windows.Forms.MenuStrip();
            this.роботаЗМасивамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одновимірніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двовимірніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інтерфейсиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.делегатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip_unitTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "a";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "-2,25";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(57, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "34,9";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(275, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(57, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "0,5";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(420, 72);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(57, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridView1.Location = new System.Drawing.Point(15, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(417, 476);
            this.dataGridView1.TabIndex = 8;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 125;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 125;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(471, 123);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(586, 476);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Обрахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip_unitTests
            // 
            this.menuStrip_unitTests.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_unitTests.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.роботаЗМасивамиToolStripMenuItem,
            this.unitTestsToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.інтерфейсиToolStripMenuItem,
            this.делегатToolStripMenuItem});
            this.menuStrip_unitTests.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_unitTests.Name = "menuStrip_unitTests";
            this.menuStrip_unitTests.Size = new System.Drawing.Size(1069, 28);
            this.menuStrip_unitTests.TabIndex = 11;
            this.menuStrip_unitTests.Text = "menuStrip1";
            // 
            // роботаЗМасивамиToolStripMenuItem
            // 
            this.роботаЗМасивамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одновимірніToolStripMenuItem,
            this.двовимірніToolStripMenuItem});
            this.роботаЗМасивамиToolStripMenuItem.Name = "роботаЗМасивамиToolStripMenuItem";
            this.роботаЗМасивамиToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.роботаЗМасивамиToolStripMenuItem.Text = "Робота з масивами";
            // 
            // одновимірніToolStripMenuItem
            // 
            this.одновимірніToolStripMenuItem.Name = "одновимірніToolStripMenuItem";
            this.одновимірніToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.одновимірніToolStripMenuItem.Text = "Одновимірні";
            this.одновимірніToolStripMenuItem.Click += new System.EventHandler(this.одновимірніToolStripMenuItem_Click);
            // 
            // двовимірніToolStripMenuItem
            // 
            this.двовимірніToolStripMenuItem.Name = "двовимірніToolStripMenuItem";
            this.двовимірніToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.двовимірніToolStripMenuItem.Text = "Двовимірні";
            this.двовимірніToolStripMenuItem.Click += new System.EventHandler(this.двовимірніToolStripMenuItem_Click);
            // 
            // unitTestsToolStripMenuItem
            // 
            this.unitTestsToolStripMenuItem.Name = "unitTestsToolStripMenuItem";
            this.unitTestsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.unitTestsToolStripMenuItem.Text = "Unit tests";
            this.unitTestsToolStripMenuItem.Click += new System.EventHandler(this.unitTestsToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // інтерфейсиToolStripMenuItem
            // 
            this.інтерфейсиToolStripMenuItem.Name = "інтерфейсиToolStripMenuItem";
            this.інтерфейсиToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.інтерфейсиToolStripMenuItem.Text = " Інтерфейси";
            this.інтерфейсиToolStripMenuItem.Click += new System.EventHandler(this.інтерфейсиToolStripMenuItem_Click);
            // 
            // делегатToolStripMenuItem
            // 
            this.делегатToolStripMenuItem.Name = "делегатToolStripMenuItem";
            this.делегатToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.делегатToolStripMenuItem.Text = "Делегат";
            this.делегатToolStripMenuItem.Click += new System.EventHandler(this.делегатToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 604);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip_unitTests);
            this.MainMenuStrip = this.menuStrip_unitTests;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip_unitTests.ResumeLayout(false);
            this.menuStrip_unitTests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip_unitTests;
        private System.Windows.Forms.ToolStripMenuItem роботаЗМасивамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одновимірніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двовимірніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інтерфейсиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem делегатToolStripMenuItem;
    }
}

