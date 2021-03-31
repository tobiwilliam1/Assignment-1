using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            ___.Items.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            Char[] mychar = { ' ',',', ';', '?' };
            string[] word = textBox3.Text.Split(mychar);
             ___.Items.Clear();
            foreach(string item in word)
            {
                if (item.Length > 0)
                {
                    ___.Items.Add(item);
                    i = i + 1;
                }
          }
            textBox1.Text = i.ToString();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
