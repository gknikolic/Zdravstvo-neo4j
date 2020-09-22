namespace Zdravstvo
{
    partial class NapisiIzvestaj
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
            this.tbInfoPacijent = new System.Windows.Forms.TextBox();
            this.btnIstorija = new System.Windows.Forms.Button();
            this.btnKolikoPuta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBolest = new System.Windows.Forms.TextBox();
            this.tbTerapija = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numKotrola = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbHospitalizacija = new System.Windows.Forms.CheckBox();
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDatum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRazlog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numKotrola)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInfoPacijent
            // 
            this.tbInfoPacijent.Enabled = false;
            this.tbInfoPacijent.Location = new System.Drawing.Point(12, 21);
            this.tbInfoPacijent.Multiline = true;
            this.tbInfoPacijent.Name = "tbInfoPacijent";
            this.tbInfoPacijent.Size = new System.Drawing.Size(206, 141);
            this.tbInfoPacijent.TabIndex = 0;
            // 
            // btnIstorija
            // 
            this.btnIstorija.Location = new System.Drawing.Point(253, 31);
            this.btnIstorija.Name = "btnIstorija";
            this.btnIstorija.Size = new System.Drawing.Size(229, 23);
            this.btnIstorija.TabIndex = 1;
            this.btnIstorija.Text = "Prikazi istoriju bolesti";
            this.btnIstorija.UseVisualStyleBackColor = true;
            this.btnIstorija.Click += new System.EventHandler(this.btnIstorija_Click);
            // 
            // btnKolikoPuta
            // 
            this.btnKolikoPuta.Location = new System.Drawing.Point(253, 60);
            this.btnKolikoPuta.Name = "btnKolikoPuta";
            this.btnKolikoPuta.Size = new System.Drawing.Size(229, 23);
            this.btnKolikoPuta.TabIndex = 2;
            this.btnKolikoPuta.Text = "Koliko puta je bio u bolnici?";
            this.btnKolikoPuta.UseVisualStyleBackColor = true;
            this.btnKolikoPuta.Click += new System.EventHandler(this.btnKolikoPuta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dijagnoza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Terapija";
            // 
            // tbBolest
            // 
            this.tbBolest.Location = new System.Drawing.Point(118, 256);
            this.tbBolest.Multiline = true;
            this.tbBolest.Name = "tbBolest";
            this.tbBolest.Size = new System.Drawing.Size(364, 64);
            this.tbBolest.TabIndex = 7;
            // 
            // tbTerapija
            // 
            this.tbTerapija.Location = new System.Drawing.Point(118, 333);
            this.tbTerapija.Multiline = true;
            this.tbTerapija.Name = "tbTerapija";
            this.tbTerapija.Size = new System.Drawing.Size(364, 32);
            this.tbTerapija.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kotrola za:";
            // 
            // numKotrola
            // 
            this.numKotrola.Location = new System.Drawing.Point(76, 388);
            this.numKotrola.Name = "numKotrola";
            this.numKotrola.Size = new System.Drawing.Size(50, 20);
            this.numKotrola.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "dana.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Potrebna hospitalizacija?";
            // 
            // cbHospitalizacija
            // 
            this.cbHospitalizacija.AutoSize = true;
            this.cbHospitalizacija.Location = new System.Drawing.Point(323, 389);
            this.cbHospitalizacija.Name = "cbHospitalizacija";
            this.cbHospitalizacija.Size = new System.Drawing.Size(29, 17);
            this.cbHospitalizacija.TabIndex = 13;
            this.cbHospitalizacija.Text = ".";
            this.cbHospitalizacija.UseVisualStyleBackColor = true;
            this.cbHospitalizacija.CheckedChanged += new System.EventHandler(this.cbHospitalizacija_CheckedChanged);
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.Location = new System.Drawing.Point(253, 431);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(242, 23);
            this.btnZavrsi.TabIndex = 14;
            this.btnZavrsi.Text = "Zavrsi pregled";
            this.btnZavrsi.UseVisualStyleBackColor = true;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Datum:";
            // 
            // tbDatum
            // 
            this.tbDatum.BackColor = System.Drawing.SystemColors.Info;
            this.tbDatum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDatum.Enabled = false;
            this.tbDatum.Location = new System.Drawing.Point(59, 436);
            this.tbDatum.Name = "tbDatum";
            this.tbDatum.Size = new System.Drawing.Size(159, 13);
            this.tbDatum.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pacijent se zali na:";
            // 
            // tbRazlog
            // 
            this.tbRazlog.Location = new System.Drawing.Point(118, 180);
            this.tbRazlog.Multiline = true;
            this.tbRazlog.Name = "tbRazlog";
            this.tbRazlog.Size = new System.Drawing.Size(364, 64);
            this.tbRazlog.TabIndex = 19;
            // 
            // NapisiIzvestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 476);
            this.Controls.Add(this.tbRazlog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDatum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnZavrsi);
            this.Controls.Add(this.cbHospitalizacija);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numKotrola);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTerapija);
            this.Controls.Add(this.tbBolest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKolikoPuta);
            this.Controls.Add(this.btnIstorija);
            this.Controls.Add(this.tbInfoPacijent);
            this.Name = "NapisiIzvestaj";
            this.Text = "Izvestaj";
            this.Load += new System.EventHandler(this.NapisiIzvestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKotrola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInfoPacijent;
        private System.Windows.Forms.Button btnIstorija;
        private System.Windows.Forms.Button btnKolikoPuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBolest;
        private System.Windows.Forms.TextBox tbTerapija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numKotrola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbHospitalizacija;
        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRazlog;
    }
}