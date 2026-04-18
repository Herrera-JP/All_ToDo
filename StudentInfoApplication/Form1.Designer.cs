namespace StudentInfoApplication
{
    partial class frmStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentInfo));
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFistName = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lstStudentID = new System.Windows.Forms.ListBox();
            this.lstLastName = new System.Windows.Forms.ListBox();
            this.lstFirstName = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotalStudent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentId.Location = new System.Drawing.Point(134, 85);
            this.lblStudentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(141, 25);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student ID *";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLastName.Location = new System.Drawing.Point(334, 85);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(135, 25);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last name *";
            // 
            // lblFistName
            // 
            this.lblFistName.AutoSize = true;
            this.lblFistName.BackColor = System.Drawing.Color.Transparent;
            this.lblFistName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblFistName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFistName.Location = new System.Drawing.Point(532, 85);
            this.lblFistName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFistName.Name = "lblFistName";
            this.lblFistName.Size = new System.Drawing.Size(138, 25);
            this.lblFistName.TabIndex = 2;
            this.lblFistName.Text = "First name *";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(139, 114);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(136, 30);
            this.txtStudentID.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(339, 114);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(136, 30);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(537, 114);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(136, 30);
            this.txtFirstName.TabIndex = 5;
            // 
            // lstStudentID
            // 
            this.lstStudentID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lstStudentID.ForeColor = System.Drawing.Color.White;
            this.lstStudentID.FormattingEnabled = true;
            this.lstStudentID.ItemHeight = 23;
            this.lstStudentID.Location = new System.Drawing.Point(139, 174);
            this.lstStudentID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstStudentID.Name = "lstStudentID";
            this.lstStudentID.Size = new System.Drawing.Size(175, 234);
            this.lstStudentID.TabIndex = 6;
            // 
            // lstLastName
            // 
            this.lstLastName.BackColor = System.Drawing.SystemColors.Highlight;
            this.lstLastName.ForeColor = System.Drawing.Color.White;
            this.lstLastName.FormattingEnabled = true;
            this.lstLastName.ItemHeight = 23;
            this.lstLastName.Location = new System.Drawing.Point(339, 174);
            this.lstLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstLastName.Name = "lstLastName";
            this.lstLastName.Size = new System.Drawing.Size(175, 234);
            this.lstLastName.TabIndex = 7;
            // 
            // lstFirstName
            // 
            this.lstFirstName.BackColor = System.Drawing.SystemColors.Highlight;
            this.lstFirstName.ForeColor = System.Drawing.Color.White;
            this.lstFirstName.FormattingEnabled = true;
            this.lstFirstName.ItemHeight = 23;
            this.lstFirstName.Location = new System.Drawing.Point(537, 174);
            this.lstFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstFirstName.Name = "lstFirstName";
            this.lstFirstName.Size = new System.Drawing.Size(175, 234);
            this.lstFirstName.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(139, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTotalStudent
            // 
            this.lblTotalStudent.AutoSize = true;
            this.lblTotalStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalStudent.Location = new System.Drawing.Point(400, 439);
            this.lblTotalStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalStudent.Name = "lblTotalStudent";
            this.lblTotalStudent.Size = new System.Drawing.Size(128, 23);
            this.lblTotalStudent.TabIndex = 10;
            this.lblTotalStudent.Text = "Total student:";
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 506);
            this.Controls.Add(this.lblTotalStudent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstFirstName);
            this.Controls.Add(this.lstLastName);
            this.Controls.Add(this.lstStudentID);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblFistName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblStudentId);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStudentInfo";
            this.Text = "frmStudentInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFistName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ListBox lstStudentID;
        private System.Windows.Forms.ListBox lstLastName;
        private System.Windows.Forms.ListBox lstFirstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotalStudent;
    }
}

