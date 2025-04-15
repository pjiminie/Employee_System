namespace Employee1
{
    partial class AddNewLoan
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
            this.amount = new Guna.UI2.WinForms.Guna2TextBox();
            this.date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddStu = new Guna.UI2.WinForms.Guna2Button();
            this.eID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.Animated = true;
            this.amount.AutoRoundedCorners = true;
            this.amount.BorderColor = System.Drawing.Color.Black;
            this.amount.BorderRadius = 15;
            this.amount.BorderThickness = 2;
            this.amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amount.DefaultText = "";
            this.amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.Color.Black;
            this.amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))));
            this.amount.Location = new System.Drawing.Point(130, 214);
            this.amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amount.Name = "amount";
            this.amount.PasswordChar = '\0';
            this.amount.PlaceholderForeColor = System.Drawing.Color.White;
            this.amount.PlaceholderText = "";
            this.amount.SelectedText = "";
            this.amount.Size = new System.Drawing.Size(254, 33);
            this.amount.TabIndex = 326;
            // 
            // date
            // 
            this.date.Animated = true;
            this.date.AutoRoundedCorners = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(161)))), ((int)(((byte)(38)))));
            this.date.BorderRadius = 15;
            this.date.Checked = true;
            this.date.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))));
            this.date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date.Location = new System.Drawing.Point(130, 289);
            this.date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(254, 33);
            this.date.TabIndex = 325;
            this.date.UseTransparentBackground = true;
            this.date.Value = new System.DateTime(2025, 4, 13, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Noto Sans JP SemiBold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(134, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 21);
            this.label9.TabIndex = 324;
            this.label9.Text = "Loan Amount:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Noto Sans JP SemiBold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(134, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 21);
            this.label11.TabIndex = 323;
            this.label11.Text = "Loan Date:";
            // 
            // btnAddStu
            // 
            this.btnAddStu.Animated = true;
            this.btnAddStu.AutoRoundedCorners = true;
            this.btnAddStu.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStu.BorderRadius = 19;
            this.btnAddStu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnAddStu.BorderThickness = 1;
            this.btnAddStu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStu.FillColor = System.Drawing.Color.Khaki;
            this.btnAddStu.Font = new System.Drawing.Font("Noto Sans JP SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddStu.ForeColor = System.Drawing.Color.Black;
            this.btnAddStu.Location = new System.Drawing.Point(189, 398);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(112, 41);
            this.btnAddStu.TabIndex = 328;
            this.btnAddStu.Text = "ADD";
            this.btnAddStu.UseTransparentBackground = true;
            this.btnAddStu.Click += new System.EventHandler(this.btnAddStu_Click);
            // 
            // eID
            // 
            this.eID.AutoRoundedCorners = true;
            this.eID.BackColor = System.Drawing.Color.Transparent;
            this.eID.BorderColor = System.Drawing.Color.Black;
            this.eID.BorderRadius = 17;
            this.eID.BorderThickness = 2;
            this.eID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.eID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.eID.ForeColor = System.Drawing.Color.Black;
            this.eID.ItemHeight = 30;
            this.eID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.eID.Location = new System.Drawing.Point(131, 119);
            this.eID.Name = "eID";
            this.eID.Size = new System.Drawing.Size(254, 36);
            this.eID.TabIndex = 341;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans JP SemiBold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(134, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 340;
            this.label7.Text = "Employee ID:";
            // 
            // AddNewLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(527, 537);
            this.Controls.Add(this.eID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddStu);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewLoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox amount;
        private Guna.UI2.WinForms.Guna2DateTimePicker date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button btnAddStu;
        private Guna.UI2.WinForms.Guna2ComboBox eID;
        private System.Windows.Forms.Label label7;
    }
}