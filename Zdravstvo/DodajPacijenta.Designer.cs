namespace Zdravstvo.DomainModel
{
    partial class DodajPacijenta
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
            this.lbPacijenti = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRazlog = new System.Windows.Forms.TextBox();
            this.cbHitno = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegistruj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbGrad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDatum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOsiguran = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLekari = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPacijenti
            // 
            this.lbPacijenti.FormattingEnabled = true;
            this.lbPacijenti.Location = new System.Drawing.Point(6, 19);
            this.lbPacijenti.Name = "lbPacijenti";
            this.lbPacijenti.Size = new System.Drawing.Size(176, 264);
            this.lbPacijenti.TabIndex = 0;
            this.lbPacijenti.SelectedIndexChanged += new System.EventHandler(this.lbPacijenti_SelectedIndexChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Enabled = false;
            this.btnDodaj.Location = new System.Drawing.Point(543, 166);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(148, 58);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj starog pacijentau cekaonicu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Razlog dolaska u bolnicu:";
            // 
            // tbRazlog
            // 
            this.tbRazlog.Location = new System.Drawing.Point(521, 91);
            this.tbRazlog.Multiline = true;
            this.tbRazlog.Name = "tbRazlog";
            this.tbRazlog.Size = new System.Drawing.Size(198, 46);
            this.tbRazlog.TabIndex = 4;
            // 
            // cbHitno
            // 
            this.cbHitno.AutoSize = true;
            this.cbHitno.Location = new System.Drawing.Point(599, 143);
            this.cbHitno.Name = "cbHitno";
            this.cbHitno.Size = new System.Drawing.Size(51, 17);
            this.cbHitno.TabIndex = 5;
            this.cbHitno.Text = "Hitno";
            this.cbHitno.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPacijenti);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 295);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacijenti koji su van bolnice:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbLekari);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbOsiguran);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbStatus);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbDatum);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbGrad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbIme);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(257, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 295);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registruj novog pacijenta koji prvi put dolazi u bolnicu";
            // 
            // btnRegistruj
            // 
            this.btnRegistruj.Location = new System.Drawing.Point(543, 230);
            this.btnRegistruj.Name = "btnRegistruj";
            this.btnRegistruj.Size = new System.Drawing.Size(148, 58);
            this.btnRegistruj.TabIndex = 9;
            this.btnRegistruj.Text = "Registruj novog pacijentau cekaonicu";
            this.btnRegistruj.UseVisualStyleBackColor = true;
            this.btnRegistruj.Click += new System.EventHandler(this.btnRegistruj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(102, 35);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(142, 20);
            this.tbIme.TabIndex = 1;
            // 
            // tbGrad
            // 
            this.tbGrad.Location = new System.Drawing.Point(102, 61);
            this.tbGrad.Name = "tbGrad";
            this.tbGrad.Size = new System.Drawing.Size(142, 20);
            this.tbGrad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grad:";
            // 
            // tbDatum
            // 
            this.tbDatum.Location = new System.Drawing.Point(102, 87);
            this.tbDatum.Name = "tbDatum";
            this.tbDatum.Size = new System.Drawing.Size(142, 20);
            this.tbDatum.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Datum rodjenja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Zdravstveno osiguranje:";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(102, 113);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(142, 20);
            this.tbStatus.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Radni odnos:";
            // 
            // cbOsiguran
            // 
            this.cbOsiguran.AutoSize = true;
            this.cbOsiguran.Location = new System.Drawing.Point(139, 139);
            this.cbOsiguran.Name = "cbOsiguran";
            this.cbOsiguran.Size = new System.Drawing.Size(15, 14);
            this.cbOsiguran.TabIndex = 9;
            this.cbOsiguran.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Izabrani lekar:";
            // 
            // cbLekari
            // 
            this.cbLekari.FormattingEnabled = true;
            this.cbLekari.Location = new System.Drawing.Point(103, 167);
            this.cbLekari.Name = "cbLekari";
            this.cbLekari.Size = new System.Drawing.Size(142, 21);
            this.cbLekari.TabIndex = 11;
            // 
            // DodajPacijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 315);
            this.Controls.Add(this.btnRegistruj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbHitno);
            this.Controls.Add(this.tbRazlog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodaj);
            this.Name = "DodajPacijenta";
            this.Text = "DodajPacijenta";
            this.Load += new System.EventHandler(this.DodajPacijenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPacijenti;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRazlog;
        private System.Windows.Forms.CheckBox cbHitno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistruj;
        private System.Windows.Forms.TextBox tbDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGrad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.CheckBox cbOsiguran;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLekari;
        private System.Windows.Forms.Label label7;
    }
}