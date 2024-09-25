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

        private void button1_Click(object sender, EventArgs e)
        {
            string name = studName.Text;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" 
                || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Please enter all required grades.");
            }
            else if (name == "") {
                MessageBox.Show("Please enter the student name.");
            }
            else
            {
                double english = double.Parse(textBox1.Text);
                double math = double.Parse(textBox2.Text);
                double science = double.Parse(textBox3.Text);
                double filipino = double.Parse(textBox4.Text);
                double history = double.Parse(textBox5.Text);
                double computer = double.Parse(textBox6.Text);
                double average = (english + math + science + filipino + history + computer) / 6;

                result r = new result(name, average);
                r.Show();

            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studName.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
;           textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
