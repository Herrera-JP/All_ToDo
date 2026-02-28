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
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(b_lastName.Text) ||
                string.IsNullOrWhiteSpace(b_firstName.Text) ||
                string.IsNullOrWhiteSpace(b_middleName.Text) ||
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
            String birthDate = $"{cb_month.SelectedItem} {cb_day.SelectedItem}, {cb_year.SelectedItem}";
            String gender = b_female.Checked ? "Female" : b_male.Checked ? "Male" : "N/A";
            String message = $"Student Name: {lastName}, {firstName} {middleName}\n" +
                             $"Gender: {gender}\n" +
                             $"Birth Date: {birthDate}";

            MessageBox.Show(message, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
    }

