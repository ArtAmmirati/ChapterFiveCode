namespace Tutorial5_6
{
    partial class southAmerica
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
            this.getCountriesBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.countriesLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getCountriesBTN
            // 
            this.getCountriesBTN.Location = new System.Drawing.Point(21, 209);
            this.getCountriesBTN.Name = "getCountriesBTN";
            this.getCountriesBTN.Size = new System.Drawing.Size(105, 23);
            this.getCountriesBTN.TabIndex = 0;
            this.getCountriesBTN.Text = "Get Countries";
            this.getCountriesBTN.UseVisualStyleBackColor = true;
            this.getCountriesBTN.Click += new System.EventHandler(this.getCountriesBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(157, 209);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(105, 23);
            this.exitBTN.TabIndex = 1;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // countriesListBox
            // 
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.Location = new System.Drawing.Point(21, 70);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(241, 121);
            this.countriesListBox.TabIndex = 2;
            this.countriesListBox.SelectedIndexChanged += new System.EventHandler(this.countriesListBox_SelectedIndexChanged);
            // 
            // countriesLB
            // 
            this.countriesLB.AutoSize = true;
            this.countriesLB.Location = new System.Drawing.Point(18, 37);
            this.countriesLB.Name = "countriesLB";
            this.countriesLB.Size = new System.Drawing.Size(157, 13);
            this.countriesLB.TabIndex = 3;
            this.countriesLB.Text = "The Countries of South America";
            this.countriesLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // southAmerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.countriesLB);
            this.Controls.Add(this.countriesListBox);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.getCountriesBTN);
            this.Name = "southAmerica";
            this.Text = "South America";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getCountriesBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.ListBox countriesListBox;
        private System.Windows.Forms.Label countriesLB;
    }
}

