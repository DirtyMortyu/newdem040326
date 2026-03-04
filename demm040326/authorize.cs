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
            {
                MessageBox.Show("заполните поля");
                return;
            }
            using (var db = new Dem040326Context())
            {
                var user = db.Users
                    .FirstOrDefault(l => l.Login == login && l.Password == pass);
                if (user == null)
                {
                    MessageBox.Show("НЕверный логин или пароль");
                    return;
                }

                switch (user.IdRole)
                {
                    case 1:
                        MessageBox.Show($"Добро пожаловать, {user.Fio}!");
                        this.Hide();
                        admin aa = new admin();
                        aa.Show();
                        break;

                    case 2:
                        MessageBox.Show($"Добро пожаловать, {user.Fio}!");
                        this.Hide();
                        Maneger bb = new Maneger();
                        bb.Show();
                        break;

                    case 3:
                        MessageBox.Show($"Добро пожаловать, {user.Fio}!");
                        this.Hide();
                        User cc = new User();
                        cc.Show();
                        break;


                    default:
                        MessageBox.Show("Нету пользователя");
                        this.Show();
                        break;
                }
            }
                
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
