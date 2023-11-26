using Practychna1.Pract5;
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
    public partial class Practychna5 : Form
    {
        Products products = new Products();
        string path = "data.xml";

        public void show(DataGridView dg)
        {
            dg.Rows.Clear();
            foreach (Product product in products.products)
            {
                dg.Rows.Add(product.Types, product.Cost, product.Variety, product.Count);
            }
        }
        
        
        public Practychna5()
        {
            InitializeComponent();
        }

        private void Practychna5_Load(object sender, EventArgs e)
        {

        }

        private void BackToMainButton_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Hide();
        }

        private void Practychna5_Activated(object sender, EventArgs e)
        {
            Size = new Size(1015, 700);
            SearchDataGridView.Rows.Clear();    
        }

        private void WriteToFileBbutton_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product(
                    typeTextbox.Text,
                    VariationsTextbox.Text,
                    Convert.ToDouble(CostTextbox.Text),
                    Convert.ToInt32(CountTextbox.Text));
                products.add(product);
                ReadDataGridView.Rows.Add(
                    products.products[products.products.Count - 1].Types,
                    products.products[products.products.Count - 1].Variety,
                    products.products[products.products.Count - 1].Cost,
                    products.products[products.products.Count - 1].Count);
            }
            catch { MessageBox.Show("Помилка при додаванні до колекції"); }
        }

        private void AddDataButton_Click(object sender, EventArgs e)
        {
            products.WriteFile(path);
            MessageBox.Show("Я записав)");
        }

        private void ReadFromFileButton_Click(object sender, EventArgs e)
        {
            products.readFile(path);
            show(ReadDataGridView);
        }

        private void DeleteFromFileButton_Click(object sender, EventArgs e)
        {
            var index = ReadDataGridView.CurrentRow.Index;
            products.remove(index);
            show(ReadDataGridView);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            products.sort();
            show(SortDataGridView);
        }

        private void SearchByCountButton_Click(object sender, EventArgs e)
        {
            products.products.Sort();
            SearchDataGridView.Rows.Clear();    
            foreach (Product product in products.products)
            {
                if (product.Count < Convert.ToInt32(SearchCountTextBox.Text))
                { SearchDataGridView.Rows.Add(product.Types, product.Variety, product.Cost, product.Count);}
            }
        }
    }
}
