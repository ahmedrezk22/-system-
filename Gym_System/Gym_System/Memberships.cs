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

namespace Gym_System
{
    public partial class Memberships : Form
    {
        public Memberships()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("data source = DESKTOP-7I74MOI; database = Gym_System; integrated security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void DisplayMemberships()
        {
            conn.Open();
            if (ds.Tables.Contains("Memberships_Table"))
                ds.Tables["Memberships_Table"].Clear();
            da = new SqlDataAdapter("select * from Memberships_Table", conn);
            SqlCommandBuilder x = new SqlCommandBuilder(da);
            da.Fill(ds, "Memberships_Table");
            DataGridView_Memberships.DataSource = ds.Tables["Memberships_Table"];
            conn.Close();
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_duration.Clear();
            TextBox_goal.Clear();
            TextBox_cost.Clear();
        }

        private void Memberships_Load(object sender, EventArgs e)
        {
            DisplayMemberships();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            Int64 Membership_ID = Int64.Parse(TextBox_id.Text);
            string Membership_Name = TextBox_name.Text;
            string Mrmbership_Duration = TextBox_duration.Text;
            string Mrmbership_Goal = TextBox_goal.Text;
            string Mrmbership_Cost = TextBox_cost.Text;
            conn.Open();
            cmd = new SqlCommand("insert into Memberships_Table (Membership_ID,Membership_Name,Membership_Duration,Membership_Goal,Membership_Cost) values ('" + Membership_ID + "','" + Membership_Name + "','" + Mrmbership_Duration + "','" + Mrmbership_Goal + "','" + Mrmbership_Cost + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("A new membership has been added!");
            DisplayMemberships();
        }
    }
}
