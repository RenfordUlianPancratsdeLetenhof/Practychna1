using Practychna1.pract6;
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
    public partial class Delegate : Form
    {
        public Delegate()
        {
            InitializeComponent();
        }

       

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToInt32(textBox1.Text) <= 0)
                {
                    MessageBox.Show("Введіть коректні данні");
                    return;
                }

                int detailCount = Convert.ToInt32(textBox1.Text);
                CreatingProcess manufactureStart = new CreatingProcess();
                Worker worker = new Worker();
                Mehanizm mehanizm = new Mehanizm(detailCount);

                manufactureStart.creating += new MyEventHandler(worker.Worker_Event);
                manufactureStart.creating += new MyEventHandler(mehanizm.Mechanizm_Event);
                manufactureStart.areTheDetails(detailCount);
                MessageBox.Show("Вироби зроблено, вироблено - " + detailCount.ToString() + ", виробництво призупинено, додайте ще деталей");
            }
            catch { MessageBox.Show("Помилка при введені даних"); }
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Hide();
        }
    }
}
