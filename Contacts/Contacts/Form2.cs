using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //for (int i = 0; i < 5; i++)
            //{
            //    count = count - 1;
            //}

            for (int c = 0; c < 253; c++)
            {
                this.BackColor = Color.FromArgb(c, 255 - c, c);

                Application.DoEvents();
                
            }

           

            
        }
    }
}
