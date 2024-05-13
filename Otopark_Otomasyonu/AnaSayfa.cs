using Otopark_Otomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public partial class AnaSayfa : Form
    {


        private ButtonManager buttonManager;

        private Giris giris;

        public AnaSayfa()
        {
            InitializeComponent();
            this.giris = new Giris();

            buttonManager = new ButtonManager(5, 6);
            InitializeUI();
        }
        private void InitializeUI()
        {
            List<System.Windows.Forms.Button> buttons = buttonManager.GetButtons();
            pnlYer.Controls.AddRange(buttons.ToArray());
            buttonManager.ButtonClick += ButtonManager_ButtonClick;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAracGiris_Click(object sender, EventArgs e)
        {

            try
            {
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                DateTime girisTarihi = dtpGirisTarihi.Value;
                string plaka = txtPlaka.Text;
                string marka = txtMartka.Text;
                string renk = txtRenk.Text;
                string yeri = txtYeri.Text;
                string telefon = txtTelefon.Text;
                if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(plaka) ||
                string.IsNullOrWhiteSpace(marka) || string.IsNullOrWhiteSpace(renk) || string.IsNullOrWhiteSpace(yeri) ||
                string.IsNullOrWhiteSpace(telefon))
                {
                    MessageBox.Show("Lütfen tüm bilgileri doldurun.");
                    return;
                }


                using (var Context = new OtoparkContext())
                {

                    var aracSil = Context.AracBilgi.FirstOrDefault(a => a.plaka == yeri);
                    if (aracSil == null)
                    {
                        var musteri = new Musteri
                        {
                            ad = ad,
                            soyad = soyad,
                            telefon = telefon,
                        };
                        Context.Musteri.Add(musteri);
                        Context.SaveChanges();

                        var yerKaydi = Context.Yer.FirstOrDefault(y => y.doluMu == false);

                        if (yerKaydi == null)
                        {
                            var yeniYer = new Yer
                            {
                                adı = yeri,
                                doluMu = true,
                            };
                            Context.Yer.Add(yeniYer);
                            Context.SaveChanges();

                            yerKaydi = yeniYer;
                        }
                        else
                        {
                            yerKaydi.doluMu = true;
                        }

                        var aracBilgi = new AracBilgi
                        {

                            girisTarihi = girisTarihi,
                            plaka = plaka,
                            marka = marka,
                            renk = renk,
                            musteriID = musteri.musteriID,
                            yerID = yerKaydi.yerID,
                        };

                        Context.AracBilgi.Add(aracBilgi);
                        Context.SaveChanges();
                        MessageBox.Show("MÜŞTERİ BAŞARILI BİR ŞEKİLDE KAYIT EDİLDİ :)");
                        this.Hide();
                        AnaSayfa anaSayfa = new AnaSayfa();
                        anaSayfa.Show();

                    }
                    else
                    {
                        MessageBox.Show("Kayıt Yapmak İstediginiz Yer Dolu!!");
                    }

                }
                Form2_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("!!! HATA !!!" + ex.Message);
            }

        }

        private void ButtonManager_ButtonClick(object sender, ButtonClickEventArgs e)
        {


            txtYeri.Text = e.ButtonText;




        }

        private void btnAracCikis_Click(object sender, EventArgs e)
        {

            try
            {
                string plakasSil = txtYeri.Text;
                if (string.IsNullOrWhiteSpace(plakasSil))
                {
                    MessageBox.Show("Lütfen Yer bilgisini Seçin.");
                    return;
                }

                using (var Context = new OtoparkContext())
                {
                    var aracSil = Context.AracBilgi.FirstOrDefault(a => a.plaka == plakasSil);

                    if (aracSil != null)
                    {
                        var musteriSil = Context.Musteri.FirstOrDefault(m => m.musteriID == aracSil.musteriID);

                        if (musteriSil != null)
                        {
                            var yerSil = Context.Yer.FirstOrDefault(y => y.yerID == aracSil.yerID);
                            if (yerSil != null)
                            {
                                yerSil.doluMu = false;
                            }
                            if (aracSil.cikisTarihi == null)
                            {
                                aracSil.cikisTarihi = DateTime.Now;
                            }


                            TimeSpan zamanFarki = (TimeSpan)(DateTime.Now - aracSil.girisTarihi);
                            double saatFarki = zamanFarki.TotalHours;

                            int ucret = HesaplaUcret(saatFarki);

                            MessageBox.Show($"Araç Çıkışı Başarılı! \nPark Süresi: {saatFarki:N2} saat\nÜcret: {ucret} TL");

                            GecmisIslem gecmisIslem = new GecmisIslem
                            {
                                musteriID = musteriSil.musteriID,
                                aracBilgiID = aracSil.aracBilgiID,
                                ucret = ucret,
                                plaka = aracSil.plaka,
                                marka = aracSil.marka,
                                cikisTarihi = aracSil.cikisTarihi,
                                girisTarihi = aracSil.girisTarihi,
                                renk = aracSil.renk,

                            };

                            AracBilgi aracBilgi = new AracBilgi
                            {
                                cikisTarihi = aracSil.cikisTarihi.Value,


                            };


                            Context.GecmisIslem.Add(gecmisIslem);
                            Context.AracBilgi.Remove(aracSil);

                            Context.SaveChanges();

                            Context.Yer.Remove(yerSil);

                            Context.SaveChanges();
                            this.Hide();
                            AnaSayfa anaSayfa = new AnaSayfa();
                            anaSayfa.Show();
                        }
                        else
                        {
                            MessageBox.Show("Müşteri bulunamadı!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Araç bulunamadı!");
                    }
                }
                Form2_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("!!! HATA !!!" + ex.Message);
            }

        }
        private int HesaplaUcret(double saatFarki)
        {
            OtoparkContext context = new OtoparkContext();
            var saatlikUcretBilgileri = context.SaatlikUcret.SingleOrDefault();

            int ucret = 0;


            if (saatFarki > 4)
            {
                ucret = Convert.ToInt32(saatFarki * Convert.ToInt32(saatlikUcretBilgileri.ucdenFazlaSaat));
            }
            else if (saatFarki > 1 && saatFarki <= 3)
            {
                ucret = Convert.ToInt32(saatFarki * Convert.ToInt32(saatlikUcretBilgileri.ucSaat));
            }
            else
            {
                ucret = Convert.ToInt32(saatlikUcretBilgileri.birSaat);


            }

            return ucret;
        }






        #region Yapılacaklar
        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();

            this.Close();

        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            Personeller personeller = new Personeller();
            personeller.Show();
            this.Close();
        }

        private void btnGecmisIslemler_Click(object sender, EventArgs e)
        {
            GecmisIslemler gecmisIslemler = new GecmisIslemler();
            gecmisIslemler.Show();
            this.Close();

        }



        private void gbGunsonu_Enter(object sender, EventArgs e)
        {

        }

        private void lblgirissaati_Click(object sender, EventArgs e)
        {

        }



        private void lblceptelefonu_Click(object sender, EventArgs e)
        {

        }




        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                using (var Context = new OtoparkContext())
                {
                    DateTime baslangicTarihi = DateTime.Today;
                    DateTime bitisTarihi = DateTime.Today.AddDays(1);

                    decimal? toplamCiro = Context.GecmisIslem
                        .Include(g => g.AracBilgi)
                        .Where(g => g.girisTarihi >= baslangicTarihi && g.girisTarihi < bitisTarihi)
                        .Sum(g => g.ucret);

                    if (toplamCiro.HasValue)
                    {
                        lblSonuc.Text = toplamCiro.Value.ToString("C");
                    }
                    else
                    {
                        lblSonuc.Text = "Toplam Ciro Bulunamadı";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
