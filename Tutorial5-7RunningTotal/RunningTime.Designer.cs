namespace Tutorial5_7RunningTotal
{
    partial class runningTotal
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
            this.calculateBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.totalSalesLB = new System.Windows.Forms.Label();
            this.totalLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateBTN
            // 
            this.calculateBTN.Location = new System.Drawing.Point(30, 82);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(75, 61);
            this.calculateBTN.TabIndex = 0;
            this.calculateBTN.Text = "Read Sales &&\r\n Calculate Total\r\n\r\n\r\n\r\n";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(151, 82);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 61);
            this.exitBTN.TabIndex = 1;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // totalSalesLB
            // 
            this.totalSalesLB.AutoSize = true;
            this.totalSalesLB.Location = new System.Drawing.Point(27, 34);
            this.totalSalesLB.Name = "totalSalesLB";
            this.totalSalesLB.Size = new System.Drawing.Size(60, 13);
            this.totalSalesLB.TabIndex = 2;
            this.totalSalesLB.Text = "Total Sales";
            // 
            // totalLB
            // 
            this.totalLB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLB.Location = new System.Drawing.Point(106, 33);
            this.totalLB.Name = "totalLB";
            this.totalLB.Size = new System.Drawing.Size(166, 23);
            this.totalLB.TabIndex = 3;
            // 
            // runningTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.totalLB);
            this.Controls.Add(this.totalSalesLB);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.calculateBTN);
            this.Name = "runningTotal";
            this.Text = "Running Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label totalSalesLB;
        private System.Windows.Forms.Label totalLB;
    }
}

