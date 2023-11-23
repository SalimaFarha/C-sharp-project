using System;
using System.Collections;
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
    public partial class ViewEquipment : Form
    {
        public ViewEquipment()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewEquipment_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=SALIMA\\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            string CommandText = "select *from Equipment";
            SqlDataAdapter sda = new SqlDataAdapter(CommandText, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }
    }
}
