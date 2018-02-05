namespace _15_01_pradmenys
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
            this.buttonMygtukas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelReiksme = new System.Windows.Forms.Label();
            this.buttonGautiReiksme = new System.Windows.Forms.Button();
            this.textBoxReiksme = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.suma = new System.Windows.Forms.TextBox();
            this.buttonskaiciuoti = new System.Windows.Forms.Button();
            this.skaicius2 = new System.Windows.Forms.TextBox();
            this.pirmasskaicius = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonsiusti = new System.Windows.Forms.Button();
            this.textBoxSiusti = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelIvedimas = new System.Windows.Forms.Label();
            this.buttonsiusti2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMygtukas
            // 
            this.buttonMygtukas.Location = new System.Drawing.Point(20, 29);
            this.buttonMygtukas.Name = "buttonMygtukas";
            this.buttonMygtukas.Size = new System.Drawing.Size(161, 62);
            this.buttonMygtukas.TabIndex = 0;
            this.buttonMygtukas.Text = "Mygtukas";
            this.buttonMygtukas.UseVisualStyleBackColor = true;
            this.buttonMygtukas.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.buttonMygtukas);
            this.groupBox1.Location = new System.Drawing.Point(50, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pranesimas";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.labelReiksme);
            this.groupBox2.Controls.Add(this.buttonGautiReiksme);
            this.groupBox2.Controls.Add(this.textBoxReiksme);
            this.groupBox2.Location = new System.Drawing.Point(302, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "gauti reiksme is laukelio";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labelReiksme
            // 
            this.labelReiksme.AutoSize = true;
            this.labelReiksme.Location = new System.Drawing.Point(16, 86);
            this.labelReiksme.Name = "labelReiksme";
            this.labelReiksme.Size = new System.Drawing.Size(35, 13);
            this.labelReiksme.TabIndex = 2;
            this.labelReiksme.Text = "label1";
            // 
            // buttonGautiReiksme
            // 
            this.buttonGautiReiksme.Location = new System.Drawing.Point(16, 56);
            this.buttonGautiReiksme.Name = "buttonGautiReiksme";
            this.buttonGautiReiksme.Size = new System.Drawing.Size(163, 23);
            this.buttonGautiReiksme.TabIndex = 1;
            this.buttonGautiReiksme.Text = "Gauti reiksme";
            this.buttonGautiReiksme.UseVisualStyleBackColor = true;
            this.buttonGautiReiksme.Click += new System.EventHandler(this.buttonGautiReiksme_Click);
            // 
            // textBoxReiksme
            // 
            this.textBoxReiksme.Location = new System.Drawing.Point(16, 29);
            this.textBoxReiksme.Name = "textBoxReiksme";
            this.textBoxReiksme.Size = new System.Drawing.Size(163, 20);
            this.textBoxReiksme.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.suma);
            this.groupBox3.Controls.Add(this.buttonskaiciuoti);
            this.groupBox3.Controls.Add(this.skaicius2);
            this.groupBox3.Controls.Add(this.pirmasskaicius);
            this.groupBox3.Location = new System.Drawing.Point(50, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 151);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skaiciuoti suma";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(20, 116);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(100, 20);
            this.suma.TabIndex = 3;
            // 
            // buttonskaiciuoti
            // 
            this.buttonskaiciuoti.Location = new System.Drawing.Point(20, 86);
            this.buttonskaiciuoti.Name = "buttonskaiciuoti";
            this.buttonskaiciuoti.Size = new System.Drawing.Size(75, 23);
            this.buttonskaiciuoti.TabIndex = 2;
            this.buttonskaiciuoti.Text = "skaiciuoti";
            this.buttonskaiciuoti.UseVisualStyleBackColor = true;
            this.buttonskaiciuoti.Click += new System.EventHandler(this.buttonskaiciuoti_Click);
            // 
            // skaicius2
            // 
            this.skaicius2.Location = new System.Drawing.Point(20, 59);
            this.skaicius2.Name = "skaicius2";
            this.skaicius2.Size = new System.Drawing.Size(161, 20);
            this.skaicius2.TabIndex = 1;
            // 
            // pirmasskaicius
            // 
            this.pirmasskaicius.Location = new System.Drawing.Point(20, 33);
            this.pirmasskaicius.Name = "pirmasskaicius";
            this.pirmasskaicius.Size = new System.Drawing.Size(161, 20);
            this.pirmasskaicius.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(302, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(151, 151);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "naujas langas";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rodyti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox5.Controls.Add(this.buttonsiusti);
            this.groupBox5.Controls.Add(this.textBoxSiusti);
            this.groupBox5.Location = new System.Drawing.Point(506, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(168, 121);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "siusti duomenis i kita faila";
            // 
            // buttonsiusti
            // 
            this.buttonsiusti.Location = new System.Drawing.Point(7, 68);
            this.buttonsiusti.Name = "buttonsiusti";
            this.buttonsiusti.Size = new System.Drawing.Size(155, 23);
            this.buttonsiusti.TabIndex = 1;
            this.buttonsiusti.Text = "siusti";
            this.buttonsiusti.UseVisualStyleBackColor = true;
            this.buttonsiusti.Click += new System.EventHandler(this.buttonsiusti_Click);
            // 
            // textBoxSiusti
            // 
            this.textBoxSiusti.Location = new System.Drawing.Point(7, 29);
            this.textBoxSiusti.Name = "textBoxSiusti";
            this.textBoxSiusti.Size = new System.Drawing.Size(155, 20);
            this.textBoxSiusti.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox6.Controls.Add(this.labelIvedimas);
            this.groupBox6.Controls.Add(this.buttonsiusti2);
            this.groupBox6.Location = new System.Drawing.Point(513, 183);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(161, 151);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "siusti duomenis";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // labelIvedimas
            // 
            this.labelIvedimas.AutoSize = true;
            this.labelIvedimas.Location = new System.Drawing.Point(37, 75);
            this.labelIvedimas.Name = "labelIvedimas";
            this.labelIvedimas.Size = new System.Drawing.Size(70, 13);
            this.labelIvedimas.TabIndex = 1;
            this.labelIvedimas.Text = "labelivedimas";
            // 
            // buttonsiusti2
            // 
            this.buttonsiusti2.Location = new System.Drawing.Point(37, 45);
            this.buttonsiusti2.Name = "buttonsiusti2";
            this.buttonsiusti2.Size = new System.Drawing.Size(75, 23);
            this.buttonsiusti2.TabIndex = 0;
            this.buttonsiusti2.Text = "ivedimas";
            this.buttonsiusti2.UseVisualStyleBackColor = true;
            this.buttonsiusti2.Click += new System.EventHandler(this.buttonsiusti2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(707, 383);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMygtukas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelReiksme;
        private System.Windows.Forms.Button buttonGautiReiksme;
        private System.Windows.Forms.TextBox textBoxReiksme;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox skaicius2;
        private System.Windows.Forms.TextBox pirmasskaicius;
        private System.Windows.Forms.TextBox suma;
        private System.Windows.Forms.Button buttonskaiciuoti;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonsiusti;
        private System.Windows.Forms.TextBox textBoxSiusti;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelIvedimas;
        private System.Windows.Forms.Button buttonsiusti2;
    }
}

