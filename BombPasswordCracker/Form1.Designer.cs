namespace BombPasswordCracker
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.firstRow = new System.Windows.Forms.TextBox();
            this.fifthRow = new System.Windows.Forms.TextBox();
            this.fourthRow = new System.Windows.Forms.TextBox();
            this.thirdRow = new System.Windows.Forms.TextBox();
            this.secondRow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "final word";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate Final word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstRow
            // 
            this.firstRow.Location = new System.Drawing.Point(38, 49);
            this.firstRow.Name = "firstRow";
            this.firstRow.Size = new System.Drawing.Size(100, 22);
            this.firstRow.TabIndex = 2;
            // 
            // fifthRow
            // 
            this.fifthRow.Location = new System.Drawing.Point(38, 137);
            this.fifthRow.Name = "fifthRow";
            this.fifthRow.Size = new System.Drawing.Size(100, 22);
            this.fifthRow.TabIndex = 3;
            // 
            // fourthRow
            // 
            this.fourthRow.Location = new System.Drawing.Point(195, 92);
            this.fourthRow.Name = "fourthRow";
            this.fourthRow.Size = new System.Drawing.Size(100, 22);
            this.fourthRow.TabIndex = 5;
            // 
            // thirdRow
            // 
            this.thirdRow.Location = new System.Drawing.Point(38, 92);
            this.thirdRow.Name = "thirdRow";
            this.thirdRow.Size = new System.Drawing.Size(100, 22);
            this.thirdRow.TabIndex = 6;
            // 
            // secondRow
            // 
            this.secondRow.Location = new System.Drawing.Point(195, 49);
            this.secondRow.Name = "secondRow";
            this.secondRow.Size = new System.Drawing.Size(100, 22);
            this.secondRow.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Row";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Second Row";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Third Row";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fourth Row";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fifth Row";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 338);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secondRow);
            this.Controls.Add(this.thirdRow);
            this.Controls.Add(this.fourthRow);
            this.Controls.Add(this.fifthRow);
            this.Controls.Add(this.firstRow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "KTANE Password Cracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox firstRow;
        private System.Windows.Forms.TextBox fifthRow;
        private System.Windows.Forms.TextBox fourthRow;
        private System.Windows.Forms.TextBox thirdRow;
        private System.Windows.Forms.TextBox secondRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

