using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMultitierLong.Gui
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            MidtermDatabaseEntities2 db = new MidtermDatabaseEntities2();
            User newUser = new User();
            var username = textBoxUsername.Text;
            User user = db.Users.Find(username);
            if (user!= null)
            {
                MessageBox.Show("Please enter another username ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                newUser.Username = textBoxUsername.Text;
                newUser.Password = textBoxPassword.Text;
                newUser.DoB = textBoxDoB.Text;
                newUser.FullName = textBoxFullName.Text;
                newUser.Role = comboBoxRole.SelectedItem.ToString();
                db.Users.Add(newUser);
                db.SaveChanges();
                MessageBox.Show("User successfully created ");
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
