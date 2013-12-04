using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void Test()
        {
            for (int i = 0; i < 8; i=i+2)
            {
                MessageBox.Show("pop up 4x");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Test();
        }
    }
}
