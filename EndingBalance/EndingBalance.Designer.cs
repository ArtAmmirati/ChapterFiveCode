namespace EndingBalance
{
    partial class EndingBalance
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
            this.clearBTN = new System.Windows.Forms.Button();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.outEndBalanceLB = new System.Windows.Forms.Label();
            this.endLB = new System.Windows.Forms.Label();
            this.monthLB = new System.Windows.Forms.Label();
            this.startBalLB = new System.Windows.Forms.Label();
            this.inMonthsTB = new System.Windows.Forms.TextBox();
            this.inStartingBalTB = new System.Windows.Forms.TextBox();
            this.detailListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(265, 301);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 65);
            this.exitBTN.TabIndex = 17;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(174, 301);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(75, 65);
            this.clearBTN.TabIndex = 16;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // calculateBTN
            // 
            this.calculateBTN.Location = new System.Drawing.Point(83, 301);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(75, 65);
            this.calculateBTN.TabIndex = 15;
            this.calculateBTN.Text = "Calculate";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // outEndBalanceLB
            // 
            this.outEndBalanceLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outEndBalanceLB.Location = new System.Drawing.Point(224, 256);
            this.outEndBalanceLB.Name = "outEndBalanceLB";
            this.outEndBalanceLB.Size = new System.Drawing.Size(119, 23);
            this.outEndBalanceLB.TabIndex = 14;
            this.outEndBalanceLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // endLB
            // 
            this.endLB.AutoSize = true;
            this.endLB.Location = new System.Drawing.Point(83, 261);
            this.endLB.Name = "endLB";
            this.endLB.Size = new System.Drawing.Size(85, 13);
            this.endLB.TabIndex = 13;
            this.endLB.Text = "Ending Balance:";
            // 
            // monthLB
            // 
            this.monthLB.AutoSize = true;
            this.monthLB.Location = new System.Drawing.Point(83, 76);
            this.monthLB.Name = "monthLB";
            this.monthLB.Size = new System.Drawing.Size(97, 13);
            this.monthLB.TabIndex = 12;
            this.monthLB.Text = "Number of Months:";
            // 
            // startBalLB
            // 
            this.startBalLB.AutoSize = true;
            this.startBalLB.Location = new System.Drawing.Point(83, 29);
            this.startBalLB.Name = "startBalLB";
            this.startBalLB.Size = new System.Drawing.Size(88, 13);
            this.startBalLB.TabIndex = 11;
            this.startBalLB.Text = "Starting Balance:";
            // 
            // inMonthsTB
            // 
            this.inMonthsTB.Location = new System.Drawing.Point(224, 73);
            this.inMonthsTB.Name = "inMonthsTB";
            this.inMonthsTB.Size = new System.Drawing.Size(119, 20);
            this.inMonthsTB.TabIndex = 10;
            this.inMonthsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inStartingBalTB
            // 
            this.inStartingBalTB.Location = new System.Drawing.Point(224, 26);
            this.inStartingBalTB.Name = "inStartingBalTB";
            this.inStartingBalTB.Size = new System.Drawing.Size(119, 20);
            this.inStartingBalTB.TabIndex = 9;
            this.inStartingBalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // detailListBox
            // 
            this.detailListBox.FormattingEnabled = true;
            this.detailListBox.Location = new System.Drawing.Point(83, 105);
            this.detailListBox.Name = "detailListBox";
            this.detailListBox.Size = new System.Drawing.Size(260, 134);
            this.detailListBox.TabIndex = 18;
            // 
            // EndingBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 378);
            this.Controls.Add(this.detailListBox);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.calculateBTN);
            this.Controls.Add(this.outEndBalanceLB);
            this.Controls.Add(this.endLB);
            this.Controls.Add(this.monthLB);
            this.Controls.Add(this.startBalLB);
            this.Controls.Add(this.inMonthsTB);
            this.Controls.Add(this.inStartingBalTB);
            this.Name = "EndingBalance";
            this.Text = "Ending Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.Label outEndBalanceLB;
        private System.Windows.Forms.Label endLB;
        private System.Windows.Forms.Label monthLB;
        private System.Windows.Forms.Label startBalLB;
        private System.Windows.Forms.TextBox inMonthsTB;
        private System.Windows.Forms.TextBox inStartingBalTB;
        private System.Windows.Forms.ListBox detailListBox;
    }
}

