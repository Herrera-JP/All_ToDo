using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }

        private void frmStudentGradeProgram_Load(object sender, EventArgs e)
        {

        }

        private void computeAverage_Click(object sender, EventArgs e)
        {
            String name = b_Name.Text;
            double english = Double.Parse(b_English.Text);
            double math = Double.Parse(b_Math.Text);
            double science = Double.Parse(b_Science.Text);
            double filipino = Double.Parse(b_Filipino.Text);
            double history = Double.Parse(b_History.Text);
            double result = (english +  math + science + filipino + history) / 5;

            if (result >= 75)
            {
                showResult.Text = $" The Student passed." +
                         $"\nThe general average of {name} is {result:F2}";
                showResult.Visible = true;


            }
            else
            {
                showResult.Text = $" The Student failed" +
                          $"\nThe general average of {name} is {result:F2}";
                showResult.Visible = true;
            }
        }
    }
}
