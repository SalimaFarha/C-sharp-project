using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace university_gym_management_sysytem
{
    public partial class New_Member : Form
    {
       // private const string  = " date source";

        public New_Member()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string gender = "";
            bool isChacked = radioButton1.Checked;
            if (isChacked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            string dob = dateTimePickerDOB.Text;
            string mobile = txtMobile.Text;
            string email = txtEmail.Text;
            String joindate = dateTimePickerJoinDate.Text;
            String gymTime = comboBoxGymTime.Text;
            String address = txtAddress.Text;
            String membership = comboBoxMembership.Text;


           // object SqlConnection = null;
            
            string ConnectionString = "Data Source=SALIMA\\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            string CommandText = "insert into NewMember (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Gymtime,MembershipTime) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + joindate + "','" + gymTime + "','" + membership + "')";
            //SqlDataAdapter DA = new SqlDataAdapter(cmd);
            SqlCommand cmd = new SqlCommand(CommandText,con);
            //DataSet DS = new DataSet();
            //DA.Fill(DS);
            //MessageBox.Show("Data saved.");
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data saved");
            }
            con.Close();


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();

            comboBoxGymTime.ResetText();
            comboBoxMembership.ResetText();
            txtAddress.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;
        }
    }
}
