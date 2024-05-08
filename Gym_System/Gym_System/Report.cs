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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("data source = DESKTOP-7I74MOI; database = Gym_System; integrated security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void DisplayInvoice()
        {
            conn.Open();
            if (ds.Tables.Contains("Billing_Invoices"))
                ds.Tables["Billing_Invoices"].Clear();
            da = new SqlDataAdapter("select * from Billing_Invoices", conn);
            SqlCommandBuilder x = new SqlCommandBuilder(da);
            da.Fill(ds, "Billing_Invoices");
            DataGridView_InvoiceReport.DataSource = ds.Tables["Billing_Invoices"];
            conn.Close();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            DisplayInvoice();
        }

        private void PrintOrderSummary()
        {
            try 
            {
                printDocument1.Print();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            {
                int ypos = 50;
                e.Graphics.DrawString("INVOICE", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(250, ypos));
                ypos += 70;
                e.Graphics.DrawString("INVOICE NO: " + DataGridView_InvoiceReport.SelectedRows[0].Cells[0].Value.ToString(),new Font("Century", 18, FontStyle.Regular), Brushes.Black, new Point(100, ypos));
                ypos += 30;
                e.Graphics.DrawString("INVOICE DATE: " + DataGridView_InvoiceReport.SelectedRows[0].Cells[6].Value.ToString(), new Font("Century", 18, FontStyle.Regular), Brushes.Black, new Point(100, ypos));
                ypos += 70;
                e.Graphics.DrawString("CUSTOMER INFORMATION: " , new Font("Century", 18, FontStyle.Bold), Brushes.Black, new Point(100, ypos));
                ypos += 30;
                e.Graphics.DrawString("CUSTOMER ID: " + DataGridView_InvoiceReport.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 18, FontStyle.Regular), Brushes.Black, new Point(100, ypos));
                ypos += 30;
                e.Graphics.DrawString("CUSTOMER NAME: " + DataGridView_InvoiceReport.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 18, FontStyle.Regular), Brushes.Black, new Point(100, ypos));
                ypos += 30;
                e.Graphics.DrawString("CUSTOMER PHONE: " + DataGridView_InvoiceReport.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 18, FontStyle.Regular), Brushes.Black, new Point(100, ypos));
                ypos += 30;
                e.Graphics.DrawString("CUSTOMER EMAIL: " + DataGridView_InvoiceReport.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century", 18, FontStyle.Regular), Brushes.Black, new Point(100, ypos));
                ypos += 30;
                e.Graphics.DrawString("CUSTOMER ADDRESS: " + DataGridView_InvoiceReport.SelectedRows[0].Cells[5].Value.ToString(), new Font("Century", 18, FontStyle.Regular), Brushes.Black, new Point(100, ypos));
                ypos += 70;
                e.Graphics.DrawString("PRODUCT INFORMATION: ", new Font("Century", 18, FontStyle.Bold), Brushes.Black, new Point(100, ypos));
                ypos += 30;
                e.Graphics.DrawString("PRODUCT: " + DataGridView_InvoiceReport.SelectedRows[0].Cells[7].Value.ToString(), new Font("Century", 18, FontStyle.Regular), Brushes.Black, new Point(100, ypos));
                ypos += 30;
                e.Graphics.DrawString("QUANTITY: " + DataGridView_InvoiceReport.SelectedRows[0].Cells[8].Value.ToString(), new Font("Century", 18, FontStyle.Regular), Brushes.Black, new Point(100, ypos));
                ypos += 30;
                e.Graphics.DrawString("UNIT PRICE: " + DataGridView_InvoiceReport.SelectedRows[0].Cells[9].Value.ToString(), new Font("Century", 18, FontStyle.Regular), Brushes.Black, new Point(100, ypos));
                ypos += 30;
                e.Graphics.DrawString("TOTAL: " + DataGridView_InvoiceReport.SelectedRows[0].Cells[10].Value.ToString(), new Font("Century", 18, FontStyle.Regular), Brushes.Black, new Point(100, ypos));
                ypos += 70;
                e.Graphics.DrawString("SELLER INFORMATION: AHMED REZK", new Font("Century", 18, FontStyle.Bold), Brushes.Black, new Point(100, ypos));
                ypos += 30;
                e.Graphics.DrawString("SELLER COMPANY: POWER GYM", new Font("Century", 18, FontStyle.Regular), Brushes.Black, new Point(100, ypos));
                ypos += 30;
                e.Graphics.DrawString("CONTACT NUMBER: 01286686528", new Font("Century", 18, FontStyle.Regular), Brushes.Black, new Point(100, ypos));
                e.HasMorePages = false;
            }
        }

        private void Print_Button_Click(object sender, EventArgs e)
        {
            PrintOrderSummary();
        }
    }
}
