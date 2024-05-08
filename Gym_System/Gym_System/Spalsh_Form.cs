using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Gym_System
{
    public partial class Spalsh_Form : Form
    {
        public Spalsh_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Spalsh_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int StartPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartPoint += 2;
            CircleProgressBar.Value = StartPoint;
            if (CircleProgressBar.Value == 100)
            {
                CircleProgressBar.Value = 0;
                timer1.Stop();
                Login_Form login_Form = new Login_Form();
                login_Form.Show();
                this.Hide();
            }
        }
    }
}
