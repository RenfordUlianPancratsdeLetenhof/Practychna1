using System;
using System.Windows.Forms;

namespace Practychna1
{
    public partial class array_dvovimir : Form
    {
        private Array2D A;

        public array_dvovimir()
        {
            InitializeComponent();
        }

        private void exit_button_main_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Hide();
        }

        private void calculating_Click(object sender, EventArgs e)
        {
            int M, N;

            if (int.TryParse(M_textBox.Text, out M) && int.TryParse(N_textBox.Text, out N))
            {
                A = new Array2D(M, N);

                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = N;

                for (int i = 1; i <= M; i++)
                {
                    dataGridView1.Rows.Add();
                    for (int j = 1; j <= N; j++)
                    {
                        dataGridView1[j - 1, i - 1].Value = A[i, j];
                    }
                }

                int sum = A.CalculateSumOfElementsWithBothOddIndices();
                sum_label.Text = "Сума елементів з обома непарними індексами: " + sum;
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні значення для M і N.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
