namespace university_gym_management_sysytem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                toolStripMenuItem1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"C: \Users\Admin\Downloads\image - 3.jpg");
            }
            else
            {
                toolStripMenuItem1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"C: \Users\Admin\Downloads\image - 4.jpg");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
           // toolStripMenuItem1.Image = Image.FromFile(@"C: \Users\Admin\Downloads\image - 4.jpg");
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Member nm = new New_Member();
            nm.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Staff ns = new New_Staff();
            ns.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
            
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMember sm = new SearchMember();
            sm.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMember dm = new DeleteMember();
            dm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close Your application.Confirm?", "CLOSE", MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }

            else
            {
                MessageBox.Show("Welcome Back","Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
    
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Log OUT !! Confirm?","LOG OUT",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
              {
                this.Close();
                Login lg = new Login();
                lg.Show();
              }
        }
    }
}