using StudentNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        private int totalStudents = 0;

        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentID.Text.Trim() == "" || txtFirstName.Text.Trim() == "" || txtLastName.Text.Trim() == "")
                    throw new ArgumentException("All fields are required. Please fill in Student ID, First Name, and Last Name.");

                if (!System.Text.RegularExpressions.Regex.IsMatch(txtStudentID.Text.Trim(), @"^\d+$"))
                    throw new FormatException("Student ID must contain numbers only.");

                if (txtStudentID.Text.Trim().Length != 11)
                    throw new ArgumentOutOfRangeException("Student ID must be exactly 11 digits.");

                if (!System.Text.RegularExpressions.Regex.IsMatch(txtFirstName.Text.Trim(), @"^[a-zA-Z\s]+$") ||
                    !System.Text.RegularExpressions.Regex.IsMatch(txtLastName.Text.Trim(), @"^[a-zA-Z\s]+$"))
                    throw new FormatException("First Name and Last Name must contain letters only.");

                StudentInfo student = new StudentInfo(txtStudentID.Text.Trim(), txtFirstName.Text.Trim(), txtLastName.Text.Trim());

                lstStudentID.Items.Add(student.StudentID);
                lstFirstName.Items.Add(student.FirstName);
                lstLastName.Items.Add(student.LastName);

                totalStudents++;
                lblTotalStudent.Text = "Total Student: " + totalStudents;

                txtStudentID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
            }
            catch (ArgumentNullException ex) { MessageBox.Show("Input cannot be null.\n\nDetails: " + ex.Message, "Null Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (ArgumentOutOfRangeException ex) { MessageBox.Show("Input is out of range.\n\nDetails: " + ex.Message, "Out of Range Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (FormatException ex) { MessageBox.Show("Invalid format.\n\nDetails: " + ex.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (ArgumentException ex) { MessageBox.Show("Invalid input.\n\nDetails: " + ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show("Unexpected error.\n\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        
    }
}