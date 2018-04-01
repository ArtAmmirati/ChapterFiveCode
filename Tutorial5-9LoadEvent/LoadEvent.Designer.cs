namespace Tutorial5_9LoadEvent
{
    partial class LoadEvent
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
            this.countriesLB = new System.Windows.Forms.Label();
            this.exitBTN = new System.Windows.Forms.Button();
            this.countrieListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // countriesLB
            // 
            this.countriesLB.AutoSize = true;
            this.countriesLB.Location = new System.Drawing.Point(0, 0);
            this.countriesLB.Name = "countriesLB";
            this.countriesLB.Size = new System.Drawing.Size(157, 13);
            this.countriesLB.TabIndex = 0;
            this.countriesLB.Text = "The Countries of South America";
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(96, 226);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTN.TabIndex = 1;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // countrieListBox
            // 
            this.countrieListBox.FormattingEnabled = true;
            this.countrieListBox.Location = new System.Drawing.Point(12, 20);
            this.countrieListBox.Name = "countrieListBox";
            this.countrieListBox.Size = new System.Drawing.Size(236, 160);
            this.countrieListBox.TabIndex = 2;
            // 
            // LoadEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.countrieListBox);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.countriesLB);
            this.Name = "LoadEvent";
            this.Text = "Load Event";
            this.Load += new System.EventHandler(this.LoadEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countriesLB;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.ListBox countrieListBox;
    }
}

