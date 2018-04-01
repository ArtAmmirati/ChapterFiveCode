namespace Tutorial5_8CoinToss
{
    partial class CoinToss
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
            this.tossBTN = new System.Windows.Forms.Button();
            this.tailsPictureBox = new System.Windows.Forms.PictureBox();
            this.headsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(122, 201);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 55);
            this.exitBTN.TabIndex = 2;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // tossBTN
            // 
            this.tossBTN.Location = new System.Drawing.Point(27, 201);
            this.tossBTN.Name = "tossBTN";
            this.tossBTN.Size = new System.Drawing.Size(75, 55);
            this.tossBTN.TabIndex = 3;
            this.tossBTN.Text = "Toss";
            this.tossBTN.UseVisualStyleBackColor = true;
            this.tossBTN.Click += new System.EventHandler(this.tossBTN_Click);
            // 
            // tailsPictureBox
            // 
            this.tailsPictureBox.Image = global::Tutorial5_8CoinToss.Properties.Resources.Tails1;
            this.tailsPictureBox.Location = new System.Drawing.Point(27, 25);
            this.tailsPictureBox.Name = "tailsPictureBox";
            this.tailsPictureBox.Size = new System.Drawing.Size(170, 170);
            this.tailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPictureBox.TabIndex = 1;
            this.tailsPictureBox.TabStop = false;
            // 
            // headsPictureBox
            // 
            this.headsPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headsPictureBox.Image = global::Tutorial5_8CoinToss.Properties.Resources.Heads1;
            this.headsPictureBox.Location = new System.Drawing.Point(27, 25);
            this.headsPictureBox.Name = "headsPictureBox";
            this.headsPictureBox.Size = new System.Drawing.Size(0, 154);
            this.headsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsPictureBox.TabIndex = 0;
            this.headsPictureBox.TabStop = false;
            // 
            // CoinToss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 271);
            this.Controls.Add(this.tossBTN);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.tailsPictureBox);
            this.Controls.Add(this.headsPictureBox);
            this.Name = "CoinToss";
            this.Text = "Coin Toss";
            this.Load += new System.EventHandler(this.CoinToss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox headsPictureBox;
        private System.Windows.Forms.PictureBox tailsPictureBox;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Button tossBTN;
    }
}

