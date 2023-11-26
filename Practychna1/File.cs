using Practychna1.pract4;
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
    public partial class File : Form
    {
        public File()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntArray a = new IntArray(100);
            FileWriter f = new FileWriter();
            FileRead r = new FileRead();
            ShowArray show = new ShowArray();
            string patch = @"1.txt";
            string outPatch = @"2.txt";
            r.read(patch, a);
            a.calculation();
            f.Write(outPatch, a);
            array_label.Text = show.writeArray(a.a);
            count_label.Text = a.calculation().ToString();

           
        }
    }
}
