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

namespace university_gym_management_sysytem
{
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your data.Confirm?", "Delete data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string ConnectionString = "Data Source=SALIMA\\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConnectionString);
                string CommandText = "delete from NewMember where MID=" + textBox1.Text + "";
                SqlDataAdapter sda = new SqlDataAdapter(CommandText, con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
 
        private void DeleteMember_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=SALIMA\\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            string CommandText = "select *from NewMember";
            SqlDataAdapter sda = new SqlDataAdapter(CommandText, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
