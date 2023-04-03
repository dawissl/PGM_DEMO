namespace Demo_projekt
{
    partial class FormSemenec
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
            this.txtbxPocatek = new System.Windows.Forms.TextBox();
            this.txtbxKonec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnVypocet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxPocatek
            // 
            this.txtbxPocatek.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbxPocatek.Location = new System.Drawing.Point(12, 39);
            this.txtbxPocatek.Name = "txtbxPocatek";
            this.txtbxPocatek.Size = new System.Drawing.Size(186, 34);
            this.txtbxPocatek.TabIndex = 0;
            // 
            // txtbxKonec
            // 
            this.txtbxKonec.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbxKonec.Location = new System.Drawing.Point(204, 39);
            this.txtbxKonec.Name = "txtbxKonec";
            this.txtbxKonec.Size = new System.Drawing.Size(186, 34);
            this.txtbxKonec.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Počátek rozsahu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(204, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Konec rozsahu";
            // 
            // BtnVypocet
            // 
            this.BtnVypocet.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVypocet.Location = new System.Drawing.Point(12, 79);
            this.BtnVypocet.Name = "BtnVypocet";
            this.BtnVypocet.Size = new System.Drawing.Size(378, 46);
            this.BtnVypocet.TabIndex = 4;
            this.BtnVypocet.Text = "Zjistit";
            this.BtnVypocet.UseVisualStyleBackColor = true;
            this.BtnVypocet.Click += new System.EventHandler(this.BtnVypocet_Click);
            // 
            // FormSemenec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 138);
            this.Controls.Add(this.BtnVypocet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxKonec);
            this.Controls.Add(this.txtbxPocatek);
            this.Name = "FormSemenec";
            this.Text = "FormSemenec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbxPocatek;
        private TextBox txtbxKonec;
        private Label label1;
        private Label label2;
        private Button BtnVypocet;
    }
}