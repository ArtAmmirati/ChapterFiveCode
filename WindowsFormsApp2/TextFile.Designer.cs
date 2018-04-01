namespace WindowsFormsApp2
{
    partial class TextFile
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
            this.nameBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.freindsNameLB = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameBTN
            // 
            this.nameBTN.Location = new System.Drawing.Point(46, 72);
            this.nameBTN.Name = "nameBTN";
            this.nameBTN.Size = new System.Drawing.Size(75, 23);
            this.nameBTN.TabIndex = 0;
            this.nameBTN.Text = "Write Name";
            this.nameBTN.UseVisualStyleBackColor = true;
            this.nameBTN.Click += new System.EventHandler(this.nameBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(232, 72);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTN.TabIndex = 1;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // freindsNameLB
            // 
            this.freindsNameLB.AutoSize = true;
            this.freindsNameLB.Location = new System.Drawing.Point(12, 28);
            this.freindsNameLB.Name = "freindsNameLB";
            this.freindsNameLB.Size = new System.Drawing.Size(109, 13);
            this.freindsNameLB.TabIndex = 2;
            this.freindsNameLB.Text = "Enter a friend\'s name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(150, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(218, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 122);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.freindsNameLB);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.nameBTN);
            this.Name = "TextFile";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nameBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label freindsNameLB;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}

