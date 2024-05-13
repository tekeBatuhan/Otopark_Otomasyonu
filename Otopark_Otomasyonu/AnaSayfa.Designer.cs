using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    partial class AnaSayfa
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
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.btnGecmisIslemler = new System.Windows.Forms.Button();
            this.pnlKontrol = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAracCikis = new System.Windows.Forms.Button();
            this.pnlAracIslemler = new System.Windows.Forms.Panel();
            this.lblAracIslemler = new System.Windows.Forms.Label();
            this.btnAracGiris = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.lblad = new System.Windows.Forms.Label();
            this.lblgiristarihi = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblplaka = new System.Windows.Forms.Label();
            this.lblmarka = new System.Windows.Forms.Label();
            this.lblrenk = new System.Windows.Forms.Label();
            this.lblceptelefonu = new System.Windows.Forms.Label();
            this.lblyeri = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtYeri = new System.Windows.Forms.TextBox();
            this.txtMartka = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.gbAracBilgi = new System.Windows.Forms.GroupBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblgunsonu = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.gbGunsonu = new System.Windows.Forms.GroupBox();
            this.pnlYer = new System.Windows.Forms.Panel();
            this.pnlKontrol.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAracIslemler.SuspendLayout();
            this.gbAracBilgi.SuspendLayout();
            this.gbGunsonu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.BackColor = System.Drawing.Color.White;
            this.btnPersoneller.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersoneller.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersoneller.Location = new System.Drawing.Point(10, 109);
            this.btnPersoneller.Margin = new System.Windows.Forms.Padding(2);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(190, 62);
            this.btnPersoneller.TabIndex = 1;
            this.btnPersoneller.Text = "Personeller";
            this.btnPersoneller.UseVisualStyleBackColor = false;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // btnGecmisIslemler
            // 
            this.btnGecmisIslemler.BackColor = System.Drawing.Color.White;
            this.btnGecmisIslemler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGecmisIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecmisIslemler.Location = new System.Drawing.Point(10, 194);
            this.btnGecmisIslemler.Margin = new System.Windows.Forms.Padding(2);
            this.btnGecmisIslemler.Name = "btnGecmisIslemler";
            this.btnGecmisIslemler.Size = new System.Drawing.Size(190, 62);
            this.btnGecmisIslemler.TabIndex = 1;
            this.btnGecmisIslemler.Text = "Geçmiş İşlemler";
            this.btnGecmisIslemler.UseVisualStyleBackColor = false;
            this.btnGecmisIslemler.Click += new System.EventHandler(this.btnGecmisIslemler_Click);
            // 
            // pnlKontrol
            // 
            this.pnlKontrol.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlKontrol.Controls.Add(this.btnCikis);
            this.pnlKontrol.Controls.Add(this.pnlMenu);
            this.pnlKontrol.Controls.Add(this.btnGecmisIslemler);
            this.pnlKontrol.Controls.Add(this.btnPersoneller);
            this.pnlKontrol.Location = new System.Drawing.Point(9, 11);
            this.pnlKontrol.Margin = new System.Windows.Forms.Padding(2);
            this.pnlKontrol.Name = "pnlKontrol";
            this.pnlKontrol.Size = new System.Drawing.Size(214, 352);
            this.pnlKontrol.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkRed;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(10, 277);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(190, 62);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Cıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click_1);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Location = new System.Drawing.Point(35, 18);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(147, 47);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(32, 11);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(81, 26);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "MENÜ";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnAracCikis);
            this.panel1.Controls.Add(this.pnlAracIslemler);
            this.panel1.Controls.Add(this.btnAracGiris);
            this.panel1.Location = new System.Drawing.Point(9, 374);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 249);
            this.panel1.TabIndex = 2;
            // 
            // btnAracCikis
            // 
            this.btnAracCikis.BackColor = System.Drawing.Color.White;
            this.btnAracCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAracCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracCikis.Location = new System.Drawing.Point(10, 175);
            this.btnAracCikis.Margin = new System.Windows.Forms.Padding(2);
            this.btnAracCikis.Name = "btnAracCikis";
            this.btnAracCikis.Size = new System.Drawing.Size(190, 62);
            this.btnAracCikis.TabIndex = 1;
            this.btnAracCikis.Text = "Araç Çıkışı";
            this.btnAracCikis.UseVisualStyleBackColor = false;
            this.btnAracCikis.Click += new System.EventHandler(this.btnAracCikis_Click);
            // 
            // pnlAracIslemler
            // 
            this.pnlAracIslemler.BackColor = System.Drawing.Color.White;
            this.pnlAracIslemler.Controls.Add(this.lblAracIslemler);
            this.pnlAracIslemler.Location = new System.Drawing.Point(25, 22);
            this.pnlAracIslemler.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAracIslemler.Name = "pnlAracIslemler";
            this.pnlAracIslemler.Size = new System.Drawing.Size(166, 47);
            this.pnlAracIslemler.TabIndex = 0;
            // 
            // lblAracIslemler
            // 
            this.lblAracIslemler.AutoSize = true;
            this.lblAracIslemler.BackColor = System.Drawing.Color.White;
            this.lblAracIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAracIslemler.Location = new System.Drawing.Point(5, 9);
            this.lblAracIslemler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAracIslemler.Name = "lblAracIslemler";
            this.lblAracIslemler.Size = new System.Drawing.Size(159, 26);
            this.lblAracIslemler.TabIndex = 0;
            this.lblAracIslemler.Text = "Araç İşlemleri";
            // 
            // btnAracGiris
            // 
            this.btnAracGiris.BackColor = System.Drawing.Color.White;
            this.btnAracGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAracGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracGiris.Location = new System.Drawing.Point(10, 93);
            this.btnAracGiris.Margin = new System.Windows.Forms.Padding(2);
            this.btnAracGiris.Name = "btnAracGiris";
            this.btnAracGiris.Size = new System.Drawing.Size(190, 62);
            this.btnAracGiris.TabIndex = 1;
            this.btnAracGiris.Text = "Araç Girişi";
            this.btnAracGiris.UseVisualStyleBackColor = false;
            this.btnAracGiris.Click += new System.EventHandler(this.btnAracGiris_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblad.Location = new System.Drawing.Point(5, 65);
            this.lblad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(109, 20);
            this.lblad.TabIndex = 0;
            this.lblad.Text = "Müşteri Adı :";
            // 
            // lblgiristarihi
            // 
            this.lblgiristarihi.AutoSize = true;
            this.lblgiristarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgiristarihi.Location = new System.Drawing.Point(4, 150);
            this.lblgiristarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgiristarihi.Name = "lblgiristarihi";
            this.lblgiristarihi.Size = new System.Drawing.Size(110, 20);
            this.lblgiristarihi.TabIndex = 0;
            this.lblgiristarihi.Text = "Giriş Tarihi : ";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(4, 111);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(137, 20);
            this.lblSoyad.TabIndex = 0;
            this.lblSoyad.Text = "Müşteri Soyadı :";
            // 
            // lblplaka
            // 
            this.lblplaka.AutoSize = true;
            this.lblplaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblplaka.Location = new System.Drawing.Point(287, 65);
            this.lblplaka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblplaka.Name = "lblplaka";
            this.lblplaka.Size = new System.Drawing.Size(68, 20);
            this.lblplaka.TabIndex = 1;
            this.lblplaka.Text = "Plaka : ";
            // 
            // lblmarka
            // 
            this.lblmarka.AutoSize = true;
            this.lblmarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmarka.Location = new System.Drawing.Point(286, 112);
            this.lblmarka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmarka.Name = "lblmarka";
            this.lblmarka.Size = new System.Drawing.Size(68, 20);
            this.lblmarka.TabIndex = 2;
            this.lblmarka.Text = "Marka :";
            // 
            // lblrenk
            // 
            this.lblrenk.AutoSize = true;
            this.lblrenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblrenk.Location = new System.Drawing.Point(286, 150);
            this.lblrenk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrenk.Name = "lblrenk";
            this.lblrenk.Size = new System.Drawing.Size(61, 20);
            this.lblrenk.TabIndex = 3;
            this.lblrenk.Text = "Renk :";
            // 
            // lblceptelefonu
            // 
            this.lblceptelefonu.AutoSize = true;
            this.lblceptelefonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblceptelefonu.Location = new System.Drawing.Point(4, 197);
            this.lblceptelefonu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblceptelefonu.Name = "lblceptelefonu";
            this.lblceptelefonu.Size = new System.Drawing.Size(79, 20);
            this.lblceptelefonu.TabIndex = 3;
            this.lblceptelefonu.Text = "Telefon :";
            this.lblceptelefonu.Click += new System.EventHandler(this.lblceptelefonu_Click);
            // 
            // lblyeri
            // 
            this.lblyeri.AutoSize = true;
            this.lblyeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyeri.Location = new System.Drawing.Point(286, 197);
            this.lblyeri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblyeri.Name = "lblyeri";
            this.lblyeri.Size = new System.Drawing.Size(56, 20);
            this.lblyeri.TabIndex = 3;
            this.lblyeri.Text = "Yeri : ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(141, 65);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(129, 20);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(140, 112);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(129, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(379, 67);
            this.txtPlaka.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(129, 20);
            this.txtPlaka.TabIndex = 4;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(379, 151);
            this.txtRenk.Margin = new System.Windows.Forms.Padding(2);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(129, 20);
            this.txtRenk.TabIndex = 6;
            // 
            // txtYeri
            // 
            this.txtYeri.Enabled = false;
            this.txtYeri.Location = new System.Drawing.Point(379, 200);
            this.txtYeri.Margin = new System.Windows.Forms.Padding(2);
            this.txtYeri.Name = "txtYeri";
            this.txtYeri.Size = new System.Drawing.Size(129, 20);
            this.txtYeri.TabIndex = 7;
            // 
            // txtMartka
            // 
            this.txtMartka.Location = new System.Drawing.Point(379, 111);
            this.txtMartka.Margin = new System.Windows.Forms.Padding(2);
            this.txtMartka.Name = "txtMartka";
            this.txtMartka.Size = new System.Drawing.Size(129, 20);
            this.txtMartka.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(140, 196);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefon.MaxLength = 11;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(129, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(200, 3);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 26);
            this.label13.TabIndex = 1;
            this.label13.Text = "Araç Bilgi";
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Location = new System.Drawing.Point(140, 149);
            this.dtpGirisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(129, 20);
            this.dtpGirisTarihi.TabIndex = 2;
            // 
            // gbAracBilgi
            // 
            this.gbAracBilgi.BackColor = System.Drawing.Color.Silver;
            this.gbAracBilgi.Controls.Add(this.dtpGirisTarihi);
            this.gbAracBilgi.Controls.Add(this.label13);
            this.gbAracBilgi.Controls.Add(this.txtTelefon);
            this.gbAracBilgi.Controls.Add(this.txtMartka);
            this.gbAracBilgi.Controls.Add(this.txtYeri);
            this.gbAracBilgi.Controls.Add(this.txtRenk);
            this.gbAracBilgi.Controls.Add(this.txtPlaka);
            this.gbAracBilgi.Controls.Add(this.txtSoyad);
            this.gbAracBilgi.Controls.Add(this.txtAd);
            this.gbAracBilgi.Controls.Add(this.lblyeri);
            this.gbAracBilgi.Controls.Add(this.lblceptelefonu);
            this.gbAracBilgi.Controls.Add(this.lblrenk);
            this.gbAracBilgi.Controls.Add(this.lblmarka);
            this.gbAracBilgi.Controls.Add(this.lblplaka);
            this.gbAracBilgi.Controls.Add(this.lblSoyad);
            this.gbAracBilgi.Controls.Add(this.lblgiristarihi);
            this.gbAracBilgi.Controls.Add(this.lblad);
            this.gbAracBilgi.Location = new System.Drawing.Point(233, 374);
            this.gbAracBilgi.Margin = new System.Windows.Forms.Padding(2);
            this.gbAracBilgi.Name = "gbAracBilgi";
            this.gbAracBilgi.Padding = new System.Windows.Forms.Padding(2);
            this.gbAracBilgi.Size = new System.Drawing.Size(545, 249);
            this.gbAracBilgi.TabIndex = 3;
            this.gbAracBilgi.TabStop = false;
            this.gbAracBilgi.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(84, 67);
            this.lblToplam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(67, 20);
            this.lblToplam.TabIndex = 1;
            this.lblToplam.Text = "Toplam";
            // 
            // lblgunsonu
            // 
            this.lblgunsonu.AutoSize = true;
            this.lblgunsonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgunsonu.Location = new System.Drawing.Point(64, 7);
            this.lblgunsonu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgunsonu.Name = "lblgunsonu";
            this.lblgunsonu.Size = new System.Drawing.Size(118, 26);
            this.lblgunsonu.TabIndex = 1;
            this.lblgunsonu.Text = "Gün Sonu";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.White;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHesapla.Location = new System.Drawing.Point(69, 165);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(2);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(113, 51);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.BackColor = System.Drawing.Color.White;
            this.lblSonuc.Location = new System.Drawing.Point(111, 111);
            this.lblSonuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(13, 13);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "0";
            // 
            // gbGunsonu
            // 
            this.gbGunsonu.BackColor = System.Drawing.Color.Silver;
            this.gbGunsonu.Controls.Add(this.lblSonuc);
            this.gbGunsonu.Controls.Add(this.btnHesapla);
            this.gbGunsonu.Controls.Add(this.lblgunsonu);
            this.gbGunsonu.Controls.Add(this.lblToplam);
            this.gbGunsonu.Location = new System.Drawing.Point(795, 374);
            this.gbGunsonu.Margin = new System.Windows.Forms.Padding(2);
            this.gbGunsonu.Name = "gbGunsonu";
            this.gbGunsonu.Padding = new System.Windows.Forms.Padding(2);
            this.gbGunsonu.Size = new System.Drawing.Size(244, 249);
            this.gbGunsonu.TabIndex = 4;
            this.gbGunsonu.TabStop = false;
            this.gbGunsonu.Enter += new System.EventHandler(this.gbGunsonu_Enter);
            // 
            // pnlYer
            // 
            this.pnlYer.Location = new System.Drawing.Point(233, 11);
            this.pnlYer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlYer.Name = "pnlYer";
            this.pnlYer.Size = new System.Drawing.Size(806, 352);
            this.pnlYer.TabIndex = 5;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 634);
            this.Controls.Add(this.pnlYer);
            this.Controls.Add(this.gbGunsonu);
            this.Controls.Add(this.gbAracBilgi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlKontrol);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.SizeChanged += new System.EventHandler(this.Form2_Load);
            this.pnlKontrol.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlAracIslemler.ResumeLayout(false);
            this.pnlAracIslemler.PerformLayout();
            this.gbAracBilgi.ResumeLayout(false);
            this.gbAracBilgi.PerformLayout();
            this.gbGunsonu.ResumeLayout(false);
            this.gbGunsonu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersoneller;
        private System.Windows.Forms.Button btnGecmisIslemler;
        private System.Windows.Forms.Panel pnlKontrol;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAracCikis;
        private System.Windows.Forms.Label lblAracIslemler;
        private System.Windows.Forms.Panel pnlAracIslemler;
        private System.Windows.Forms.Button btnAracGiris;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private Label lblad;
        private Label lblgiristarihi;
        private Label lblSoyad;
        private Label lblplaka;
        private Label lblmarka;
        private Label lblrenk;
        private Label lblceptelefonu;
        private Label lblyeri;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtPlaka;
        private TextBox txtRenk;
        private TextBox txtYeri;
        private TextBox txtMartka;
        private TextBox txtTelefon;
        private Label label13;
        private DateTimePicker dtpGirisTarihi;
        private GroupBox gbAracBilgi;
        private Label lblToplam;
        private Label lblgunsonu;
        private Button btnHesapla;
        private Label lblSonuc;
        private GroupBox gbGunsonu;
        private Panel pnlYer;
    }
}