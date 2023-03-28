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
            label1 = new Label();
            label2 = new Label();
            NumUDStart = new NumericUpDown();
            NumUDEnd = new NumericUpDown();
            label3 = new Label();
            Butt = new Button();
            RTextBoxOUT = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)NumUDStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumUDEnd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 34);
            label1.TabIndex = 0;
            label1.Text = "Výpis prvočísel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(34, 23);
            label2.TabIndex = 1;
            label2.Text = "Od:";
            // 
            // NumUDStart
            // 
            NumUDStart.Location = new Point(52, 53);
            NumUDStart.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumUDStart.Name = "NumUDStart";
            NumUDStart.Size = new Size(120, 23);
            NumUDStart.TabIndex = 2;
            NumUDStart.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NumUDEnd
            // 
            NumUDEnd.Location = new Point(232, 53);
            NumUDEnd.Maximum = new decimal(new int[] { 2147483646, 0, 0, 0 });
            NumUDEnd.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumUDEnd.Name = "NumUDEnd";
            NumUDEnd.Size = new Size(120, 23);
            NumUDEnd.TabIndex = 4;
            NumUDEnd.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(193, 53);
            label3.Name = "label3";
            label3.Size = new Size(35, 23);
            label3.TabIndex = 3;
            label3.Text = "Do:";
            // 
            // Butt
            // 
            Butt.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Butt.Location = new Point(12, 89);
            Butt.Name = "Butt";
            Butt.Size = new Size(341, 30);
            Butt.TabIndex = 6;
            Butt.Text = "Piš";
            Butt.UseVisualStyleBackColor = true;
            Butt.Click += Butt_Click;
            // 
            // RTextBoxOUT
            // 
            RTextBoxOUT.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            RTextBoxOUT.Location = new Point(12, 125);
            RTextBoxOUT.Name = "RTextBoxOUT";
            RTextBoxOUT.ReadOnly = true;
            RTextBoxOUT.ScrollBars = RichTextBoxScrollBars.Vertical;
            RTextBoxOUT.Size = new Size(340, 313);
            RTextBoxOUT.TabIndex = 7;
            RTextBoxOUT.Text = "";
            // 
            // FormKarras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 450);
            Controls.Add(RTextBoxOUT);
            Controls.Add(Butt);
            Controls.Add(NumUDEnd);
            Controls.Add(label3);
            Controls.Add(NumUDStart);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormKarras";
            Text = "FormKarras";
            ((System.ComponentModel.ISupportInitialize)NumUDStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumUDEnd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown NumUDStart;
        private NumericUpDown NumUDEnd;
        private Label label3;
        private Button Butt;
        private RichTextBox RTextBoxOUT;
    }
}