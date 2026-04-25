namespace EmployeeApplication
{
    partial class frmEmployeeDatabase
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmployee_ID = new System.Windows.Forms.Label();
            this.txtEmployee_ID = new System.Windows.Forms.TextBox();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.lbl_position = new System.Windows.Forms.Label();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.EmployeeData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeData)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblEmployee_ID);
            this.flowLayoutPanel1.Controls.Add(this.txtEmployee_ID);
            this.flowLayoutPanel1.Controls.Add(this.lbl_firstName);
            this.flowLayoutPanel1.Controls.Add(this.txt_firstName);
            this.flowLayoutPanel1.Controls.Add(this.lbl_lastName);
            this.flowLayoutPanel1.Controls.Add(this.txt_lastName);
            this.flowLayoutPanel1.Controls.Add(this.lbl_position);
            this.flowLayoutPanel1.Controls.Add(this.txt_position);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(190, 204);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblEmployee_ID
            // 
            this.lblEmployee_ID.AutoSize = true;
            this.lblEmployee_ID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee_ID.Location = new System.Drawing.Point(3, 0);
            this.lblEmployee_ID.Name = "lblEmployee_ID";
            this.lblEmployee_ID.Size = new System.Drawing.Size(101, 19);
            this.lblEmployee_ID.TabIndex = 2;
            this.lblEmployee_ID.Text = "Employee ID *";
            // 
            // txtEmployee_ID
            // 
            this.txtEmployee_ID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmployee_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployee_ID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee_ID.Location = new System.Drawing.Point(3, 22);
            this.txtEmployee_ID.Name = "txtEmployee_ID";
            this.txtEmployee_ID.Size = new System.Drawing.Size(187, 26);
            this.txtEmployee_ID.TabIndex = 6;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstName.Location = new System.Drawing.Point(3, 51);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(84, 19);
            this.lbl_firstName.TabIndex = 3;
            this.lbl_firstName.Text = "First name *";
            // 
            // txt_firstName
            // 
            this.txt_firstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_firstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_firstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstName.Location = new System.Drawing.Point(3, 73);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(187, 26);
            this.txt_firstName.TabIndex = 7;
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastName.Location = new System.Drawing.Point(3, 102);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(83, 19);
            this.lbl_lastName.TabIndex = 4;
            this.lbl_lastName.Text = "Last name *";
            // 
            // txt_lastName
            // 
            this.txt_lastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_lastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastName.Location = new System.Drawing.Point(3, 124);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(187, 26);
            this.txt_lastName.TabIndex = 8;
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_position.Location = new System.Drawing.Point(3, 153);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(69, 19);
            this.lbl_position.TabIndex = 5;
            this.lbl_position.Text = "Position *";
            // 
            // txt_position
            // 
            this.txt_position.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_position.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_position.Location = new System.Drawing.Point(3, 175);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(187, 26);
            this.txt_position.TabIndex = 9;
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.Location = new System.Drawing.Point(12, 30);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(142, 24);
            this.lblAddEmployee.TabIndex = 1;
            this.lblAddEmployee.Text = "AddEmployee:";
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(53, 277);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(112, 28);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // EmployeeData
            // 
            this.EmployeeData.BackgroundColor = System.Drawing.Color.Silver;
            this.EmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeData.GridColor = System.Drawing.Color.Teal;
            this.EmployeeData.Location = new System.Drawing.Point(208, 57);
            this.EmployeeData.Name = "EmployeeData";
            this.EmployeeData.Size = new System.Drawing.Size(443, 248);
            this.EmployeeData.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee list:";
            // 
            // frmEmployeeDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(674, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeData);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lblAddEmployee);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(690, 350);
            this.MinimumSize = new System.Drawing.Size(690, 350);
            this.Name = "frmEmployeeDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployeeDatabase";
            this.Load += new System.EventHandler(this.frmEmployeeDatabase_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.Label lblEmployee_ID;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.TextBox txtEmployee_ID;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.DataGridView EmployeeData;
        private System.Windows.Forms.Label label1;
    }
}

