﻿namespace WindowsFormsApp1
{
    partial class ManagerAddC
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.lastnbox = new System.Windows.Forms.TextBox();
            this.depbox = new System.Windows.Forms.TextBox();
            this.cnamebox = new System.Windows.Forms.TextBox();
            this.daybox = new System.Windows.Forms.TextBox();
            this.addbut = new System.Windows.Forms.Button();
            this.timebox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblero = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instructor Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Instructor Passoword";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = " Instructor Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Instructor Lastname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Instructor Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Course Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Course Day";
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(197, 29);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 22);
            this.idbox.TabIndex = 8;
            this.idbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(197, 66);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(100, 22);
            this.passbox.TabIndex = 9;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(197, 106);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 22);
            this.namebox.TabIndex = 10;
            // 
            // lastnbox
            // 
            this.lastnbox.Location = new System.Drawing.Point(197, 145);
            this.lastnbox.Name = "lastnbox";
            this.lastnbox.Size = new System.Drawing.Size(100, 22);
            this.lastnbox.TabIndex = 11;
            // 
            // depbox
            // 
            this.depbox.Location = new System.Drawing.Point(197, 189);
            this.depbox.Name = "depbox";
            this.depbox.Size = new System.Drawing.Size(100, 22);
            this.depbox.TabIndex = 12;
            // 
            // cnamebox
            // 
            this.cnamebox.Location = new System.Drawing.Point(197, 227);
            this.cnamebox.Name = "cnamebox";
            this.cnamebox.Size = new System.Drawing.Size(100, 22);
            this.cnamebox.TabIndex = 13;
            // 
            // daybox
            // 
            this.daybox.Location = new System.Drawing.Point(197, 271);
            this.daybox.Name = "daybox";
            this.daybox.Size = new System.Drawing.Size(100, 22);
            this.daybox.TabIndex = 14;
            // 
            // addbut
            // 
            this.addbut.Location = new System.Drawing.Point(413, 144);
            this.addbut.Name = "addbut";
            this.addbut.Size = new System.Drawing.Size(115, 57);
            this.addbut.TabIndex = 15;
            this.addbut.Text = "Add";
            this.addbut.UseVisualStyleBackColor = true;
            this.addbut.Click += new System.EventHandler(this.addbut_Click);
            // 
            // timebox
            // 
            this.timebox.Location = new System.Drawing.Point(197, 320);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(100, 22);
            this.timebox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Course Time";
            // 
            // lblero
            // 
            this.lblero.AutoSize = true;
            this.lblero.Location = new System.Drawing.Point(424, 259);
            this.lblero.Name = "lblero";
            this.lblero.Size = new System.Drawing.Size(0, 17);
            this.lblero.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 52);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerAddC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timebox);
            this.Controls.Add(this.addbut);
            this.Controls.Add(this.daybox);
            this.Controls.Add(this.cnamebox);
            this.Controls.Add(this.depbox);
            this.Controls.Add(this.lastnbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManagerAddC";
            this.Text = "ManagerAddC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox lastnbox;
        private System.Windows.Forms.TextBox depbox;
        private System.Windows.Forms.TextBox cnamebox;
        private System.Windows.Forms.TextBox daybox;
        private System.Windows.Forms.Button addbut;
        private System.Windows.Forms.TextBox timebox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblero;
        private System.Windows.Forms.Button button1;
    }
}