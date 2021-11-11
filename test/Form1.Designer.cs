
namespace test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sendRead = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rcvData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendRead
            // 
            this.sendRead.Location = new System.Drawing.Point(82, 138);
            this.sendRead.Multiline = true;
            this.sendRead.Name = "sendRead";
            this.sendRead.Size = new System.Drawing.Size(100, 82);
            this.sendRead.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rcvData
            // 
            this.rcvData.Location = new System.Drawing.Point(346, 138);
            this.rcvData.Multiline = true;
            this.rcvData.Name = "rcvData";
            this.rcvData.Size = new System.Drawing.Size(100, 82);
            this.rcvData.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rcvData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sendRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sendRead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox rcvData;
    }
}

