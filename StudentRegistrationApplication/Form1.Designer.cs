namespace StudentRegistrationApplication
{
    partial class frmStudentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentRegistration));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.b_lastName = new System.Windows.Forms.TextBox();
            this.b_firstName = new System.Windows.Forms.TextBox();
            this.b_middleName = new System.Windows.Forms.TextBox();
            this.b_male = new System.Windows.Forms.RadioButton();
            this.b_female = new System.Windows.Forms.RadioButton();
            this.cb_day = new System.Windows.Forms.ComboBox();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Course = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name *";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "First name *";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Middle name *";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of birth *";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender *";
            // 
            // b_lastName
            // 
            this.b_lastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_lastName.BackColor = System.Drawing.Color.White;
            this.b_lastName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_lastName.Location = new System.Drawing.Point(9, 77);
            this.b_lastName.Margin = new System.Windows.Forms.Padding(2);
            this.b_lastName.Name = "b_lastName";
            this.b_lastName.Size = new System.Drawing.Size(283, 26);
            this.b_lastName.TabIndex = 6;
            // 
            // b_firstName
            // 
            this.b_firstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_firstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_firstName.Location = new System.Drawing.Point(9, 136);
            this.b_firstName.Margin = new System.Windows.Forms.Padding(2);
            this.b_firstName.Name = "b_firstName";
            this.b_firstName.Size = new System.Drawing.Size(283, 26);
            this.b_firstName.TabIndex = 7;
            // 
            // b_middleName
            // 
            this.b_middleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_middleName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_middleName.Location = new System.Drawing.Point(9, 193);
            this.b_middleName.Margin = new System.Windows.Forms.Padding(2);
            this.b_middleName.Name = "b_middleName";
            this.b_middleName.Size = new System.Drawing.Size(283, 26);
            this.b_middleName.TabIndex = 8;
            // 
            // b_male
            // 
            this.b_male.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_male.AutoSize = true;
            this.b_male.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_male.Location = new System.Drawing.Point(84, 228);
            this.b_male.Margin = new System.Windows.Forms.Padding(2);
            this.b_male.Name = "b_male";
            this.b_male.Size = new System.Drawing.Size(60, 22);
            this.b_male.TabIndex = 9;
            this.b_male.TabStop = true;
            this.b_male.Text = "Male";
            this.b_male.UseVisualStyleBackColor = true;
            // 
            // b_female
            // 
            this.b_female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_female.AutoSize = true;
            this.b_female.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_female.Location = new System.Drawing.Point(148, 228);
            this.b_female.Margin = new System.Windows.Forms.Padding(2);
            this.b_female.Name = "b_female";
            this.b_female.Size = new System.Drawing.Size(79, 22);
            this.b_female.TabIndex = 10;
            this.b_female.TabStop = true;
            this.b_female.Text = "Female";
            this.b_female.UseVisualStyleBackColor = true;
            // 
            // cb_day
            // 
            this.cb_day.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_day.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_day.FormattingEnabled = true;
            this.cb_day.Location = new System.Drawing.Point(9, 276);
            this.cb_day.Margin = new System.Windows.Forms.Padding(2);
            this.cb_day.Name = "cb_day";
            this.cb_day.Size = new System.Drawing.Size(92, 26);
            this.cb_day.TabIndex = 11;
            // 
            // cb_month
            // 
            this.cb_month.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_month.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_month.FormattingEnabled = true;
            this.cb_month.Location = new System.Drawing.Point(105, 276);
            this.cb_month.Margin = new System.Windows.Forms.Padding(2);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(92, 26);
            this.cb_month.TabIndex = 12;
            // 
            // cb_year
            // 
            this.cb_year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_year.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Location = new System.Drawing.Point(201, 276);
            this.cb_year.Margin = new System.Windows.Forms.Padding(2);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(92, 26);
            this.cb_year.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(84, 355);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Register Student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 304);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Program to apply*";
            // 
            // cb_Course
            // 
            this.cb_Course.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Course.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Course.FormattingEnabled = true;
            this.cb_Course.Location = new System.Drawing.Point(9, 325);
            this.cb_Course.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Course.Name = "cb_Course";
            this.cb_Course.Size = new System.Drawing.Size(276, 26);
            this.cb_Course.TabIndex = 17;
            // 
            // frmStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.cb_Course);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_year);
            this.Controls.Add(this.cb_month);
            this.Controls.Add(this.cb_day);
            this.Controls.Add(this.b_female);
            this.Controls.Add(this.b_male);
            this.Controls.Add(this.b_middleName);
            this.Controls.Add(this.b_firstName);
            this.Controls.Add(this.b_lastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStudentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentRegistration";
            this.Load += new System.EventHandler(this.frmStudentRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox b_lastName;
        private System.Windows.Forms.TextBox b_firstName;
        private System.Windows.Forms.TextBox b_middleName;
        private System.Windows.Forms.RadioButton b_male;
        private System.Windows.Forms.RadioButton b_female;
        private System.Windows.Forms.ComboBox cb_day;
        private System.Windows.Forms.ComboBox cb_month;
        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Course;
    }
}

