namespace Tutorial5_8Coins
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
            this.tailsPictureBox = new System.Windows.Forms.PictureBox();
            this.headsPictureBox = new System.Windows.Forms.PictureBox();
            this.tossBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tailsPictureBox
            // 
            this.tailsPictureBox.Image = global::Tutorial5_8Coins.Properties.Resources.Tails1;
            this.tailsPictureBox.Location = new System.Drawing.Point(23, 52);
            this.tailsPictureBox.Name = "tailsPictureBox";
            this.tailsPictureBox.Size = new System.Drawing.Size(170, 170);
            this.tailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPictureBox.TabIndex = 1;
            this.tailsPictureBox.TabStop = false;
            // 
            // headsPictureBox
            // 
            this.headsPictureBox.Image = global::Tutorial5_8Coins.Properties.Resources.Heads1;
            this.headsPictureBox.Location = new System.Drawing.Point(23, 52);
            this.headsPictureBox.Name = "headsPictureBox";
            this.headsPictureBox.Size = new System.Drawing.Size(170, 170);
            this.headsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsPictureBox.TabIndex = 0;
            this.headsPictureBox.TabStop = false;
            // 
            // tossBTN
            // 
            this.tossBTN.Location = new System.Drawing.Point(12, 248);
            this.tossBTN.Name = "tossBTN";
            this.tossBTN.Size = new System.Drawing.Size(75, 23);
            this.tossBTN.TabIndex = 2;
            this.tossBTN.Text = "TOSS";
            this.tossBTN.UseVisualStyleBackColor = true;
            this.tossBTN.Click += new System.EventHandler(this.tossBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(118, 248);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTN.TabIndex = 3;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 297);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.tossBTN);
            this.Controls.Add(this.tailsPictureBox);
            this.Controls.Add(this.headsPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox headsPictureBox;
        private System.Windows.Forms.PictureBox tailsPictureBox;
        private System.Windows.Forms.Button tossBTN;
        private System.Windows.Forms.Button exitBTN;
    }
}

