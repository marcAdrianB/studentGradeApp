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
    public partial class result : Form
    {
        public result(string name, double average)
        {
            InitializeComponent();

            resultLabel.Text = average >= 75.00 ? "The student passed.\nThe general average of " + name + " is " 
                + average.ToString("#.##") : "The student failed.\nThe general average of " + name + " is " + average.ToString("#.##");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
    }
}
