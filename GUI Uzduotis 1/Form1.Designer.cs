namespace GUI_Uzduotis_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxkrastine = new System.Windows.Forms.TextBox();
            this.textBoxaukstine = new System.Windows.Forms.TextBox();
            this.buttonplotas = new System.Windows.Forms.Button();
            this.textBoxplotas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iveskite trikampio krastine ir aukstine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxkrastine
            // 
            this.textBoxkrastine.Location = new System.Drawing.Point(28, 55);
            this.textBoxkrastine.Name = "textBoxkrastine";
            this.textBoxkrastine.Size = new System.Drawing.Size(100, 20);
            this.textBoxkrastine.TabIndex = 1;
            // 
            // textBoxaukstine
            // 
            this.textBoxaukstine.Location = new System.Drawing.Point(28, 82);
            this.textBoxaukstine.Name = "textBoxaukstine";
            this.textBoxaukstine.Size = new System.Drawing.Size(100, 20);
            this.textBoxaukstine.TabIndex = 2;
            // 
            // buttonplotas
            // 
            this.buttonplotas.Location = new System.Drawing.Point(28, 136);
            this.buttonplotas.Name = "buttonplotas";
            this.buttonplotas.Size = new System.Drawing.Size(75, 23);
            this.buttonplotas.TabIndex = 4;
            this.buttonplotas.Text = "Skaiciuoti";
            this.buttonplotas.UseVisualStyleBackColor = true;
            this.buttonplotas.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxplotas
            // 
            this.textBoxplotas.Location = new System.Drawing.Point(28, 191);
            this.textBoxplotas.Name = "textBoxplotas";
            this.textBoxplotas.ReadOnly = true;
            this.textBoxplotas.Size = new System.Drawing.Size(100, 20);
            this.textBoxplotas.TabIndex = 5;
            this.textBoxplotas.TextChanged += new System.EventHandler(this.textBoxplotas_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Atsakymas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxplotas);
            this.Controls.Add(this.buttonplotas);
            this.Controls.Add(this.textBoxaukstine);
            this.Controls.Add(this.textBoxkrastine);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxkrastine;
        private System.Windows.Forms.TextBox textBoxaukstine;
        private System.Windows.Forms.Button buttonplotas;
        private System.Windows.Forms.TextBox textBoxplotas;
        private System.Windows.Forms.Label label2;
    }
}

