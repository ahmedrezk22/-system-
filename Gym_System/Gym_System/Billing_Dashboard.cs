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
    public partial class Billing_Dashboard : Form
    {
        public Billing_Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("data source = DESKTOP-7I74MOI; database = Gym_System; integrated security = True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        int Product_Nomber = 0;
        int Quantity, Unit_Price, Total;
        string Product;

        private DataTable table;

        private void DisplayProducts()
        {
            conn.Open();
            if (ds.Tables.Contains("Billing_Products"))
                ds.Tables["Billing_Products"].Clear();
            da = new SqlDataAdapter("select * from Billing_Products", conn);
            SqlCommandBuilder x = new SqlCommandBuilder(da);
            da.Fill(ds, "Billing_Products");
            DataGridView_Products.DataSource = ds.Tables["Billing_Products"];
            conn.Close();
        }

        private void DisplayCustomers()
        {
            conn.Open();
            if (ds.Tables.Contains("Billing_Customers"))
                ds.Tables["Billing_Customers"].Clear();
            da = new SqlDataAdapter("select * from Billing_Customers", conn);
            SqlCommandBuilder x = new SqlCommandBuilder(da);
            da.Fill(ds, "Billing_Customers");
            DataGridView_Customers.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Customers_Button_Click(object sender, EventArgs e)
        {
            Title_label.Text = "Customers";
            Customers_panel.Visible = true;
            Products_panel.Visible = false;
            Invoice_panel.Visible = false;
            DisplayCustomers();
        }

        private void Products_Button_Click(object sender, EventArgs e)
        {
            Title_label.Text = "Products";
            Products_panel.Visible = true;
            Invoice_panel.Visible = false;
            DisplayProducts();
        }

        private void Invoice_Button_Click(object sender, EventArgs e)
        {
            Title_label.Text = "Invoice";
            Invoice_panel.Visible = true;
            DisplayProducts2();
            DisplayCustomers2();
            table = new DataTable();
            table.Columns.Add("Product_Nomber",typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Unit_Price", typeof(int));
            table.Columns.Add("Total", typeof(int));
        }

        private void Report_Button_Click(object sender, EventArgs e)
        {
            Title_label.Text = "Report";
            Report report2 = new Report();
            report2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Billing_Dashboard_Load(object sender, EventArgs e)
        {
            conn.Close();
            Customers_panel.Visible = false;
            Products_panel.Visible = false;
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            CustumerId_TextBox.Clear();
            CustumerName_TextBox.Clear();
            CustumerMobile_TextBox.Clear();
            CustumerEmail_TextBox.Clear();
            CustumerAddress_TextBox.Clear();
            CustumerId_TextBox.Focus();
        }

        private void AddCustomer_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustumerName_TextBox.Text == " " || CustumerMobile_TextBox.Text == " " || CustumerEmail_TextBox.Text == " " || CustumerAddress_TextBox.Text == " ")
                {
                    MessageBox.Show("Missing Information!");
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("insert into Billing_Customers(Customer_ID,Customer_Name,Customer_Mobile,Customer_Email,Customer_Address)values(@CI,@CN,@CM,@CE,@CA)", conn);
                    cmd.Parameters.AddWithValue("@CI",CustumerId_TextBox.Text);
                    cmd.Parameters.AddWithValue("@CN", CustumerName_TextBox.Text);
                    cmd.Parameters.AddWithValue("@CM", CustumerMobile_TextBox.Text);
                    cmd.Parameters.AddWithValue("@CE", CustumerEmail_TextBox.Text);
                    cmd.Parameters.AddWithValue("@CA", CustumerAddress_TextBox.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("A new customer has been added!");
                    DisplayCustomers();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void EditCustomer_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustumerId_TextBox.Text == " " || CustumerName_TextBox.Text == " " || CustumerMobile_TextBox.Text == " " || CustumerEmail_TextBox.Text == " " || CustumerAddress_TextBox.Text == " ")
                {
                    MessageBox.Show("Missing Information!");
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("update Billing_Customers set Customer_Name=@CN,Customer_Mobile=@CM,Customer_Email=@CE,Customer_Address=@CA WHERE Customer_ID=@CI", conn);
                    cmd.Parameters.AddWithValue("@CI", CustumerId_TextBox.Text);
                    cmd.Parameters.AddWithValue("@CN", CustumerName_TextBox.Text);
                    cmd.Parameters.AddWithValue("@CM", CustumerMobile_TextBox.Text);
                    cmd.Parameters.AddWithValue("@CE", CustumerEmail_TextBox.Text);
                    cmd.Parameters.AddWithValue("@CA", CustumerAddress_TextBox.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Customer has been updated successfully!");
                    DisplayCustomers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CustumerName_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteCustomer_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustumerName_TextBox.Text == " ") 
                {
                    MessageBox.Show("Missing Information!");
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("delete Billing_Customers WHERE Customer_ID=@CI", conn);
                    cmd.Parameters.AddWithValue("@CI", CustumerId_TextBox.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Customer has been deleted successfully!");
                    DisplayCustomers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void DataGridView_Customers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CustumerId_TextBox.Text = DataGridView_Customers.SelectedRows[0].Cells[0].Value.ToString();
                CustumerName_TextBox.Text = DataGridView_Customers.SelectedRows[0].Cells[1].Value.ToString();
                CustumerMobile_TextBox.Text = DataGridView_Customers.SelectedRows[0].Cells[2].Value.ToString();
                CustumerEmail_TextBox.Text = DataGridView_Customers.SelectedRows[0].Cells[3].Value.ToString();
                CustumerAddress_TextBox.Text = DataGridView_Customers.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Dashboard_Button_Click(object sender, EventArgs e)
        {
            Title_label.Text = "Dashboard";
            Customers_panel.Visible = false;
        }

        private void CustumerId_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CustumerMobile_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CustumerEmail_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductsId_TextBox.Text == " " || ProductsName_TextBox.Text == " " || ProductsQuantity_TextBox.Text == " " || ProductsCategory_TextBox.Text == " " || ProductsPrice_TextBox.Text == " ")
                {
                    MessageBox.Show("Missing Information!");
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("insert into Billing_Products(Product_ID,Product_Name,Product_Quantity,Product_Category,Product_Price)values(@PI,@PN,@PQ,@PC,@PP)", conn);
                    cmd.Parameters.AddWithValue("@PI", ProductsId_TextBox.Text);
                    cmd.Parameters.AddWithValue("@PN", ProductsName_TextBox.Text);
                    cmd.Parameters.AddWithValue("@PQ", ProductsQuantity_TextBox.Text);
                    cmd.Parameters.AddWithValue("@PC", ProductsCategory_TextBox.Text);
                    cmd.Parameters.AddWithValue("@PP", ProductsPrice_TextBox.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("A new product has been added!");
                    DisplayProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void EditProduct_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductsId_TextBox.Text == " " || ProductsName_TextBox.Text == " " || ProductsQuantity_TextBox.Text == " " || ProductsCategory_TextBox.Text == " " || ProductsPrice_TextBox.Text == " ")
                {
                    MessageBox.Show("Missing Information!");
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("update Billing_Products set Product_Name=@PN,Product_Quantity=@PQ,Product_Category=@PC,Product_Price=@PP WHERE Product_ID=@PI", conn);
                    cmd.Parameters.AddWithValue("@PI", ProductsId_TextBox.Text);
                    cmd.Parameters.AddWithValue("@PN", ProductsName_TextBox.Text);
                    cmd.Parameters.AddWithValue("@PQ", ProductsQuantity_TextBox.Text);
                    cmd.Parameters.AddWithValue("@PC", ProductsCategory_TextBox.Text);
                    cmd.Parameters.AddWithValue("@PP", ProductsPrice_TextBox.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Product has been updated successfully!");
                    DisplayProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void DeleteProduct_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductsId_TextBox.Text == " ")
                {
                    MessageBox.Show("Missing Information!");
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("delete Billing_Products WHERE Product_ID=@PI", conn);
                    cmd.Parameters.AddWithValue("@PI", ProductsId_TextBox.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Products has been deleted successfully!");
                    DisplayProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ResetProduct_Button_Click(object sender, EventArgs e)
        {
            ProductsId_TextBox.Clear();
            ProductsName_TextBox.Clear();
            ProductsQuantity_TextBox.Clear();
            ProductsCategory_TextBox.Clear();
            ProductsPrice_TextBox.Clear();
            ProductsId_TextBox.Focus();
        }

        private void DataGridView_Products_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ProductsId_TextBox.Text = DataGridView_Products.SelectedRows[0].Cells[0].Value.ToString();
                ProductsName_TextBox.Text = DataGridView_Products.SelectedRows[0].Cells[1].Value.ToString();
                ProductsQuantity_TextBox.Text = DataGridView_Products.SelectedRows[0].Cells[2].Value.ToString();
                ProductsCategory_TextBox.Text = DataGridView_Products.SelectedRows[0].Cells[3].Value.ToString();
                ProductsPrice_TextBox.Text = DataGridView_Products.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void DisplayProducts2()
        {
            conn.Open();
            if (ds.Tables.Contains("Billing_Products"))
                ds.Tables["Billing_Products"].Clear();
            da = new SqlDataAdapter("select * from Billing_Products", conn);
            SqlCommandBuilder x = new SqlCommandBuilder(da);
            da.Fill(ds, "Billing_Products");
            DataGridView_prod_invo.DataSource = ds.Tables["Billing_Products"];
            conn.Close();
        }

        int sum = 0;
        private void AddInvoice_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(InvoiceQuantity_TextBox.Text))
                {
                    MessageBox.Show("Enter The Quantity Of Product");
                }
                else if (flag == 0)
                {
                    MessageBox.Show("Select the Product");
                }
                else if (Convert.ToInt32(InvoiceQuantity_TextBox.Text) > stock) 
                {
                    MessageBox.Show("Not Enough stock is Available");
                }
                else
                {
                    Product_Nomber = Product_Nomber + 1;
                    Quantity = Convert.ToInt32(InvoiceQuantity_TextBox.Text);
                    Total = Quantity * Unit_Price;
                    table.Rows.Add(Product_Nomber, Product, Unit_Price, Total);
                    DataGridView_Invoice.DataSource = table;
                    flag = 0;
                    sum = sum + Total;
                    TotalAmount.Text = sum.ToString() + " EG";
                    UpdateProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        int flag = 0;
        int stock = 0;
        private void DataGridView_prod_invo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Product = DataGridView_prod_invo.SelectedRows[0].Cells[1].Value.ToString();
                stock = Convert.ToInt32(DataGridView_prod_invo.SelectedRows[0].Cells[2].Value.ToString());
                Unit_Price = Convert.ToInt32(DataGridView_prod_invo.SelectedRows[0].Cells[4].Value.ToString());
                flag = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void DisplayCustomers2()
        {
            conn.Open();
            if (ds.Tables.Contains("Billing_Customers"))
                ds.Tables["Billing_Customers"].Clear();
            da = new SqlDataAdapter("select * from Billing_Customers", conn);
            SqlCommandBuilder x = new SqlCommandBuilder(da);
            da.Fill(ds, "Billing_Customers");
            DataGridView_cust_invo.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void ViewReport_Button_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void DataGridView_Invoice_DoubleClick(object sender, EventArgs e)
        {
            Product_TextBox.Text = DataGridView_Invoice.SelectedRows[0].Cells[1].Value.ToString();
            Quantity_TextBox.Text = DataGridView_Invoice.SelectedRows[0].Cells[2].Value.ToString();
            UnitPrice_TextBox.Text = DataGridView_Invoice.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Add_invoice_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(InvoiceNumber_TextBox.Text) || string.IsNullOrEmpty(CustumerId_TextBox2.Text) || string.IsNullOrEmpty(CustumerName_TextBox2.Text) || string.IsNullOrEmpty(CustumerMobile_TextBox2.Text) || string.IsNullOrEmpty(CustumerEmail_TextBox2.Text) || string.IsNullOrEmpty(CustumerAddress_TextBox2.Text) || string.IsNullOrEmpty(Product_TextBox.Text) || string.IsNullOrEmpty(Quantity_TextBox.Text) || string.IsNullOrEmpty(UnitPrice_TextBox.Text) || string.IsNullOrEmpty(TotalAmount.Text))
                {
                    MessageBox.Show("Fill Data Correctlly");
                }
                else
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand("insert into Billing_Invoices values ('" + Convert.ToInt32(InvoiceNumber_TextBox.Text) + "','" + Convert.ToInt32(CustumerId_TextBox2.Text) + "','" + CustumerName_TextBox2.Text + "','" + CustumerMobile_TextBox2.Text + "','" + CustumerEmail_TextBox2.Text + "','" + CustumerAddress_TextBox2.Text + "','" + DateTimePicker_InvoiceDate.Text + "','" + Product_TextBox.Text + "','" + Quantity_TextBox.Text + "','" + UnitPrice_TextBox.Text + "','" + TotalAmount.Text + "')", conn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Data Entered Successfully");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void DataGridView_cust_invo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CustumerId_TextBox2.Text = DataGridView_cust_invo.SelectedRows[0].Cells[0].Value.ToString();
                CustumerName_TextBox2.Text = DataGridView_cust_invo.SelectedRows[0].Cells[1].Value.ToString();
                CustumerMobile_TextBox2.Text = DataGridView_cust_invo.SelectedRows[0].Cells[2].Value.ToString();
                CustumerEmail_TextBox2.Text = DataGridView_cust_invo.SelectedRows[0].Cells[3].Value.ToString();
                CustumerAddress_TextBox2.Text = DataGridView_cust_invo.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        void UpdateProduct()
        {
            try
            {
                int id = Convert.ToInt32(DataGridView_prod_invo.SelectedRows[0].Cells[0].Value.ToString());
                int NewQuantity = stock - Convert.ToInt32(InvoiceQuantity_TextBox.Text);
                if (NewQuantity < 0)
                {
                    MessageBox.Show("Operation Failed");
                }
                else
                {
                    conn.Open();
                    string query = "update Billing_Products set Product_Quantity= '" + NewQuantity + "' where Product_ID= '" + id + "';";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.ExecuteNonQuery();
                    conn.Close();
                    DisplayProducts2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
