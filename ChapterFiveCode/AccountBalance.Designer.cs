namespace ChapterFiveCode
{
    partial class AccountBalance
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
            this.inStartingBalTB = new System.Windows.Forms.TextBox();
            this.inMonthsTB = new System.Windows.Forms.TextBox();
            this.startBalLB = new System.Windows.Forms.Label();
            this.monthLB = new System.Windows.Forms.Label();
            this.endLB = new System.Windows.Forms.Label();
            this.outEndBalanceLB = new System.Windows.Forms.Label();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inStartingBalTB
            // 
            this.inStartingBalTB.Location = new System.Drawing.Point(180, 12);
            this.inStartingBalTB.Name = "inStartingBalTB";
            this.inStartingBalTB.Size = new System.Drawing.Size(119, 20);
            this.inStartingBalTB.TabIndex = 0;
            this.inStartingBalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inMonthsTB
            // 
            this.inMonthsTB.Location = new System.Drawing.Point(180, 70);
            this.inMonthsTB.Name = "inMonthsTB";
            this.inMonthsTB.Size = new System.Drawing.Size(119, 20);
            this.inMonthsTB.TabIndex = 1;
            this.inMonthsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // startBalLB
            // 
            this.startBalLB.AutoSize = true;
            this.startBalLB.Location = new System.Drawing.Point(39, 15);
            this.startBalLB.Name = "startBalLB";
            this.startBalLB.Size = new System.Drawing.Size(88, 13);
            this.startBalLB.TabIndex = 2;
            this.startBalLB.Text = "Starting Balance:";
            // 
            // monthLB
            // 
            this.monthLB.AutoSize = true;
            this.monthLB.Location = new System.Drawing.Point(39, 73);
            this.monthLB.Name = "monthLB";
            this.monthLB.Size = new System.Drawing.Size(97, 13);
            this.monthLB.TabIndex = 3;
            this.monthLB.Text = "Number of Months:";
            // 
            // endLB
            // 
            this.endLB.AutoSize = true;
            this.endLB.Location = new System.Drawing.Point(39, 132);
            this.endLB.Name = "endLB";
            this.endLB.Size = new System.Drawing.Size(85, 13);
            this.endLB.TabIndex = 4;
            this.endLB.Text = "Ending Balance:";
            // 
            // outEndBalanceLB
            // 
            this.outEndBalanceLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outEndBalanceLB.Location = new System.Drawing.Point(180, 127);
            this.outEndBalanceLB.Name = "outEndBalanceLB";
            this.outEndBalanceLB.Size = new System.Drawing.Size(119, 23);
            this.outEndBalanceLB.TabIndex = 5;
            this.outEndBalanceLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calculateBTN
            // 
            this.calculateBTN.Location = new System.Drawing.Point(42, 185);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(75, 65);
            this.calculateBTN.TabIndex = 6;
            this.calculateBTN.Text = "Calculate";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(133, 185);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(75, 65);
            this.clearBTN.TabIndex = 7;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(224, 185);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 65);
            this.exitBTN.TabIndex = 8;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // AccountBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 273);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.calculateBTN);
            this.Controls.Add(this.outEndBalanceLB);
            this.Controls.Add(this.endLB);
            this.Controls.Add(this.monthLB);
            this.Controls.Add(this.startBalLB);
            this.Controls.Add(this.inMonthsTB);
            this.Controls.Add(this.inStartingBalTB);
            this.Name = "AccountBalance";
            this.Text = "Account Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inStartingBalTB;
        private System.Windows.Forms.TextBox inMonthsTB;
        private System.Windows.Forms.Label startBalLB;
        private System.Windows.Forms.Label monthLB;
        private System.Windows.Forms.Label endLB;
        private System.Windows.Forms.Label outEndBalanceLB;
        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button exitBTN;
    }
}

