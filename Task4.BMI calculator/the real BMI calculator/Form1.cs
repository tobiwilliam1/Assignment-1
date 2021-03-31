using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_real_BMI_calculator
{
    public partial class Form1 : Form
    {
        Double height;
        Double weight;
        Double total;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {
            txt_BMI.BackColor = Color.White;
            height = Double.Parse(txt_Height.Text);
            weight = Double.Parse(txt_Weight.Text);

            total = weight / (height * height);
            txt_BMI.Text = String.Format("{0:f}", total);

            if (total <= 24.9)
            {
                txt_BMI.BackColor = Color.PowderBlue;
            }
            else if (total<= 29.9)
            {
                txt_BMI.BackColor = Color.Blue;
            }
          
            else if (total <= 34.9)
            {
                txt_BMI.BackColor = Color.Yellow;
            }
            else if (total <= 39.9)
            {
                txt_BMI.BackColor = Color.Red;
            }
            else if (total <= 40)
            {
                txt_BMI.BackColor = Color.DarkRed;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            txt_BMI.Text = "";
            txt_Height.Clear();
            txt_Weight.Clear();
            txt_BMI.BackColor = Color.White;
        }

        private void txt_BMI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
