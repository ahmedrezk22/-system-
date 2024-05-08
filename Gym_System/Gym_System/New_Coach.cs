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
    public partial class New_Coach : Form
    {
        public New_Coach()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("data source = DESKTOP-7I74MOI; database = Gym_System; integrated security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void Save_Button_Click(object sender, EventArgs e)
        {
            Int64 Coach_ID = Int64.Parse(TextBox_id.Text);
            string Coach_Name = TextBox_name.Text;
            String Coach_Gender = "";
            bool isChecked = guna2RadioButton1.Checked;
            if (isChecked)
            {
                Coach_Gender = guna2RadioButton1.Text;
            }
            else
            {
                Coach_Gender = guna2RadioButton2.Text;
            }
            String Coach_DOB = DateTimePicker_DOB.Text;
            Int64 Coach_Mobile = Int64.Parse(TextBox_mobile.Text);
            string Coach_JoinDate = DateTimePicker_JoinDate.Text;
            string Coach_State = ComboBox_state.Text;
            string Coach_Experience = TextBox_experience.Text;
            string Coach_City = TextBox_city.Text;

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Coaches_Table (Coach_ID,Coach_Name,Coach_Gender,Coach_DOB,Coach_Mobile,Coach_JionTime,Coach_State,Coach_Experience,Coach_City) values ('" + Coach_ID + "','" + Coach_Name + "','" + Coach_Gender + "','" + Coach_DOB + "','" + Coach_Mobile + "','" + Coach_JoinDate + "','" + Coach_State + "','" + Coach_Experience + "','" + Coach_City + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            MessageBox.Show("A new coach has been added!");
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            TextBox_id.Clear();
            TextBox_city.Clear();
            TextBox_experience.Clear();
            TextBox_name.Clear();
            guna2RadioButton1.Checked = false;
            guna2RadioButton2.Checked = false;
            TextBox_mobile.Clear();
            ComboBox_state.ResetText();
            DateTimePicker_DOB.Value = DateTime.Now;
            DateTimePicker_JoinDate.Value = DateTime.Now;
        }

        private void New_Coach_Load(object sender, EventArgs e)
        {

        }
    }
}
