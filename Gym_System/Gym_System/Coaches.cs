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
    public partial class Coaches : Form
    {
        public Coaches()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("data source = DESKTOP-7I74MOI; database = Gym_System; integrated security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void DisplayCoaches()
        {
            conn.Open();
            if (ds.Tables.Contains("Coaches_Table"))
                ds.Tables["Coaches_Table"].Clear();
            da = new SqlDataAdapter("select * from Coaches_Table", conn);
            SqlCommandBuilder x = new SqlCommandBuilder(da);
            da.Fill(ds, "Coaches_Table");
            DataGridView_Coaches.DataSource = ds.Tables["Coaches_Table"];
            conn.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            New_Coach New_Coach = new New_Coach();
            New_Coach.Show();
        }

        private void id_TextBox_Enter(object sender, EventArgs e)
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

        private void Coaches_Load(object sender, EventArgs e)
        {
            DisplayCoaches();
        }

        private void DeleteCoach_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete this coach?", "Delete Coach", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn.Open();
                cmd = new SqlCommand("delete Coaches_Table WHERE Coach_ID=@CI", conn);
                cmd.Parameters.AddWithValue("@CI", id_TextBox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Coach has been deleted successfully!");
                DisplayCoaches();
            }
        }

        private void SearchCoach_Button_Click(object sender, EventArgs e)
        {
            if (id_TextBox.Text == null)
            {
                MessageBox.Show("Please enter id.!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                if (ds.Tables.Contains("Coaches_Table"))
                    ds.Tables["Coaches_Table"].Clear();
                da = new SqlDataAdapter("select * from Coaches_Table where Coach_ID = " + id_TextBox.Text + "", conn);
                SqlCommandBuilder x = new SqlCommandBuilder(da);
                da.Fill(ds, "Coaches_Table");
                DataGridView_Coaches.DataSource = ds.Tables["Coaches_Table"];
                conn.Close();
            }
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            DisplayCoaches();
        }
    }
}
