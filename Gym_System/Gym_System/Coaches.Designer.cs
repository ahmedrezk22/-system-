namespace Gym_System
{
    partial class Coaches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coaches));
            this.AddCoach_Button = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteCoach_Button = new Guna.UI2.WinForms.Guna2Button();
            this.id_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchCoach_Button = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridView_Coaches = new System.Windows.Forms.DataGridView();
            this.Refresh_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Coaches)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCoach_Button
            // 
            this.AddCoach_Button.BorderRadius = 20;
            this.AddCoach_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddCoach_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddCoach_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddCoach_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddCoach_Button.FillColor = System.Drawing.Color.LimeGreen;
            this.AddCoach_Button.Font = new System.Drawing.Font("Chalkboard SE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCoach_Button.ForeColor = System.Drawing.Color.White;
            this.AddCoach_Button.Location = new System.Drawing.Point(92, 458);
            this.AddCoach_Button.Margin = new System.Windows.Forms.Padding(4);
            this.AddCoach_Button.Name = "AddCoach_Button";
            this.AddCoach_Button.Size = new System.Drawing.Size(181, 45);
            this.AddCoach_Button.TabIndex = 0;
            this.AddCoach_Button.Text = "Add";
            this.AddCoach_Button.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // DeleteCoach_Button
            // 
            this.DeleteCoach_Button.BorderRadius = 20;
            this.DeleteCoach_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteCoach_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteCoach_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteCoach_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteCoach_Button.FillColor = System.Drawing.Color.Red;
            this.DeleteCoach_Button.Font = new System.Drawing.Font("Chalkboard SE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCoach_Button.ForeColor = System.Drawing.Color.White;
            this.DeleteCoach_Button.Location = new System.Drawing.Point(748, 458);
            this.DeleteCoach_Button.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteCoach_Button.Name = "DeleteCoach_Button";
            this.DeleteCoach_Button.Size = new System.Drawing.Size(181, 45);
            this.DeleteCoach_Button.TabIndex = 8;
            this.DeleteCoach_Button.Text = "Delete";
            this.DeleteCoach_Button.Click += new System.EventHandler(this.DeleteCoach_Button_Click);
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
            this.id_TextBox.ForeColor = System.Drawing.Color.Black;
            this.id_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id_TextBox.Location = new System.Drawing.Point(286, 7);
            this.id_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id_TextBox.Name = "id_TextBox";
            this.id_TextBox.PasswordChar = '\0';
            this.id_TextBox.PlaceholderText = "";
            this.id_TextBox.SelectedText = "";
            this.id_TextBox.Size = new System.Drawing.Size(456, 41);
            this.id_TextBox.TabIndex = 6;
            this.id_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id_TextBox.Enter += new System.EventHandler(this.id_TextBox_Enter);
            this.id_TextBox.Leave += new System.EventHandler(this.id_TextBox_Leave);
            // 
            // SearchCoach_Button
            // 
            this.SearchCoach_Button.BorderRadius = 20;
            this.SearchCoach_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchCoach_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchCoach_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchCoach_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchCoach_Button.Font = new System.Drawing.Font("Chalkboard SE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCoach_Button.ForeColor = System.Drawing.Color.White;
            this.SearchCoach_Button.Location = new System.Drawing.Point(420, 458);
            this.SearchCoach_Button.Margin = new System.Windows.Forms.Padding(2);
            this.SearchCoach_Button.Name = "SearchCoach_Button";
            this.SearchCoach_Button.Size = new System.Drawing.Size(181, 45);
            this.SearchCoach_Button.TabIndex = 5;
            this.SearchCoach_Button.Text = "Search";
            this.SearchCoach_Button.Click += new System.EventHandler(this.SearchCoach_Button_Click);
            // 
            // DataGridView_Coaches
            // 
            this.DataGridView_Coaches.AllowUserToAddRows = false;
            this.DataGridView_Coaches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Coaches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView_Coaches.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Chalkboard SE", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Coaches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_Coaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Coaches.EnableHeadersVisualStyles = false;
            this.DataGridView_Coaches.Location = new System.Drawing.Point(11, 58);
            this.DataGridView_Coaches.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView_Coaches.Name = "DataGridView_Coaches";
            this.DataGridView_Coaches.Size = new System.Drawing.Size(1006, 394);
            this.DataGridView_Coaches.TabIndex = 9;
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
            this.Refresh_Button.TabIndex = 10;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // Coaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1029, 511);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.DataGridView_Coaches);
            this.Controls.Add(this.DeleteCoach_Button);
            this.Controls.Add(this.id_TextBox);
            this.Controls.Add(this.SearchCoach_Button);
            this.Controls.Add(this.AddCoach_Button);
            this.Font = new System.Drawing.Font("Chalkboard SE", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Coaches";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coaches";
            this.Load += new System.EventHandler(this.Coaches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Coaches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button AddCoach_Button;
        private Guna.UI2.WinForms.Guna2Button DeleteCoach_Button;
        private Guna.UI2.WinForms.Guna2TextBox id_TextBox;
        private Guna.UI2.WinForms.Guna2Button SearchCoach_Button;
        private System.Windows.Forms.DataGridView DataGridView_Coaches;
        private Guna.UI2.WinForms.Guna2CircleButton Refresh_Button;
    }
}