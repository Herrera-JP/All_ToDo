using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
       
    { 
        public frmEmployeeDatabase()
        {
            
            InitializeComponent();
        }    
        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(long));
            table.Columns.Add("Firsr name", typeof(string));
            table.Columns.Add("Last name", typeof(string));
            table.Columns.Add("Position", typeof(string));

            EmployeeData.DataSource = table;

            
        }

        public void validateInput()
        {
            if (string.IsNullOrWhiteSpace(txtEmployee_ID.Text) ||
                string.IsNullOrWhiteSpace(txt_firstName.Text) ||
                string.IsNullOrWhiteSpace(txt_lastName.Text) ||
                string.IsNullOrWhiteSpace(txt_position.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!long.TryParse(txtEmployee_ID.Text, out _))
            {
                MessageBox.Show("Employee ID must be a valid number.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            Employee employee = new Employee();

            employee.EmployeeNumber = long.Parse(txtEmployee_ID.Text);
            employee.FirstName = txt_firstName.Text;
            employee.LastName = txt_lastName.Text;
            employee.Position = txt_position.Text;

            validateInput();
            table.Rows.Add(employee.EmployeeNumber, employee.FirstName, employee.LastName, employee.Position);
        }
    }
}
