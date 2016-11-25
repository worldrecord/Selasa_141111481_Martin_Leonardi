namespace Volleyball_Problem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.Buttonhasil = new System.Windows.Forms.Button();
            this.txthasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Team A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Team B";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(75, 72);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(120, 20);
            this.txt1.TabIndex = 13;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(75, 130);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(120, 20);
            this.txt2.TabIndex = 14;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // Buttonhasil
            // 
            this.Buttonhasil.BackColor = System.Drawing.Color.Gold;
            this.Buttonhasil.ForeColor = System.Drawing.Color.Black;
            this.Buttonhasil.Location = new System.Drawing.Point(251, 72);
            this.Buttonhasil.Name = "Buttonhasil";
            this.Buttonhasil.Size = new System.Drawing.Size(75, 37);
            this.Buttonhasil.TabIndex = 15;
            this.Buttonhasil.Text = "Result";
            this.Buttonhasil.UseVisualStyleBackColor = false;
            this.Buttonhasil.Click += new System.EventHandler(this.Buttonhasil_Click);
            // 
            // txthasil
            // 
            this.txthasil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthasil.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txthasil.Location = new System.Drawing.Point(233, 130);
            this.txthasil.Margin = new System.Windows.Forms.Padding(2);
            this.txthasil.Name = "txthasil";
            this.txthasil.Size = new System.Drawing.Size(117, 20);
            this.txthasil.TabIndex = 16;
            this.txthasil.Text = "click \"result\" button";
            this.txthasil.TextChanged += new System.EventHandler(this.txthasil_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(394, 226);
            this.Controls.Add(this.txthasil);
            this.Controls.Add(this.Buttonhasil);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Volleyball Case";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button Buttonhasil;
        private System.Windows.Forms.TextBox txthasil;
    }
}

