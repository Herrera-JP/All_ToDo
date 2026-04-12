using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herrera_StudentGradeAnalyzer
{
    public partial class studentgradefrm : Form
    {
        DataTable table = new DataTable("table");

        public struct StudentData
        {
            public string StudentNumber;
            public string Name;
            public double Prelim;
            public double Midterm;
            public double PreFinal;
            public double Final;
            public double Average;
            public string Remarks;
        }

        public studentgradefrm()
        {
            InitializeComponent();
        }

        private void studentgradefrm_Load(object sender, EventArgs e)
        {
            
            table.Columns.Add("Student Number", typeof(long));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Prelim", typeof(double));
            table.Columns.Add("Midterm", typeof(double));
            table.Columns.Add("Pre-Final", typeof(double));
            table.Columns.Add("Final", typeof(double));
            table.Columns.Add("Average", typeof(double));
            table.Columns.Add("Remarks", typeof(string));

            studentData.DataSource = table;

            studentData.EnableHeadersVisualStyles = false;
            studentData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 90, 108);
            studentData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            studentData.DefaultCellStyle.BackColor = Color.FromArgb(44, 50, 90);
            studentData.DefaultCellStyle.ForeColor = Color.White;
            studentData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(54, 60, 100);
            studentData.RowHeadersVisible = false;
            studentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out double p, out double m, out double pf, out double f))
            {
                StudentData s = new StudentData
                {
                    StudentNumber = txtStudentNumber.Text,
                    Name = txtStudentName.Text,
                    Prelim = p,
                    Midterm = m,
                    PreFinal = pf,
                    Final = f
                };

                s.Average = CalculateAverage(p, m, pf, f);
                s.Remarks = GetRemarks(s.Average);

                AddStudentRecord(s);
            }
        }

        public bool ValidateInput(out double p, out double m, out double pf, out double f)
        {
            p = m = pf = f = 0;

            if (string.IsNullOrWhiteSpace(txtStudentNumber.Text) ||
                string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                string.IsNullOrWhiteSpace(txtPrelim.Text) ||
                string.IsNullOrWhiteSpace(txtMidterm.Text) ||
                string.IsNullOrWhiteSpace(txtPreFinal.Text) ||
                string.IsNullOrWhiteSpace(txtFinal.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            if (txtStudentName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name should not contain numbers.");
                return false;
            }

            if (!long.TryParse(txtStudentNumber.Text, out _))
            {
                MessageBox.Show("Invalid Student Number.");
                return false;
            }

            if (!double.TryParse(txtPrelim.Text, out p) ||
                !double.TryParse(txtMidterm.Text, out m) ||
                !double.TryParse(txtPreFinal.Text, out pf) ||
                !double.TryParse(txtFinal.Text, out f))
            {
                MessageBox.Show("Grades must be numbers.");
                return false;
            }

            if (p < 0 || p > 100 || m < 0 || m > 100 ||
                pf < 0 || pf > 100 || f < 0 || f > 100)
            {
                MessageBox.Show("Grades must be between 0 and 100.");
                return false;
            }

            return true;
        }


        public double CalculateAverage(double a, double b)
        {
            return (a + b) / 2;
        }

        public double CalculateAverage(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }

        public double CalculateAverage(double a, double b, double c, double d)
        {
            return (a + b + c + d) / 4;
        }

        public static string GetRemarks(double avg)
        {
            return avg >= 75 ? "Passed" : "Failed";
        }

        public void AddStudentRecord(StudentData s)
        {
            table.Rows.Add(
                s.StudentNumber,
                s.Name,
                s.Prelim,
                s.Midterm,
                s.PreFinal,
                s.Final,
                s.Average,
                s.Remarks
            );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentNumber.Clear();
            txtStudentName.Clear();
            txtPrelim.Clear();
            txtMidterm.Clear();
            txtPreFinal.Clear();
            txtFinal.Clear();

            table.Rows.Clear();
            txtStudentNumber.Focus();
        }

        
    }
}