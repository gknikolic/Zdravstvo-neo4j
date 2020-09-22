namespace Zdravstvo
{
    partial class PrikazIstorije
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
            this.tbPacijent = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISTORIJA BOLESTI ZA PACIJENTA: ";
            // 
            // tbPacijent
            // 
            this.tbPacijent.Location = new System.Drawing.Point(205, 6);
            this.tbPacijent.Name = "tbPacijent";
            this.tbPacijent.ReadOnly = true;
            this.tbPacijent.Size = new System.Drawing.Size(141, 20);
            this.tbPacijent.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(331, 267);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(148, 310);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 3;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // PrikazIstorije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 345);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbPacijent);
            this.Controls.Add(this.label1);
            this.Name = "PrikazIstorije";
            this.Text = "PrikazIstorije";
            this.Load += new System.EventHandler(this.PrikazIstorije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnIzadji;
        internal System.Windows.Forms.TextBox tbPacijent;
    }
}