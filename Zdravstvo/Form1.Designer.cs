namespace Zdravstvo
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
            this.dgvLekari = new System.Windows.Forms.DataGridView();
            this.cbBolnice = new System.Windows.Forms.ComboBox();
            this.tbInfoBolnica = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.groupLekari = new System.Windows.Forms.GroupBox();
            this.btnIzbrisiLekara = new System.Windows.Forms.Button();
            this.btnDodajLekara = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDodajUCekaonicu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVanBolnice = new System.Windows.Forms.Button();
            this.dgvHospitalizovani = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCekaonica = new System.Windows.Forms.DataGridView();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tbInfoLekar = new System.Windows.Forms.TextBox();
            this.btnPomoc = new System.Windows.Forms.Button();
            this.btnIzabraniLekar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLekari)).BeginInit();
            this.groupLekari.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalizovani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCekaonica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLekari
            // 
            this.dgvLekari.AllowUserToAddRows = false;
            this.dgvLekari.AllowUserToDeleteRows = false;
            this.dgvLekari.AllowUserToResizeColumns = false;
            this.dgvLekari.AllowUserToResizeRows = false;
            this.dgvLekari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLekari.Location = new System.Drawing.Point(-12, 19);
            this.dgvLekari.Name = "dgvLekari";
            this.dgvLekari.ReadOnly = true;
            this.dgvLekari.Size = new System.Drawing.Size(411, 172);
            this.dgvLekari.TabIndex = 0;
            this.dgvLekari.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLekari_CellClick);
            this.dgvLekari.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLekari_RowHeaderMouseClick);
            // 
            // cbBolnice
            // 
            this.cbBolnice.FormattingEnabled = true;
            this.cbBolnice.Location = new System.Drawing.Point(12, 12);
            this.cbBolnice.Name = "cbBolnice";
            this.cbBolnice.Size = new System.Drawing.Size(161, 21);
            this.cbBolnice.TabIndex = 1;
            this.cbBolnice.Text = "IZABERI BOLNICU";
            this.cbBolnice.SelectedIndexChanged += new System.EventHandler(this.cbBolnice_SelectedIndexChanged);
            // 
            // tbInfoBolnica
            // 
            this.tbInfoBolnica.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbInfoBolnica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInfoBolnica.Enabled = false;
            this.tbInfoBolnica.Location = new System.Drawing.Point(12, 39);
            this.tbInfoBolnica.Multiline = true;
            this.tbInfoBolnica.Name = "tbInfoBolnica";
            this.tbInfoBolnica.Size = new System.Drawing.Size(161, 100);
            this.tbInfoBolnica.TabIndex = 2;
            this.tbInfoBolnica.Visible = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Enabled = false;
            this.btnLogIn.Location = new System.Drawing.Point(61, 197);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(277, 23);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "uloguj se";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // groupLekari
            // 
            this.groupLekari.Controls.Add(this.btnIzbrisiLekara);
            this.groupLekari.Controls.Add(this.btnDodajLekara);
            this.groupLekari.Controls.Add(this.dgvLekari);
            this.groupLekari.Controls.Add(this.btnLogIn);
            this.groupLekari.Location = new System.Drawing.Point(12, 167);
            this.groupLekari.Name = "groupLekari";
            this.groupLekari.Size = new System.Drawing.Size(414, 276);
            this.groupLekari.TabIndex = 5;
            this.groupLekari.TabStop = false;
            this.groupLekari.Text = "Lekari:";
            // 
            // btnIzbrisiLekara
            // 
            this.btnIzbrisiLekara.Enabled = false;
            this.btnIzbrisiLekara.Location = new System.Drawing.Point(61, 253);
            this.btnIzbrisiLekara.Name = "btnIzbrisiLekara";
            this.btnIzbrisiLekara.Size = new System.Drawing.Size(277, 23);
            this.btnIzbrisiLekara.TabIndex = 5;
            this.btnIzbrisiLekara.Text = "izbrisi lekara";
            this.btnIzbrisiLekara.UseVisualStyleBackColor = true;
            this.btnIzbrisiLekara.Click += new System.EventHandler(this.btnIzbrisiLekara_Click);
            // 
            // btnDodajLekara
            // 
            this.btnDodajLekara.Enabled = false;
            this.btnDodajLekara.Location = new System.Drawing.Point(61, 226);
            this.btnDodajLekara.Name = "btnDodajLekara";
            this.btnDodajLekara.Size = new System.Drawing.Size(277, 23);
            this.btnDodajLekara.TabIndex = 4;
            this.btnDodajLekara.Text = "dodaj novog lekara";
            this.btnDodajLekara.UseVisualStyleBackColor = true;
            this.btnDodajLekara.Click += new System.EventHandler(this.btnDodajLekara_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIzabraniLekar);
            this.groupBox2.Controls.Add(this.btnDodajUCekaonicu);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnVanBolnice);
            this.groupBox2.Controls.Add(this.dgvHospitalizovani);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgvCekaonica);
            this.groupBox2.Location = new System.Drawing.Point(432, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 433);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pacijenti";
            // 
            // btnDodajUCekaonicu
            // 
            this.btnDodajUCekaonicu.Enabled = false;
            this.btnDodajUCekaonicu.Location = new System.Drawing.Point(6, 373);
            this.btnDodajUCekaonicu.Name = "btnDodajUCekaonicu";
            this.btnDodajUCekaonicu.Size = new System.Drawing.Size(238, 23);
            this.btnDodajUCekaonicu.TabIndex = 2;
            this.btnDodajUCekaonicu.Text = "Dodaj pacijenta u cekaonicu";
            this.btnDodajUCekaonicu.UseVisualStyleBackColor = true;
            this.btnDodajUCekaonicu.Click += new System.EventHandler(this.btnDodajUCekaonicu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "HOSPITALIZOVANI";
            // 
            // btnVanBolnice
            // 
            this.btnVanBolnice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnVanBolnice.Location = new System.Drawing.Point(6, 404);
            this.btnVanBolnice.Name = "btnVanBolnice";
            this.btnVanBolnice.Size = new System.Drawing.Size(238, 23);
            this.btnVanBolnice.TabIndex = 5;
            this.btnVanBolnice.Text = "Pacijenti koji su vam bolnice.";
            this.btnVanBolnice.UseVisualStyleBackColor = true;
            this.btnVanBolnice.Click += new System.EventHandler(this.btnVanBolnice_Click);
            // 
            // dgvHospitalizovani
            // 
            this.dgvHospitalizovani.AllowUserToAddRows = false;
            this.dgvHospitalizovani.AllowUserToDeleteRows = false;
            this.dgvHospitalizovani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospitalizovani.Location = new System.Drawing.Point(6, 217);
            this.dgvHospitalizovani.Name = "dgvHospitalizovani";
            this.dgvHospitalizovani.ReadOnly = true;
            this.dgvHospitalizovani.Size = new System.Drawing.Size(482, 150);
            this.dgvHospitalizovani.TabIndex = 3;
            this.dgvHospitalizovani.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHospitalizovani_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CEKAONICA";
            // 
            // dgvCekaonica
            // 
            this.dgvCekaonica.AllowUserToAddRows = false;
            this.dgvCekaonica.AllowUserToDeleteRows = false;
            this.dgvCekaonica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCekaonica.Location = new System.Drawing.Point(6, 45);
            this.dgvCekaonica.Name = "dgvCekaonica";
            this.dgvCekaonica.ReadOnly = true;
            this.dgvCekaonica.Size = new System.Drawing.Size(482, 150);
            this.dgvCekaonica.TabIndex = 0;
            this.dgvCekaonica.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCekaonica_CellClick);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(179, 145);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(158, 23);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "izloguj se";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Visible = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tbInfoLekar
            // 
            this.tbInfoLekar.BackColor = System.Drawing.SystemColors.Info;
            this.tbInfoLekar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInfoLekar.Enabled = false;
            this.tbInfoLekar.Location = new System.Drawing.Point(179, 39);
            this.tbInfoLekar.Multiline = true;
            this.tbInfoLekar.Name = "tbInfoLekar";
            this.tbInfoLekar.Size = new System.Drawing.Size(161, 100);
            this.tbInfoLekar.TabIndex = 7;
            this.tbInfoLekar.Visible = false;
            // 
            // btnPomoc
            // 
            this.btnPomoc.Location = new System.Drawing.Point(231, 10);
            this.btnPomoc.Name = "btnPomoc";
            this.btnPomoc.Size = new System.Drawing.Size(75, 23);
            this.btnPomoc.TabIndex = 8;
            this.btnPomoc.Text = "POMOC";
            this.btnPomoc.UseVisualStyleBackColor = true;
            this.btnPomoc.Click += new System.EventHandler(this.btnPomoc_Click);
            // 
            // btnIzabraniLekar
            // 
            this.btnIzabraniLekar.Enabled = false;
            this.btnIzabraniLekar.Location = new System.Drawing.Point(250, 373);
            this.btnIzabraniLekar.Name = "btnIzabraniLekar";
            this.btnIzabraniLekar.Size = new System.Drawing.Size(238, 23);
            this.btnIzabraniLekar.TabIndex = 9;
            this.btnIzabraniLekar.Text = "Prikazi pacijente kojima sam izabrani lekar";
            this.btnIzabraniLekar.UseVisualStyleBackColor = true;
            this.btnIzabraniLekar.Click += new System.EventHandler(this.btnIzabraniLekar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 455);
            this.Controls.Add(this.btnPomoc);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.tbInfoLekar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupLekari);
            this.Controls.Add(this.tbInfoBolnica);
            this.Controls.Add(this.cbBolnice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLekari)).EndInit();
            this.groupLekari.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalizovani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCekaonica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLekari;
        private System.Windows.Forms.ComboBox cbBolnice;
        private System.Windows.Forms.TextBox tbInfoBolnica;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.GroupBox groupLekari;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodajLekara;
        private System.Windows.Forms.DataGridView dgvCekaonica;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox tbInfoLekar;
        private System.Windows.Forms.Button btnIzbrisiLekara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajUCekaonicu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHospitalizovani;
        private System.Windows.Forms.Button btnVanBolnice;
        private System.Windows.Forms.Button btnPomoc;
        private System.Windows.Forms.Button btnIzabraniLekar;
    }
}

