namespace Gym_System
{
    partial class Members
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members));
            this.AddMember_Button = new Guna.UI2.WinForms.Guna2Button();
            this.SearchMember_Button = new Guna.UI2.WinForms.Guna2Button();
            this.id_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeleteMember_Button = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridView_Members = new System.Windows.Forms.DataGridView();
            this.Refresh_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Members)).BeginInit();
            this.SuspendLayout();
            // 
            // AddMember_Button
            // 
            this.AddMember_Button.BackColor = System.Drawing.Color.Transparent;
            this.AddMember_Button.BorderRadius = 20;
            this.AddMember_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddMember_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddMember_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddMember_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddMember_Button.FillColor = System.Drawing.Color.LimeGreen;
            this.AddMember_Button.Font = new System.Drawing.Font("Chalkboard SE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMember_Button.ForeColor = System.Drawing.Color.White;
            this.AddMember_Button.Location = new System.Drawing.Point(92, 458);
            this.AddMember_Button.Margin = new System.Windows.Forms.Padding(2);
            this.AddMember_Button.Name = "AddMember_Button";
            this.AddMember_Button.Size = new System.Drawing.Size(181, 45);
            this.AddMember_Button.TabIndex = 0;
            this.AddMember_Button.Text = "Add";
            this.AddMember_Button.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // SearchMember_Button
            // 
            this.SearchMember_Button.BorderRadius = 20;
            this.SearchMember_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchMember_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchMember_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchMember_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchMember_Button.Font = new System.Drawing.Font("Chalkboard SE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMember_Button.ForeColor = System.Drawing.Color.White;
            this.SearchMember_Button.Location = new System.Drawing.Point(420, 458);
            this.SearchMember_Button.Margin = new System.Windows.Forms.Padding(2);
            this.SearchMember_Button.Name = "SearchMember_Button";
            this.SearchMember_Button.Size = new System.Drawing.Size(181, 45);
            this.SearchMember_Button.TabIndex = 1;
            this.SearchMember_Button.Text = "Search";
            this.SearchMember_Button.Click += new System.EventHandler(this.SearchMember_Button_Click);
            // 
            // id_TextBox
            // 
            this.id_TextBox.BorderRadius = 18;
            this.id_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_TextBox.DefaultText = "Enter id here...";
            this.id_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.id_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.id_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id_TextBox.Font = new System.Drawing.Font("Chalkboard SE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_TextBox.ForeColor = System.Drawing.Color.Gray;
            this.id_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id_TextBox.Location = new System.Drawing.Point(286, 7);
            this.id_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id_TextBox.Name = "id_TextBox";
            this.id_TextBox.PasswordChar = '\0';
            this.id_TextBox.PlaceholderText = "";
            this.id_TextBox.SelectedText = "";
            this.id_TextBox.Size = new System.Drawing.Size(456, 41);
            this.id_TextBox.TabIndex = 2;
            this.id_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id_TextBox.Enter += new System.EventHandler(this.guna2TextBox1_Enter);
            this.id_TextBox.Leave += new System.EventHandler(this.id_TextBox_Leave);
            // 
            // DeleteMember_Button
            // 
            this.DeleteMember_Button.BorderRadius = 20;
            this.DeleteMember_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteMember_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteMember_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteMember_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteMember_Button.FillColor = System.Drawing.Color.Red;
            this.DeleteMember_Button.Font = new System.Drawing.Font("Chalkboard SE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMember_Button.ForeColor = System.Drawing.Color.White;
            this.DeleteMember_Button.Location = new System.Drawing.Point(748, 458);
            this.DeleteMember_Button.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteMember_Button.Name = "DeleteMember_Button";
            this.DeleteMember_Button.Size = new System.Drawing.Size(181, 45);
            this.DeleteMember_Button.TabIndex = 4;
            this.DeleteMember_Button.Text = "Delete";
            this.DeleteMember_Button.Click += new System.EventHandler(this.DeleteMember_Button_Click);
            // 
            // DataGridView_Members
            // 
            this.DataGridView_Members.AllowUserToAddRows = false;
            this.DataGridView_Members.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView_Members.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView_Members.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Chalkboard SE", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Members.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Members.EnableHeadersVisualStyles = false;
            this.DataGridView_Members.Location = new System.Drawing.Point(12, 58);
            this.DataGridView_Members.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView_Members.Name = "DataGridView_Members";
            this.DataGridView_Members.Size = new System.Drawing.Size(1006, 394);
            this.DataGridView_Members.TabIndex = 5;
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Refresh_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Refresh_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Refresh_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Refresh_Button.FillColor = System.Drawing.Color.Black;
            this.Refresh_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Refresh_Button.ForeColor = System.Drawing.Color.White;
            this.Refresh_Button.Image = ((System.Drawing.Image)(resources.GetObject("Refresh_Button.Image")));
            this.Refresh_Button.ImageSize = new System.Drawing.Size(45, 45);
            this.Refresh_Button.Location = new System.Drawing.Point(962, 6);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Refresh_Button.Size = new System.Drawing.Size(50, 50);
            this.Refresh_Button.TabIndex = 6;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1029, 511);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.DataGridView_Members);
            this.Controls.Add(this.DeleteMember_Button);
            this.Controls.Add(this.id_TextBox);
            this.Controls.Add(this.SearchMember_Button);
            this.Controls.Add(this.AddMember_Button);
            this.Font = new System.Drawing.Font("Chalkboard SE", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Members";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Members";
            this.Load += new System.EventHandler(this.Members_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Members)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button AddMember_Button;
        private Guna.UI2.WinForms.Guna2Button SearchMember_Button;
        private Guna.UI2.WinForms.Guna2TextBox id_TextBox;
        private Guna.UI2.WinForms.Guna2Button DeleteMember_Button;
        private System.Windows.Forms.DataGridView DataGridView_Members;
        private Guna.UI2.WinForms.Guna2CircleButton Refresh_Button;
    }
}