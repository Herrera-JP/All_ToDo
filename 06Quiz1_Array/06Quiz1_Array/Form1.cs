using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Quiz1_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] Classmates = { "Arnel", "Clark", "Rodd", "Dustine", "Raine", "Renz" };

            foreach (String Classmate in Classmates)
            {
                List.Items.Add(Classmate);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String textBox = textBox1.Text;
            if (textBox == "hello")
            {
                MessageBox.Show("Your right");
            }
            else
            {
                MessageBox.Show("Your wrong");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        

    }
    }
