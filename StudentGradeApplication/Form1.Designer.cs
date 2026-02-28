namespace StudentGradeApplication
{
    partial class frmStudentGradeProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentGradeProgram));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.b_Name = new System.Windows.Forms.TextBox();
            this.b_English = new System.Windows.Forms.TextBox();
            this.b_Math = new System.Windows.Forms.TextBox();
            this.b_Science = new System.Windows.Forms.TextBox();
            this.b_Filipino = new System.Windows.Forms.TextBox();
            this.b_History = new System.Windows.Forms.TextBox();
            this.computeAverage = new System.Windows.Forms.Button();
            this.showResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "English";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Math";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Science";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Filipino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(122, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "History";
            // 
            // b_Name
            // 
            this.b_Name.Location = new System.Drawing.Point(126, 37);
            this.b_Name.Multiline = true;
            this.b_Name.Name = "b_Name";
            this.b_Name.Size = new System.Drawing.Size(275, 25);
            this.b_Name.TabIndex = 7;
            // 
            // b_English
            // 
            this.b_English.Location = new System.Drawing.Point(207, 121);
            this.b_English.Name = "b_English";
            this.b_English.Size = new System.Drawing.Size(100, 22);
            this.b_English.TabIndex = 8;
            // 
            // b_Math
            // 
            this.b_Math.Location = new System.Drawing.Point(207, 149);
            this.b_Math.Name = "b_Math";
            this.b_Math.Size = new System.Drawing.Size(100, 22);
            this.b_Math.TabIndex = 9;
            // 
            // b_Science
            // 
            this.b_Science.Location = new System.Drawing.Point(207, 177);
            this.b_Science.Name = "b_Science";
            this.b_Science.Size = new System.Drawing.Size(100, 22);
            this.b_Science.TabIndex = 10;
            // 
            // b_Filipino
            // 
            this.b_Filipino.Location = new System.Drawing.Point(207, 205);
            this.b_Filipino.Name = "b_Filipino";
            this.b_Filipino.Size = new System.Drawing.Size(100, 22);
            this.b_Filipino.TabIndex = 11;
            // 
            // b_History
            // 
            this.b_History.Location = new System.Drawing.Point(207, 233);
            this.b_History.Name = "b_History";
            this.b_History.Size = new System.Drawing.Size(100, 22);
            this.b_History.TabIndex = 12;
            // 
            // computeAverage
            // 
            this.computeAverage.Location = new System.Drawing.Point(186, 261);
            this.computeAverage.Name = "computeAverage";
            this.computeAverage.Size = new System.Drawing.Size(121, 46);
            this.computeAverage.TabIndex = 14;
            this.computeAverage.Text = "Generate Average";
            this.computeAverage.UseVisualStyleBackColor = true;
            this.computeAverage.Click += new System.EventHandler(this.computeAverage_Click);
            // 
            // showResult
            // 
            this.showResult.AutoSize = true;
            this.showResult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showResult.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showResult.Location = new System.Drawing.Point(66, 325);
            this.showResult.Name = "showResult";
            this.showResult.Size = new System.Drawing.Size(65, 23);
            this.showResult.TabIndex = 15;
            this.showResult.Text = "Result";
            this.showResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showResult.Visible = false;
            // 
            // frmStudentGradeProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.showResult);
            this.Controls.Add(this.computeAverage);
            this.Controls.Add(this.b_History);
            this.Controls.Add(this.b_Filipino);
            this.Controls.Add(this.b_Science);
            this.Controls.Add(this.b_Math);
            this.Controls.Add(this.b_English);
            this.Controls.Add(this.b_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStudentGradeProgram";
            this.Text = "frmStudentGradeProgram";
            this.Load += new System.EventHandler(this.frmStudentGradeProgram_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox b_Name;
        private System.Windows.Forms.TextBox b_English;
        private System.Windows.Forms.TextBox b_Math;
        private System.Windows.Forms.TextBox b_Science;
        private System.Windows.Forms.TextBox b_Filipino;
        private System.Windows.Forms.TextBox b_History;
        private System.Windows.Forms.Button computeAverage;
        private System.Windows.Forms.Label showResult;
    }
}

