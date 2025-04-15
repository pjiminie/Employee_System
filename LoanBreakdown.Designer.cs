namespace Employee1
{
    partial class LoanBreakdown
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDeptCode = new System.Windows.Forms.Label();
            this.lblDeptDesc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loanGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loanGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Noto Sans JP SemiBold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(24, 166);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 21);
            this.lblName.TabIndex = 341;
            this.lblName.Text = "Name:";
            // 
            // lblDeptCode
            // 
            this.lblDeptCode.AutoSize = true;
            this.lblDeptCode.Font = new System.Drawing.Font("Noto Sans JP SemiBold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDeptCode.Location = new System.Drawing.Point(175, 215);
            this.lblDeptCode.Name = "lblDeptCode";
            this.lblDeptCode.Size = new System.Drawing.Size(0, 21);
            this.lblDeptCode.TabIndex = 342;
            // 
            // lblDeptDesc
            // 
            this.lblDeptDesc.AutoSize = true;
            this.lblDeptDesc.Font = new System.Drawing.Font("Noto Sans JP SemiBold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDeptDesc.Location = new System.Drawing.Point(220, 267);
            this.lblDeptDesc.Name = "lblDeptDesc";
            this.lblDeptDesc.Size = new System.Drawing.Size(0, 21);
            this.lblDeptDesc.TabIndex = 343;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans JP SemiBold", 17F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(102, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 42);
            this.label3.TabIndex = 344;
            this.label3.Text = "EMPLOYEE DETAILS";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Noto Sans JP SemiBold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEmpID.Location = new System.Drawing.Point(137, 125);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(0, 21);
            this.lblEmpID.TabIndex = 345;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans JP SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(22, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 36);
            this.label5.TabIndex = 350;
            this.label5.Text = "Breakdown:";
            // 
            // loanGrid
            // 
            this.loanGrid.AllowUserToAddRows = false;
            this.loanGrid.AllowUserToDeleteRows = false;
            this.loanGrid.BackgroundColor = System.Drawing.Color.White;
            this.loanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanGrid.Location = new System.Drawing.Point(28, 364);
            this.loanGrid.Name = "loanGrid";
            this.loanGrid.ReadOnly = true;
            this.loanGrid.RowHeadersWidth = 51;
            this.loanGrid.RowTemplate.Height = 24;
            this.loanGrid.Size = new System.Drawing.Size(447, 180);
            this.loanGrid.TabIndex = 351;
            this.loanGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loanGrid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans JP SemiBold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 352;
            this.label1.Text = "Employee ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans JP SemiBold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(88, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 353;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans JP SemiBold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(24, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 21);
            this.label4.TabIndex = 354;
            this.label4.Text = "Department Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans JP SemiBold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(24, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 21);
            this.label6.TabIndex = 355;
            this.label6.Text = "Department Description:";
            // 
            // LoanBreakdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 567);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loanGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDeptDesc);
            this.Controls.Add(this.lblDeptCode);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoanBreakdown";
            this.Text = "EmployeeInfo";
            this.Load += new System.EventHandler(this.EmployeeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loanGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDeptCode;
        private System.Windows.Forms.Label lblDeptDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView loanGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}