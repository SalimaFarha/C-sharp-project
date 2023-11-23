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
    public partial class SearchMember : Form
    {
        public  SearchMember()
        {
            InitializeComponent();
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
               

                string ConnectionString = "Data Source=SALIMA\\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConnectionString);
                string CommandText = "select *from NewMember where MID=" + txtSearch.Text + "";
                SqlDataAdapter sda = new SqlDataAdapter(CommandText, con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            }
            else
            {
                //MassageBox.Show("please enter the id,"Massage", MassageBoxButton.Ok,MassageBoxIcon.Waring"); 

            }
        }

        private void SearchMember_Load(object sender, EventArgs e)
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
