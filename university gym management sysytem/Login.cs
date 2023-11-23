using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace university_gym_management_sysytem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtBoxUserName.Text == "admin" && txtBoxPassword.Text == "admin")

            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Incorrect userId or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
