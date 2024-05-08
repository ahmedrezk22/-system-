using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gym_System
{
    public partial class Members : Form
    {
        
        public Members()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("data source = DESKTOP-7I74MOI; database = Gym_System; integrated security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void DisplayMembers()
        {
            conn.Open();
            if (ds.Tables.Contains("Members_Table"))
                ds.Tables["Members_Table"].Clear();
            da = new SqlDataAdapter("select * from Members_Table", conn);
            SqlCommandBuilder x = new SqlCommandBuilder(da);
            da.Fill(ds, "Members_Table");
            DataGridView_Members.DataSource = ds.Tables["Members_Table"];
            conn.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            New_Member New_Member = new New_Member();
            New_Member.Show();
        }

        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            if (id_TextBox.Text == "Enter id here...")
            {
                id_TextBox.Text = "";
            }
        }

        private void id_TextBox_Leave(object sender, EventArgs e)
        {
            if (id_TextBox.Text == "")
            {
                id_TextBox.Text = "Enter id here...";
            }
        }

        private void SearchMember_Button_Click(object sender, EventArgs e)
        {
            if (id_TextBox.Text == null)
            {
                MessageBox.Show("Please enter id.!","Error Message",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                if (ds.Tables.Contains("Members_Table"))
                    ds.Tables["Members_Table"].Clear();
                da = new SqlDataAdapter("select * from Members_Table where Member_ID = " + id_TextBox.Text + "", conn);
                SqlCommandBuilder x = new SqlCommandBuilder(da);
                da.Fill(ds, "Members_Table");
                DataGridView_Members.DataSource = ds.Tables["Members_Table"];
                conn.Close();
            }
        }

        private void Members_Load(object sender, EventArgs e)
        {
            DisplayMembers();
        }

        private void DeleteMember_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete this member?", "Delete Member", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn.Open();
                cmd = new SqlCommand("delete Members_Table WHERE Member_ID=@MI", conn);
                cmd.Parameters.AddWithValue("@MI", id_TextBox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Member has been deleted successfully!");
                DisplayMembers();
            }
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            DisplayMembers();
        }
    }
}
