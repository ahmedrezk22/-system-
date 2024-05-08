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
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string Name = Name_TextBox.Text;
            string Email = Email_TextBox.Text;
            string Message = Message_TextBox.Text;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = DESKTOP-7I74MOI; database = Gym_System; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Support_Messages (Name,Email,Message) values ('" + Name + "','" + Email + "','" + Message + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Your Message has been sent. Thank you for contact us <3", "Support", MessageBoxButtons.OK);
        }

        private void Support_Load(object sender, EventArgs e)
        {
           
        }
    }
}
