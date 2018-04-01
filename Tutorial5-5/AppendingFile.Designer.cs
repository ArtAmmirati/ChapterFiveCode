namespace Tutorial5_5
{
    partial class AppendingFile
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.exitBTN = new System.Windows.Forms.Button();
            this.writeBTN = new System.Windows.Forms.Button();
            this.nameLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(155, 35);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(188, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(215, 82);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTN.TabIndex = 1;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // writeBTN
            // 
            this.writeBTN.Location = new System.Drawing.Point(46, 82);
            this.writeBTN.Name = "writeBTN";
            this.writeBTN.Size = new System.Drawing.Size(75, 23);
            this.writeBTN.TabIndex = 2;
            this.writeBTN.Text = "Write Name";
            this.writeBTN.UseVisualStyleBackColor = true;
            this.writeBTN.Click += new System.EventHandler(this.writeBTN_Click);
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Location = new System.Drawing.Point(12, 42);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(109, 13);
            this.nameLB.TabIndex = 3;
            this.nameLB.Text = "Enter a friend\'s name:";
            // 
            // AppendingFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 138);
            this.Controls.Add(this.nameLB);
            this.Controls.Add(this.writeBTN);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.nameTextBox);
            this.Name = "AppendingFile";
            this.Text = "Appended Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Button writeBTN;
        private System.Windows.Forms.Label nameLB;
    }
}

