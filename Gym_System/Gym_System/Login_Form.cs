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
using System.Xml.Linq;

namespace Gym_System
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = LOGIN_Gym; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = DESKTOP-7I74MOI; database = Gym_System; integrated security = True";
            if (TextBox_username.Text == "" || TextBox_password.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selectQuery = "SELECT * FROM Users_Table WHERE Username='" + TextBox_username.Text + "' AND Password='" + TextBox_password.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery,conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    Dashboard Dashboard = new Dashboard();
                    Dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Red;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Gold;
        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
            TextBox_username.Focus();
        }

        private void CheckBox_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Password.Checked)
            {
                TextBox_password.PasswordChar = '\0';
            }
            else
            {
                TextBox_password.PasswordChar = '*';
            }
        }
    }
}
