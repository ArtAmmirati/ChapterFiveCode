namespace Tutorial5_9EventHandler
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
            this.exitBTN = new System.Windows.Forms.Button();
            this.countriesLB = new System.Windows.Forms.Label();
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(97, 211);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTN.TabIndex = 0;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // countriesLB
            // 
            this.countriesLB.AutoSize = true;
            this.countriesLB.Location = new System.Drawing.Point(12, 9);
            this.countriesLB.Name = "countriesLB";
            this.countriesLB.Size = new System.Drawing.Size(157, 13);
            this.countriesLB.TabIndex = 1;
            this.countriesLB.Text = "The Countries of South America\r\n";
            // 
            // countriesListBox
            // 
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.Location = new System.Drawing.Point(35, 25);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(216, 173);
            this.countriesListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.countriesListBox);
            this.Controls.Add(this.countriesLB);
            this.Controls.Add(this.exitBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label countriesLB;
        private System.Windows.Forms.ListBox countriesListBox;
    }
}

