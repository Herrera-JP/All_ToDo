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
        // ✅ Declare table at class level so both methods share it
        private DataTable table = new DataTable();

        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }

        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(long));
            table.Columns.Add("First Name", typeof(string));  // ✅ Fixed typo "Firsr"
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Position", typeof(string));

            EmployeeData.DataSource = table;
        }

        private bool validateInput()  // ✅ Returns bool so we can stop execution
        {
            if (string.IsNullOrWhiteSpace(txtEmployee_ID.Text) ||
                string.IsNullOrWhiteSpace(txt_firstName.Text) ||
                string.IsNullOrWhiteSpace(txt_lastName.Text) ||
                string.IsNullOrWhiteSpace(txt_position.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!long.TryParse(txtEmployee_ID.Text, out _))
            {
                MessageBox.Show("Employee ID must be a valid number.", "Input Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            // ✅ Validate FIRST before doing anything
            if (!validateInput()) return;

            Employee employee = new Employee();
            employee.EmployeeNumber = long.Parse(txtEmployee_ID.Text);
            employee.FirstName = txt_firstName.Text;
            employee.LastName = txt_lastName.Text;
            employee.Position = txt_position.Text;

            // ✅ Adds to the shared table that the grid is bound to
            table.Rows.Add(employee.EmployeeNumber, employee.FirstName,
                           employee.LastName, employee.Position);

            // ✅ Clear fields after successful submit
            txtEmployee_ID.Clear();
            txt_firstName.Clear();
            txt_lastName.Clear();
            txt_position.Clear();
        }
    }
}
