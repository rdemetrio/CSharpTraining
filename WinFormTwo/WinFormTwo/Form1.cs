using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Quentin";
            int x=3;
            x = x * 17;
            double d = Math.PI / 2;
            MessageBox.Show("name is " +name + "\nx is " + x + "\nd is " +d,"Not Important",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int someValue = 8;
            if(someValue == 24)
            {
                MessageBox.Show("The value was 24.");
            }
            else
            {
                MessageBox.Show("The value was not 24.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int someValue = 4;
            string name  = "bob bobertson";
            if((someValue ==3) && (name == "Joe"))
            {
                MessageBox.Show("x is 3 and the name is joe");
            }
            else
            {
                MessageBox.Show("the name is not joe it's bob bobertson and the value is not 3");
            }
            MessageBox.Show("this line runs no matter what");
        }
    }
}
