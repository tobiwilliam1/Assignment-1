using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pounds_to_kilograms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pound = (double)numericUpDown1.Value;
            double Answer = pound * 0.453592;
            label3.Text = Answer.ToString() + "Kilograms";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Kilogram = (double)numericUpDown2.Value;
            double Answer2 = Kilogram * 2.20462;
            label3.Text = Answer2.ToString() + "Pounds"; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            label3.Text = "Answer:";
        }

       
    }
}
