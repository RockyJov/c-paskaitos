namespace GUI_Uzduotis_3_savarankiska_
{
    partial class Skaiciavimai
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DaugiausiaiGyv = new System.Windows.Forms.TextBox();
            this.MaziausiaiGyv = new System.Windows.Forms.TextBox();
            this.MaziausiasPL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daugiausiai Gyventoju turintys miestas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maziausiai gyventoju turintys miestas: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maziausias miestas pagal plota:";
            // 
            // DaugiausiaiGyv
            // 
            this.DaugiausiaiGyv.Location = new System.Drawing.Point(16, 61);
            this.DaugiausiaiGyv.Name = "DaugiausiaiGyv";
            this.DaugiausiaiGyv.Size = new System.Drawing.Size(187, 20);
            this.DaugiausiaiGyv.TabIndex = 5;
            // 
            // MaziausiaiGyv
            // 
            this.MaziausiaiGyv.Location = new System.Drawing.Point(224, 61);
            this.MaziausiaiGyv.Name = "MaziausiaiGyv";
            this.MaziausiaiGyv.Size = new System.Drawing.Size(187, 20);
            this.MaziausiaiGyv.TabIndex = 6;
            // 
            // MaziausiasPL
            // 
            this.MaziausiasPL.Location = new System.Drawing.Point(450, 61);
            this.MaziausiasPL.Name = "MaziausiasPL";
            this.MaziausiasPL.Size = new System.Drawing.Size(187, 20);
            this.MaziausiasPL.TabIndex = 7;
            // 
            // Skaiciavimai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 298);
            this.Controls.Add(this.MaziausiasPL);
            this.Controls.Add(this.MaziausiaiGyv);
            this.Controls.Add(this.DaugiausiaiGyv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Skaiciavimai";
            this.Text = "Skaiciavimai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DaugiausiaiGyv;
        private System.Windows.Forms.TextBox MaziausiaiGyv;
        private System.Windows.Forms.TextBox MaziausiasPL;
    }
}