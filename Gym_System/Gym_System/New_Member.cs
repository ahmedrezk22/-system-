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
    public partial class New_Member : Form
    {
        public New_Member()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("data source = DESKTOP-7I74MOI; database = Gym_System; integrated security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void New_Member_Load(object sender, EventArgs e)
        {

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            Int64 Member_ID = Int64.Parse(TextBox_id.Text);
            string Member_Name = TextBox_name.Text;
            String Member_Gender = "";
            bool isChecked = guna2RadioButton1.Checked;
            if (isChecked) 
            {
                Member_Gender = guna2RadioButton1.Text;
            }
            else
            {
                Member_Gender= guna2RadioButton2.Text;
            }
            String Member_DOB = DateTimePicker_DOB.Text;
            Int64 Member_Mobile = Int64.Parse(TextBox_mobile.Text);
            string Member_JoinDate = DateTimePicker_JoinDate.Text;
            string Member_Coach = ComboBox_Coach.Text;
            String Member_GymTime = ComboBox_GymTime.Text;
            string Member_Membership = ComboBox_Membership.Text;
            String Member_Address = richTextBox_Address.Text;

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Members_Table (Member_ID,Member_Name,Member_Gender,Member_DOB,Member_Mobile,Member_JionTime,Member_Coach,Member_Membership,Member_Address,Member_GymTime) values ('" + Member_ID + "','" + Member_Name + "','" + Member_Gender + "','" + Member_DOB + "','" + Member_Mobile + "','" + Member_JoinDate + "','" + Member_Coach + "','" + Member_Membership + "','" + Member_Address + "','" + Member_GymTime + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            MessageBox.Show("A new member has been added!");
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            guna2RadioButton1.Checked = false;
            guna2RadioButton2.Checked = false;
            TextBox_mobile.Clear();
            richTextBox_Address.Clear();
            ComboBox_Coach.ResetText();
            ComboBox_GymTime.ResetText();
            ComboBox_Membership.ResetText();
            DateTimePicker_DOB.Value = DateTime.Now;
            DateTimePicker_JoinDate.Value = DateTime.Now;
        }
    }
}
