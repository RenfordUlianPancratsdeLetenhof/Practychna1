using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practychna1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
            string.IsNullOrWhiteSpace(textBox2.Text) ||
            string.IsNullOrWhiteSpace(textBox3.Text) ||
            string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля перед продовженням.");
                return;
            }

            Tabul tabul = new Tabul();

            double xn, xk, h, a;

            xn = Convert.ToDouble(this.textBox1.Text);
            xk = Convert.ToDouble(this.textBox2.Text);
            h = Convert.ToDouble(this.textBox3.Text);
            a = Convert.ToDouble(this.textBox4.Text);
            
            dataGridView1.Rows.Clear();

            chart1.Series[0].Points.Clear();
            tabul.tab(xn, xk, h, a);

            for (int i = 0; i < tabul.real_num; i++)
            {
                dataGridView1.Rows.Add(Math.Round(tabul.result[i, 0], 2).ToString(),
                    Math.Round(tabul.result[i, 1], 3).ToString());
                chart1.Series[0].Points.AddXY(tabul.result[i, 0], tabul.result[i, 1]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // масив одновимір перехід
        private void одновимірніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            array_odno form = new array_odno();
            form.Show();
            this.Hide();
        }
        // масив двовимір перехід
        private void двовимірніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            array_dvovimir form = new array_dvovimir();
            form.Show();
            this.Hide();
        }

        private void unitTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unit_tests form = new Unit_tests();
            form.Show(); 
            this.Hide();   
        }
    }
}
