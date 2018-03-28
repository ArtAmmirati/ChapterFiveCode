namespace Tutorial5_3forLoop
{
    partial class speedConverter
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
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.displayBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(13, 13);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(252, 147);
            this.outputListBox.TabIndex = 0;
            // 
            // displayBTN
            // 
            this.displayBTN.Location = new System.Drawing.Point(22, 193);
            this.displayBTN.Name = "displayBTN";
            this.displayBTN.Size = new System.Drawing.Size(98, 48);
            this.displayBTN.TabIndex = 1;
            this.displayBTN.Text = "Display Speeds";
            this.displayBTN.UseVisualStyleBackColor = true;
            this.displayBTN.Click += new System.EventHandler(this.displayBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(162, 193);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(98, 48);
            this.exitBTN.TabIndex = 2;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // speedConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.displayBTN);
            this.Controls.Add(this.outputListBox);
            this.Name = "speedConverter";
            this.Text = "Speed Converter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button displayBTN;
        private System.Windows.Forms.Button exitBTN;
    }
}

