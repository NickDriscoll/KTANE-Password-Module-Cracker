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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.firstRow = new System.Windows.Forms.TextBox();
            this.secondRow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.thirdRow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fourthRow = new System.Windows.Forms.TextBox();
            this.fifthRow = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 223);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate Final word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstRow
            // 
            this.firstRow.Location = new System.Drawing.Point(37, 49);
            this.firstRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstRow.Name = "firstRow";
            this.firstRow.Size = new System.Drawing.Size(100, 22);
            this.firstRow.TabIndex = 1;
            // 
            // secondRow
            // 
            this.secondRow.Location = new System.Drawing.Point(195, 49);
            this.secondRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondRow.Name = "secondRow";
            this.secondRow.Size = new System.Drawing.Size(100, 22);
            this.secondRow.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Column";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Second Column";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Third Column";
            // 
            // thirdRow
            // 
            this.thirdRow.Location = new System.Drawing.Point(37, 104);
            this.thirdRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thirdRow.Name = "thirdRow";
            this.thirdRow.Size = new System.Drawing.Size(100, 22);
            this.thirdRow.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fourth Column";
            // 
            // fourthRow
            // 
            this.fourthRow.Location = new System.Drawing.Point(195, 104);
            this.fourthRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fourthRow.Name = "fourthRow";
            this.fourthRow.Size = new System.Drawing.Size(100, 22);
            this.fourthRow.TabIndex = 4;
            // 
            // fifthRow
            // 
            this.fifthRow.Location = new System.Drawing.Point(37, 156);
            this.fifthRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fifthRow.Name = "fifthRow";
            this.fifthRow.Size = new System.Drawing.Size(100, 22);
            this.fifthRow.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fifth Column";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 338);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fifthRow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fourthRow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secondRow);
            this.Controls.Add(this.thirdRow);
            this.Controls.Add(this.firstRow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "KTANE Password Solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox firstRow;
        private System.Windows.Forms.TextBox secondRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox thirdRow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fourthRow;
        private System.Windows.Forms.TextBox fifthRow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}

