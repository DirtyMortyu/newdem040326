using demm040326.Models;
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
    public partial class authorize : Form
    {
        

        public authorize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string pass = txtPass.Text;
            if(string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }
    }
}
