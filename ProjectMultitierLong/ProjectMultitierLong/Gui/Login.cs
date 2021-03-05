using ProjectMultitierLong.Gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMultitierLong
{
    public partial class Login : Form
    {
        MidtermDatabaseEntities2 db = new MidtermDatabaseEntities2();
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //var username = textBoxUsername.Text;
            //var password = 
            var listUser = db.Users.Where(x => x.Username == textBoxUsername.Text && x.Password == textBoxPassword.Text).ToList();
            if (listUser.Count != 0)
            {
                if(listUser[0].Role == "admin") // Id: admin. Password: admin
                {
                    AdminInterface f = new AdminInterface();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    UserInterface f = new UserInterface();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Your username or password is wrong! Please check again.");
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            this.Hide();
            r.ShowDialog();
            this.Close();
        }
    }
}
