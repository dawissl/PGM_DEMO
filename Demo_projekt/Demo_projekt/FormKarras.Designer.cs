namespace Demo_projekt
{
    partial class FormKarras
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
            this.NumUDStart = new System.Windows.Forms.NumericUpDown();
            this.NumUDend = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.LblOUT = new System.Windows.Forms.Label();
            this.Butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDend)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Výpis prvočísel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Od:";
            // 
            // NumUDStart
            // 
            this.NumUDStart.Location = new System.Drawing.Point(52, 53);
            this.NumUDStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUDStart.Name = "NumUDStart";
            this.NumUDStart.Size = new System.Drawing.Size(120, 23);
            this.NumUDStart.TabIndex = 2;
            this.NumUDStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumUDend
            // 
            this.NumUDend.Location = new System.Drawing.Point(233, 53);
            this.NumUDend.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUDend.Name = "NumUDend";
            this.NumUDend.Size = new System.Drawing.Size(120, 23);
            this.NumUDend.TabIndex = 4;
            this.NumUDend.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(193, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Do:";
            // 
            // LblOUT
            // 
            this.LblOUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOUT.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOUT.Location = new System.Drawing.Point(12, 122);
            this.LblOUT.Name = "LblOUT";
            this.LblOUT.Size = new System.Drawing.Size(341, 319);
            this.LblOUT.TabIndex = 5;
            // 
            // Butt
            // 
            this.Butt.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Butt.Location = new System.Drawing.Point(12, 89);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(341, 30);
            this.Butt.TabIndex = 6;
            this.Butt.Text = "Piš";
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // FormKarras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.Butt);
            this.Controls.Add(this.LblOUT);
            this.Controls.Add(this.NumUDend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumUDStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKarras";
            this.Text = "FormKarras";
            ((System.ComponentModel.ISupportInitialize)(this.NumUDStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown NumUDStart;
        private NumericUpDown NumUDend;
        private Label label3;
        private Label LblOUT;
        private Button Butt;
    }
}