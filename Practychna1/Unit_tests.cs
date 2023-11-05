using Practychna1.pract_3;
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
    public partial class Unit_tests : Form
    {
        public Unit_tests()
        {
            InitializeComponent();
        }

        private void First_ex_calculate_button_Click(object sender, EventArgs e)
        {
            try 
            {
                First_ex example = new First_ex(
                    Convert.ToDouble(First_ex_A_textbox.Text),
                    Convert.ToDouble(First_ex_B_textbox.Text), 
                    Convert.ToDouble(First_ex_C_textbox.Text));

                First_ex_ans_label.Text = example.count_of_equal_27().ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void UnitTest_back_button_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void second_ex_calculation_button_Click(object sender, EventArgs e)
        {
            try
            {
                Second_ex example = new Second_ex(
                    Convert.ToInt32(second_ex_a_textBox.Text),
                    Convert.ToInt32(second_ex_b_textBox.Text));

                second_ex_ans_label.Text = example.sum().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
