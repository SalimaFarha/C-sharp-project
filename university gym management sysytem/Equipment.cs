using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace university_gym_management_sysytem
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string EquipName = txtEquipName.Text;
            string Description = txtDescription.Text;
            string MUsed = txtMusclesUsed.Text;
            string DDate = dateTimePickerDeliveryDate.Text;
            string Cost = txtCost.Text;

            string ConnectionString = "Data Source=SALIMA\\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            string CommandText = "insert into Equipment (EquipName,EDesceription,Mused,DDate,Cost) values ('" + EquipName + "','" + Description + "','" + MUsed + "','" + DDate + "','" + Cost + "')";
            SqlCommand cmd = new SqlCommand(CommandText,con);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if ( a > 0)
            {
                MessageBox.Show("Data saved", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEquipName.Clear();
            txtDescription.Clear();
            txtMusclesUsed.Clear();
            txtCost.Clear();
            dateTimePickerDeliveryDate.Value = DateTime.Now;

        }

        private void btnViewEq_Click(object sender, EventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }
    }
}
