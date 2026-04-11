using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            for (int day = 1; day <= 31; day++)
            {
                cb_day.Items.Add(day);
            }
            cb_day.Text = "-Day-";

            string[] months = { "January", "February", "March", "April", "May", "June",
                                 "July", "August", "September", "October", "November", "December" };
            foreach (string month in months)
            {
                cb_month.Items.Add(month);
            }
            cb_month.Text = "-Month-";

            for (int year = 1940; year <= DateTime.Now.Year; year++)
            {
                cb_year.Items.Add(year);
            }
            cb_year.Text = "-Year-";

            String[] courses = { "BS Computer Science", "BS Information Technology", "BS Information Systems",
                                 "BS Computer Engineering" };
            foreach (String course in courses)
            {
                cb_Course.Items.Add(course);
            }
            cb_Course.Text = "-Select Course-";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(b_lastName.Text) ||
                string.IsNullOrWhiteSpace(b_firstName.Text) ||
                string.IsNullOrWhiteSpace(b_middleName.Text) ||
                cb_Course.SelectedIndex == -1 ||
                cb_day.SelectedIndex == -1 ||
                cb_month.SelectedIndex == -1 ||
                cb_year.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields and select options.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            String lastName = (String)b_lastName.Text;
            String firstName = (String)b_firstName.Text;
            String middleName = (String)b_middleName.Text;
            String course = cb_Course.SelectedItem?.ToString() ?? "N/A";
            String birthDate = $"{cb_month.SelectedItem} {cb_day.SelectedItem}, {cb_year.SelectedItem}";
            String gender = b_female.Checked ? "Female" : b_male.Checked ? "Male" : "N/A";

            Student(firstName,middleName,lastName,course,birthDate,gender);
            Student(firstName, middleName, lastName, course);
            Student(firstName,lastName,course);
          
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp)|*.jpg; *.jpeg; *.gif; *.png; *.bmp";

                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        public void Student(string firstName, string middleName, string lastName, string course, string birthDate, string gender )
        {
            String message = $"Student Name: {firstName}, {middleName}, {lastName}\n" +
                $"Gender: {gender}\n +" +
                $"Date of birth: {birthDate}\n + " +
                $"Program: {course}\n";

            MessageBox.Show(message, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Student(string firstName, string middleName, string lastName, string course)
        {
            String message = $"Student Name: {firstName}, {middleName}, {lastName}\n" +
                $"Program: {course}\n";

            MessageBox.Show(message, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Student(string firstName,  string lastName, string course)
        {
            String message = $"Student Name: {firstName}, {lastName}\n" +        
                $"Program: {course}\n";

            MessageBox.Show(message, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





    }
    }

    