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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("data source = DESKTOP-7I74MOI; database = Gym_System; integrated security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void label_clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
            TextBox_confirmpassword.Clear();
            TextBox_username.Focus();
        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Red;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Gold;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.DodgerBlue;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Goldenrod;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBox_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Password.Checked)
            {
                TextBox_password.PasswordChar = '\0';
                TextBox_confirmpassword.PasswordChar = '\0';
            }
            else
            {
                TextBox_password.PasswordChar = '*';
                TextBox_confirmpassword.PasswordChar = '*';
            }
        }

        private void Button_Signup_Click(object sender, EventArgs e)
        {
            if (TextBox_username.Text == "" && TextBox_password.Text == "" && TextBox_confirmpassword.Text == "")
            {
                MessageBox.Show("UserName and Password are Empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextBox_password.Text == TextBox_confirmpassword.Text)
            {
                conn.Open();
                string Register = "INSERT INTO Users_Table VALUES('" + TextBox_username.Text + "','" + TextBox_password.Text + "') ";
                cmd = new SqlCommand(Register, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                TextBox_username.Text = "";
                TextBox_password.Text = "";
                TextBox_confirmpassword.Text = "";

                MessageBox.Show("Your Account has been sent successfully created", "Registration success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Passwords does not match , Please Re_Enter ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_password.Text = "";
                TextBox_confirmpassword.Text = "";
                TextBox_password.Focus();

            }
        }
    }
}
