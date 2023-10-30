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
    public partial class array_odno : Form
    {
        SurnameArray surnameArray = new SurnameArray(); 
        public array_odno()
        {
            InitializeComponent();
            UpdateSurnameListLabel();
        }

        private void exit_button_to_main_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Hide();    
        }

        private void find_surenames_by_leter_button_Click(object sender, EventArgs e)
        {
            
            string letter = later_textbox.Text;
            dataGridView1.Rows.Clear();

            if (letter.Length != 1)
            {
                MessageBox.Show("Будь ласка, введіть лише одну букву.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                later_textbox.Clear();
                return;
            }

            if (letter.Length <= 0)
            {
                MessageBox.Show("Будь ласка, введіть Букву", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                later_textbox.Clear();
                return;
            }


            if (!char.IsLetter(letter[0]))
            {
                MessageBox.Show("Будь ласка, введіть букву, а не інші символи.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                later_textbox.Clear();
                return;
            }

            foreach (string surname in surnameArray.GetSurnamesByFirstLetter(letter))
            {
                dataGridView1.Rows.Add(surname);
            }
        }

        private void UpdateSurnameListLabel()
        {
            string[] surnames = surnameArray.GetAllSurnames();
            surname_list_label.Text = "Фамілії в масиві: " + string.Join(", ", surnames);
        }
    }
}
