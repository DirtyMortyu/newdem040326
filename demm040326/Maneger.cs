using demm040326.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demm040326
{
    public partial class Maneger : Form
    {
        Dem040326Context context;


        public Maneger()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            authorize ff = new authorize();
            ff.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = context.Tovars.Local.AsQueryable();

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    data = data.OrderBy(t => t.Name);
                    break;
                case 1:
                    data = data.OrderByDescending(t => t.Name);
                    break;
                case 2:
                    data = data.OrderBy(t => t.Price);
                    break;
                case 3:
                    data = data.OrderByDescending(t => t.Price);
                    break;
                case 4:
                    data = data.OrderBy(t => t.Category.Name);
                    break;
            }

            bindingSource_tovar.DataSource = data.ToList();
        }

        private void Maneger_Load(object sender, EventArgs e)
        {
            context = new Dem040326Context();
            context.Tovars.Include(x => x.Category).Include(x => x.Supplier).Include(x => x.Manuf).Load();
            context.Database.EnsureCreated();
            bindingSource_tovar.DataSource = context.Tovars.Local.ToBindingList();
            bindingSource_categor.DataSource = context.Categories.Local.ToBindingList();
            bindingSource_sup.DataSource = context.Suppliers.Local.ToBindingList();
            bindingSource_manuf.DataSource = context.Manufacturers.Local.ToBindingList();
            comboBox1.Items.AddRange(new string[]
{
                "По названию (А-Я)",
                "По названию (Я-А)",
                "По цене (возрастание)",
                "По цене (убывание)",
                "По категории"
});
            comboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                bindingSource_tovar.DataSource = context.Tovars.Local.ToBindingList();
                return;
            }

            var results = context.Tovars.Local
                .Where(t => t.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            bindingSource_tovar.DataSource = results;

        }
    }
}
