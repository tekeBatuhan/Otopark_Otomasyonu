using Otopark_Otomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace Otopark_Otomasyonu
{
    public partial class GecmisIslemler : Form
    {
        private OtoparkContext Context;
        public GecmisIslemler()
        {
            InitializeComponent();
            Context = new OtoparkContext();
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {

        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GecmisIslemler_Load(object sender, EventArgs e)
        {
            YenileGecmisIslemler();

        }
        private void YenileGecmisIslemler()
        {
            try
            {
                var gecmisIslemler = Context.GecmisIslem;

                dgvGecmisIslemler.DataSource = gecmisIslemler
                    .Select(g => new
                    {
                        GecmisIslemID = g.gecmisIslemID,
                        MusteriAd = g.Musteri.ad,
                        MusteriSoyad = g.Musteri.soyad,
                        MusteriTelefon = g.Musteri.telefon,
                        AracPlaka = g.plaka,
                        AracMarka = g.renk,
                        GirisTarihi = g.girisTarihi,
                        CikisTarihi = g.cikisTarihi,
                        Ucret = g.ucret

                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Close();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            try
            {
                using (var _context = new OtoparkContext())
                {
                    DateTime baslangicTarihi = dtpBaglangic.Value.Date;
                    DateTime bitisTarihi = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1); 

                    var filtrelenmisIslemler = _context.GecmisIslem
                        .Include(g => g.AracBilgi)
                        .Include(g => g.Musteri)
                        .Where(g => g.girisTarihi >= baslangicTarihi && g.girisTarihi <= bitisTarihi)
                        .ToList();

                    dgvGecmisIslemler.DataSource = filtrelenmisIslemler
                        .Select(g => new
                        {
                            GecmisIslemID = g.gecmisIslemID,
                            MusteriAd = g.Musteri.ad,
                            MusteriSoyad = g.Musteri.soyad,
                            MusteriTelefon = g.Musteri.telefon,
                            AracPlaka = g.plaka,
                            AracMarka = g.renk,
                            GirisTarihi = g.girisTarihi,
                            CikisTarihi = g.cikisTarihi,
                            Ucret = g.ucret ?? 0,
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            try
            {
                using (var Context = new OtoparkContext())
                {
                    DateTime baslangicTarihi = dtpBaglangic.Value.Date;
                    DateTime bitisTarihi = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);

                    decimal toplamCiro = Context.GecmisIslem
                        .Include(g => g.AracBilgi)
                        .Where(g => g.girisTarihi >= baslangicTarihi && g.girisTarihi <= bitisTarihi)
                        .Sum(g => g.ucret ?? 0);

                    lblSonuc.Text = toplamCiro.ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
