﻿namespace Demo_projekt
{
    partial class FormJakubysyn
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
            this.txt_jedna = new System.Windows.Forms.TextBox();
            this.txt_dva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_jedna
            // 
            this.txt_jedna.Location = new System.Drawing.Point(55, 204);
            this.txt_jedna.Name = "txt_jedna";
            this.txt_jedna.Size = new System.Drawing.Size(100, 23);
            this.txt_jedna.TabIndex = 0;
            // 
            // txt_dva
            // 
            this.txt_dva.Location = new System.Drawing.Point(173, 204);
            this.txt_dva.Name = "txt_dva";
            this.txt_dva.Size = new System.Drawing.Size(100, 23);
            this.txt_dva.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Číslo jedna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Číslo dva";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Prvočíslo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(436, 160);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 5;
            // 
            // FormJakubysyn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dva);
            this.Controls.Add(this.txt_jedna);
            this.Name = "FormJakubysyn";
            this.Text = "FormJakubysyn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_jedna;
        private TextBox txt_dva;
        private Label label1;
        private Label label2;
        private Button button1;
        private ListBox listBox1;
    }
}