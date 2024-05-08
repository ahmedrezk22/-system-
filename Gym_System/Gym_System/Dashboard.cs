using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void Members_Button_Click(object sender, EventArgs e)
        {
            Members members = new Members();
            members.Show();
        }

        private void History_Button_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
        }

        private void Coaches_Button_Click(object sender, EventArgs e)
        {
            Coaches Coaches = new Coaches();
            Coaches.Show();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure! Are you going to Logout?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Login_Form login_Form = new Login_Form();
                login_Form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Welcome Back <3", "Welcome", MessageBoxButtons.OK);
            }
        }

        private void Support_Button_Click(object sender, EventArgs e)
        {
            Support support = new Support();
            support.Show();
        }

        private void Memberships_Button_Click(object sender, EventArgs e)
        {
            Memberships memberships = new Memberships();
            memberships.Show();
        }

        private void Billing_Button_Click(object sender, EventArgs e)
        {
            Billing_Dashboard billing = new Billing_Dashboard();
            billing.Show();
        }
    }
}
