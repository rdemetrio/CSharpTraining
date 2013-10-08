namespace LogApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrompt = new System.Windows.Forms.Label();
            this.tbInputString = new System.Windows.Forms.TextBox();
            this.btnLogString = new System.Windows.Forms.Button();
            this.btnDeleteString = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listboxInput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(13, 15);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(74, 13);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Enter a String:";
            // 
            // tbInputString
            // 
            this.tbInputString.Location = new System.Drawing.Point(93, 12);
            this.tbInputString.Name = "tbInputString";
            this.tbInputString.Size = new System.Drawing.Size(289, 20);
            this.tbInputString.TabIndex = 1;
            // 
            // btnLogString
            // 
            this.btnLogString.Location = new System.Drawing.Point(407, 10);
            this.btnLogString.Name = "btnLogString";
            this.btnLogString.Size = new System.Drawing.Size(97, 23);
            this.btnLogString.TabIndex = 2;
            this.btnLogString.Text = "Log";
            this.btnLogString.UseVisualStyleBackColor = true;
            this.btnLogString.Click += new System.EventHandler(this.btnLogString_Click);
            // 
            // btnDeleteString
            // 
            this.btnDeleteString.Location = new System.Drawing.Point(407, 133);
            this.btnDeleteString.Name = "btnDeleteString";
            this.btnDeleteString.Size = new System.Drawing.Size(97, 23);
            this.btnDeleteString.TabIndex = 4;
            this.btnDeleteString.Text = "Delete";
            this.btnDeleteString.UseVisualStyleBackColor = true;
            this.btnDeleteString.Click += new System.EventHandler(this.btnDeleteString_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(407, 53);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(97, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load / Refresh";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(407, 216);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listboxInput
            // 
            this.listboxInput.FormattingEnabled = true;
            this.listboxInput.Location = new System.Drawing.Point(16, 53);
            this.listboxInput.Name = "listboxInput";
            this.listboxInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listboxInput.Size = new System.Drawing.Size(366, 186);
            this.listboxInput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 257);
            this.Controls.Add(this.listboxInput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDeleteString);
            this.Controls.Add(this.btnLogString);
            this.Controls.Add(this.tbInputString);
            this.Controls.Add(this.lblPrompt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logging Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox tbInputString;
        private System.Windows.Forms.Button btnLogString;
        private System.Windows.Forms.Button btnDeleteString;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listboxInput;
    }
}

