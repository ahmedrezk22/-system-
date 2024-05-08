namespace Gym_System
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView_InvoiceReport = new System.Windows.Forms.DataGridView();
            this.Print_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Back_Button = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_InvoiceReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Chalkboard SE", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(468, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report";
            // 
            // DataGridView_InvoiceReport
            // 
            this.DataGridView_InvoiceReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_InvoiceReport.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Chalkboard SE", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_InvoiceReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_InvoiceReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_InvoiceReport.EnableHeadersVisualStyles = false;
            this.DataGridView_InvoiceReport.Location = new System.Drawing.Point(13, 74);
            this.DataGridView_InvoiceReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridView_InvoiceReport.Name = "DataGridView_InvoiceReport";
            this.DataGridView_InvoiceReport.Size = new System.Drawing.Size(1058, 355);
            this.DataGridView_InvoiceReport.TabIndex = 1;
            // 
            // Print_Button
            // 
            this.Print_Button.BorderRadius = 18;
            this.Print_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Print_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Print_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Print_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Print_Button.FillColor = System.Drawing.Color.Gold;
            this.Print_Button.Font = new System.Drawing.Font("Chalkboard SE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_Button.ForeColor = System.Drawing.Color.Black;
            this.Print_Button.Location = new System.Drawing.Point(194, 441);
            this.Print_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(240, 60);
            this.Print_Button.TabIndex = 7;
            this.Print_Button.Text = "Print";
            this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.BorderRadius = 18;
            this.Back_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Back_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Back_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Back_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Back_Button.FillColor = System.Drawing.Color.Gold;
            this.Back_Button.Font = new System.Drawing.Font("Chalkboard SE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Button.ForeColor = System.Drawing.Color.Black;
            this.Back_Button.Location = new System.Drawing.Point(650, 441);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(240, 60);
            this.Back_Button.TabIndex = 8;
            this.Back_Button.Text = "Back";
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Print_Button);
            this.Controls.Add(this.DataGridView_InvoiceReport);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Chalkboard SE", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_InvoiceReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridView_InvoiceReport;
        private Guna.UI2.WinForms.Guna2Button Print_Button;
        private Guna.UI2.WinForms.Guna2Button Back_Button;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}