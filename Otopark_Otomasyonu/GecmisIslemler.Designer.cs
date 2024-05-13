namespace Otopark_Otomasyonu
{
    partial class GecmisIslemler
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
            this.dgvGecmisIslemler = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblCikis = new System.Windows.Forms.Label();
            this.lblGiris = new System.Windows.Forms.Label();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaglangic = new System.Windows.Forms.DateTimePicker();
            this.btnToplam = new System.Windows.Forms.Button();
            this.btnFiltrele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmisIslemler)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGecmisIslemler
            // 
            this.dgvGecmisIslemler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGecmisIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecmisIslemler.Location = new System.Drawing.Point(12, 12);
            this.dgvGecmisIslemler.Name = "dgvGecmisIslemler";
            this.dgvGecmisIslemler.Size = new System.Drawing.Size(691, 413);
            this.dgvGecmisIslemler.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblSonuc);
            this.panel1.Controls.Add(this.lblToplam);
            this.panel1.Controls.Add(this.lblCikis);
            this.panel1.Controls.Add(this.lblGiris);
            this.panel1.Controls.Add(this.btnAnaSayfa);
            this.panel1.Controls.Add(this.dtpBitis);
            this.panel1.Controls.Add(this.dtpBaglangic);
            this.panel1.Controls.Add(this.btnToplam);
            this.panel1.Controls.Add(this.btnFiltrele);
            this.panel1.Location = new System.Drawing.Point(719, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 413);
            this.panel1.TabIndex = 1;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(153, 307);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(13, 13);
            this.lblSonuc.TabIndex = 8;
            this.lblSonuc.Text = "0";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(130, 272);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(67, 20);
            this.lblToplam.TabIndex = 7;
            this.lblToplam.Text = "Toplam";
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.Location = new System.Drawing.Point(6, 62);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(93, 20);
            this.lblCikis.TabIndex = 6;
            this.lblCikis.Text = "Bitiş Tarihi";
            this.lblCikis.Click += new System.EventHandler(this.lblCikis_Click);
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.Location = new System.Drawing.Point(3, 23);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(136, 20);
            this.lblGiris.TabIndex = 5;
            this.lblGiris.Text = "Başlangıç Tarihi";
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.Azure;
            this.btnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Location = new System.Drawing.Point(99, 350);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(128, 50);
            this.btnAnaSayfa.TabIndex = 4;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(142, 62);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(162, 20);
            this.dtpBitis.TabIndex = 3;
            this.dtpBitis.ValueChanged += new System.EventHandler(this.dtpBitis_ValueChanged);
            // 
            // dtpBaglangic
            // 
            this.dtpBaglangic.Location = new System.Drawing.Point(142, 23);
            this.dtpBaglangic.Name = "dtpBaglangic";
            this.dtpBaglangic.Size = new System.Drawing.Size(162, 20);
            this.dtpBaglangic.TabIndex = 2;
            // 
            // btnToplam
            // 
            this.btnToplam.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnToplam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToplam.Location = new System.Drawing.Point(99, 188);
            this.btnToplam.Name = "btnToplam";
            this.btnToplam.Size = new System.Drawing.Size(128, 50);
            this.btnToplam.TabIndex = 1;
            this.btnToplam.Text = "Toplam";
            this.btnToplam.UseVisualStyleBackColor = false;
            this.btnToplam.Click += new System.EventHandler(this.btnToplam_Click);
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnFiltrele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiltrele.Location = new System.Drawing.Point(99, 115);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(128, 54);
            this.btnFiltrele.TabIndex = 0;
            this.btnFiltrele.Text = "Filtrle";
            this.btnFiltrele.UseVisualStyleBackColor = false;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // GecmisIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvGecmisIslemler);
            this.Name = "GecmisIslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GecmisIslemler";
            this.Load += new System.EventHandler(this.GecmisIslemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmisIslemler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGecmisIslemler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaglangic;
        private System.Windows.Forms.Button btnToplam;
        private System.Windows.Forms.Button btnFiltrele;
    }
}