namespace _15_01_pradmenys
{
    partial class IvedimoForma
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
            this.buttongerai = new System.Windows.Forms.Button();
            this.buttonatsaukti = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttongerai
            // 
            this.buttongerai.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttongerai.Location = new System.Drawing.Point(49, 151);
            this.buttongerai.Name = "buttongerai";
            this.buttongerai.Size = new System.Drawing.Size(75, 23);
            this.buttongerai.TabIndex = 0;
            this.buttongerai.Text = "Gerai";
            this.buttongerai.UseVisualStyleBackColor = true;
            this.buttongerai.Click += new System.EventHandler(this.buttongerai_Click);
            // 
            // buttonatsaukti
            // 
            this.buttonatsaukti.AutoEllipsis = true;
            this.buttonatsaukti.Location = new System.Drawing.Point(130, 151);
            this.buttonatsaukti.Name = "buttonatsaukti";
            this.buttonatsaukti.Size = new System.Drawing.Size(75, 23);
            this.buttonatsaukti.TabIndex = 1;
            this.buttonatsaukti.Text = "Atsaukti";
            this.buttonatsaukti.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iveskite zodi";
            // 
            // IvedimoForma
            // 
            this.AcceptButton = this.buttongerai;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelButton = this.buttonatsaukti;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonatsaukti);
            this.Controls.Add(this.buttongerai);
            this.Name = "IvedimoForma";
            this.Text = "IvedimoForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttongerai;
        private System.Windows.Forms.Button buttonatsaukti;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}