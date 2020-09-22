namespace Zdravstvo
{
    partial class DodajLekara
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
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbGrad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDatum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOdeljenje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ime: ";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(91, 10);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(172, 20);
            this.tbIme.TabIndex = 1;
            // 
            // tbGrad
            // 
            this.tbGrad.Location = new System.Drawing.Point(91, 36);
            this.tbGrad.Name = "tbGrad";
            this.tbGrad.Size = new System.Drawing.Size(172, 20);
            this.tbGrad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "grad:";
            // 
            // tbDatum
            // 
            this.tbDatum.Location = new System.Drawing.Point(91, 62);
            this.tbDatum.Name = "tbDatum";
            this.tbDatum.Size = new System.Drawing.Size(172, 20);
            this.tbDatum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "datum rodjenja:";
            // 
            // tbOdeljenje
            // 
            this.tbOdeljenje.Location = new System.Drawing.Point(91, 88);
            this.tbOdeljenje.Name = "tbOdeljenje";
            this.tbOdeljenje.Size = new System.Drawing.Size(172, 20);
            this.tbOdeljenje.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "odeljenje:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(90, 144);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(172, 20);
            this.tbUsername.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "korisnicko ime:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(91, 170);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(172, 20);
            this.tbPassword.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "lozinka:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(57, 208);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(154, 23);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Rigistruj";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(57, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DodajLekara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 277);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbOdeljenje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGrad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label1);
            this.Name = "DodajLekara";
            this.Text = "DodajLekara";
            this.Load += new System.EventHandler(this.DodajLekara_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbGrad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOdeljenje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
    }
}