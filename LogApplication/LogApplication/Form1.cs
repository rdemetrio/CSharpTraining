using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LogApplication
{
    public partial class Form1 : Form
    {
        string input, format, stamp, filename;

        public Form1()
        {
            InitializeComponent();
            listboxInput.Visible = false;

            DateTime logTime = DateTime.Now;
            format = "yyyy-MMM-d HH:mm:ss ";
            stamp = logTime.ToString(format);
            filename = @"C:\Users\rdemetrio\Documents\GitHub\CSharpTraining\FileLog.txt";
        }

        //Load and display log file
        private void LoadAndDisplayLogFile()
        {
            //check to see if the file is created
            if (File.Exists(filename))
            {
                //Clear the list box contents before reloading
                listboxInput.Items.Clear();
                
                //string line;
                using (StreamReader sR = new StreamReader(filename))
                {
                    //Read each line out of the file and populate our listbox
                    string curLine;
                    while ((curLine = sR.ReadLine()) != null)
                    {
                        //As long as we don't read a null value back (end of the file),
                        //add each line from the source file to the list box
                        listboxInput.Items.Add(curLine);
                    }
                }
            }
            else
            {
                throw new FileNotFoundException(string.Format("Source file \"{0}\" not found.", filename));
            }
        }
        
        //log input 
        private void btnLogString_Click(object sender, EventArgs e)
        {
            try
            {
                input = tbInputString.Text.Trim();

                if (input != string.Empty)
                {
                    //Set the FileMode value that we're going to use for the file stream,
                    //based on whether the file exists or not
                    FileMode fMode;
                    if (File.Exists(filename))
                    {
                        //The file exists, so append to it
                        fMode = FileMode.Append;
                    }
                    else
                    {
                        //The file doesn't exist, so create a new one
                        fMode = FileMode.Create;
                    }

                    //Create the stream to the output file
                    using (FileStream outputFile = new FileStream(filename, fMode))
                    //Create a writer to write to the output stream
                    using (TextWriter writer = new StreamWriter(outputFile))
                    {
                        writer.WriteLine(string.Format("{0} {1}", input, stamp));
                    }

                    LoadAndDisplayLogFile();
                    
                    tbInputString.Focus();
                }
                else
                {
                    //throw new Exception();
                    throw new ApplicationException("No log entry provided.");
                }
            }
            catch
            {
                MessageBox.Show("Input field cannot be empty", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            tbInputString.Clear();
           
        }

        //load content from the file
        private void btnLoad_Click(object sender, EventArgs e)
        {
            listboxInput.Visible = true;
            try
            {
                LoadAndDisplayLogFile();
            }
            catch(Exception ex)
            {
                //MessageBox.Show("File does not exist.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(string.Format("**ERROR** - {0}", ex.Message), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //delete item from list
        private void btnDeleteString_Click(object sender, EventArgs e)
        {
            //int selectedIndex = listboxInput.SelectedIndex;

            try
            {
                int selectedIndex = listboxInput.SelectedIndex;
                if (selectedIndex == -1)
                    throw new ApplicationException("No item selected to delete.");
                
                //lines.RemoveAt(selectedIndex);
                listboxInput.Items.RemoveAt(selectedIndex);

                //We are overwriting the existing output file with the list box contents
                using (FileStream outputFile = new FileStream(filename, FileMode.Create))
                using (TextWriter writer = new StreamWriter(outputFile))
                {
                    foreach (string line in listboxInput.Items)
                        writer.WriteLine(line);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Item deleted, file has been updated.", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //exits application 
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "End Application?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.OK:
                    {
                        Application.Exit();
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        this.Text = "[Cancel]";
                        break;
                    }
            }
        }
    }
}
