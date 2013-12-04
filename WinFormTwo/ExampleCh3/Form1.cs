using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExampleCh3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int len = Talker.TestStringParameters(textBox1.Text, (int)numericUpDown1.Value);
           MessageBox.Show(string.Format("The message length is {0}.", len.ToString()));

           Guy.GiveCash(50);
           Guy.ReceiveCash(25);
           

           
        }

       
    }
}
