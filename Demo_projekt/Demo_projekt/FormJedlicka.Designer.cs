namespace Demo_projekt
{
    partial class FormJedlicka
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
            this.Btn1 = new System.Windows.Forms.Button();
            this.TxtFrom = new System.Windows.Forms.TextBox();
            this.TxtTo = new System.Windows.Forms.TextBox();
            this.LblFrom = new System.Windows.Forms.Label();
            this.LblTo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(113, 180);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(159, 57);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "Vypsat";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // TxtFrom
            // 
            this.TxtFrom.Location = new System.Drawing.Point(113, 73);
            this.TxtFrom.Name = "TxtFrom";
            this.TxtFrom.Size = new System.Drawing.Size(159, 23);
            this.TxtFrom.TabIndex = 1;
            // 
            // TxtTo
            // 
            this.TxtTo.Location = new System.Drawing.Point(113, 122);
            this.TxtTo.Name = "TxtTo";
            this.TxtTo.Size = new System.Drawing.Size(159, 23);
            this.TxtTo.TabIndex = 2;
            // 
            // LblFrom
            // 
            this.LblFrom.AutoSize = true;
            this.LblFrom.Location = new System.Drawing.Point(45, 76);
            this.LblFrom.Name = "LblFrom";
            this.LblFrom.Size = new System.Drawing.Size(23, 15);
            this.LblFrom.TabIndex = 3;
            this.LblFrom.Text = "Od";
            // 
            // LblTo
            // 
            this.LblTo.AutoSize = true;
            this.LblTo.Location = new System.Drawing.Point(45, 125);
            this.LblTo.Name = "LblTo";
            this.LblTo.Size = new System.Drawing.Size(22, 15);
            this.LblTo.TabIndex = 4;
            this.LblTo.Text = "Do";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(325, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 194);
            this.label1.TabIndex = 5;
            // 
            // FormJedlicka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTo);
            this.Controls.Add(this.LblFrom);
            this.Controls.Add(this.TxtTo);
            this.Controls.Add(this.TxtFrom);
            this.Controls.Add(this.Btn1);
            this.Name = "FormJedlicka";
            this.Text = "FormJedlicka";
            this.Load += new System.EventHandler(this.FormJedlicka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn1;
        private TextBox TxtFrom;
        private TextBox TxtTo;
        private Label LblFrom;
        private Label LblTo;
        private Label label1;
    }
}