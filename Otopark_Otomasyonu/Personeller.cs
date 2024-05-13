using Otopark_Otomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public partial class Personeller : Form
    {
        private readonly OtoparkContext dbContext;

        public Personeller()
        {

            InitializeComponent();

            dbContext = new OtoparkContext();

        }


        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new OtoparkContext())
                {

                    string secilenUnvanAdi = cbUnvan.SelectedItem?.ToString();
                    var unvan = dbContext.Unvan.FirstOrDefault(u => u.ad == secilenUnvanAdi);

                    Kullanici yeniKullanici = new Kullanici
                    {
                        ad = txtAd.Text,
                        soyad = txtSoyad.Text,
                        eposta = txtEposta.Text,
                        sifre = txtSifre.Text,
                        adres = txtAdres.Text,
                        telefon = txtTelefon.Text,
                        kimlikNo = txtKimlikNo.Text,
                        dogumTarihi = dtpDogumTarihi.Value,
                        cinsiyet = cbCinsiyet.Text,
                        unvanID = unvan.unvanID
                        
                    };

                    dbContext.Kullanici.Add(yeniKullanici);
                    dbContext.SaveChanges();

                    MessageBox.Show("PERSONEL BAŞARILI BİR ŞEKİLDE KAYIT EDİLDİ :)");
                }

                Personeller_Load_1(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("!!! HATA !!!" + ex.Message);
            }
        }

        private void Personeller_Load_1(object sender, EventArgs e)
        {
            YenilePersoneller();
            ComboBoxDoldur();

        }

        private void ComboBoxDoldur()
        {
            try
            {
                using (var dbContext = new OtoparkContext())
                {
                    var unvanAdlari = dbContext.Unvan.Select(u => u.ad).ToList();

                    cbUnvan.Items.Clear();

                    cbUnvan.Items.AddRange(unvanAdlari.Select(ad => ad.ToString()).ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.ToString());
            }
        }

        private void YenilePersoneller()
        {
            try
            {
                var personeller = dbContext.Kullanici;
                var unvan = dbContext.Unvan;



                dgvPersonel.DataSource = personeller
                    .Join(unvan, p => p.unvanID, u => u.unvanID, (p, u) => new

                    {
                        KullanıcıID = p.kullaniciID,
                        Unvan = u.ad,
                        Ad = p.ad,
                        Soyad = p.soyad,
                        EPosta = p.eposta,
                        Şifre = p.sifre,
                        Adres = p.adres,
                        Telefon = p.telefon,
                        KimlikNo = p.kimlikNo,
                        DoğumTarihi = p.dogumTarihi,
                        Cinsiyet = p.cinsiyet

                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

        }

        private void dgvPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvPersonel.CurrentRow.Cells[0].Value.ToString();
            cbUnvan.Text = dgvPersonel.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dgvPersonel.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dgvPersonel.CurrentRow.Cells[3].Value.ToString();
            txtEposta.Text = dgvPersonel.CurrentRow.Cells[4].Value.ToString();
            txtSifre.Text = dgvPersonel.CurrentRow.Cells[5].Value.ToString();
            txtAdres.Text = dgvPersonel.CurrentRow.Cells[6].Value.ToString();
            txtTelefon.Text = dgvPersonel.CurrentRow.Cells[7].Value.ToString();
            txtKimlikNo.Text = dgvPersonel.CurrentRow.Cells[8].Value.ToString();
            dtpDogumTarihi.Text = dgvPersonel.CurrentRow.Cells[9].Value.ToString();
            cbCinsiyet.Text = dgvPersonel.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonel.CurrentRow != null)
                {
                    int kullaniciID = Convert.ToInt32(dgvPersonel.CurrentRow.Cells[0].Value);

                    using (var dbContext = new OtoparkContext())
                    {
                        Kullanici silinecekKullanici = dbContext.Kullanici.FirstOrDefault(k => k.kullaniciID == kullaniciID);

                        if (silinecekKullanici != null)
                        {
                            dbContext.Kullanici.Remove(silinecekKullanici);
                            dbContext.SaveChanges();

                            MessageBox.Show("PERSONEL BAŞARILI BİR ŞEKİLDE SİLİNDİ :)");
                        }
                        else
                        {
                            MessageBox.Show("SİLME İŞLEMİ GERÇEKLEŞMEDİ :(");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek bir kişi seçin.");
                }

                Personeller_Load_1(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("!!! HATA !!!" + ex.Message);
            }
        }

        private void pnlPersonel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAd_Click(object sender, EventArgs e)
        {

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonel.CurrentRow != null)
                {
                    int kullaniciID = Convert.ToInt32(dgvPersonel.CurrentRow.Cells[0].Value);

                    using (var dbContext = new OtoparkContext())
                    {
                        Kullanici Kullanici = dbContext.Kullanici.FirstOrDefault(k => k.kullaniciID == kullaniciID);

                        if (Kullanici != null)
                        {
                            Kullanici.ad = txtAd.Text;
                            Kullanici.soyad = txtSoyad.Text;
                            Kullanici.eposta = txtEposta.Text;
                            Kullanici.sifre = txtSifre.Text;
                            Kullanici.adres = txtAdres.Text;
                            Kullanici.telefon = txtTelefon.Text;
                            Kullanici.kimlikNo = txtKimlikNo.Text;
                            Kullanici.dogumTarihi = dtpDogumTarihi.Value;
                            Kullanici.cinsiyet = cbCinsiyet.Text;


                            Unvan secilenUnvan = GetSelectedUnvan();
                            if (secilenUnvan != null)
                            {
                                Kullanici.unvanID = secilenUnvan.unvanID;
                            }


                            dbContext.SaveChanges();

                            MessageBox.Show("PERSONEL BAŞARILI BİR ŞEKİLDE GÜNCELLENDİ :)");
                            Personeller_Load_1(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("GÜNCELLEME İŞLEMİ GERÇEKLEŞMEDİ :(");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen güncellenecek bir kişi seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("!!! HATA !!!" + ex.Message);
            }
        }
        private Unvan GetSelectedUnvan()
        {
            if (cbUnvan.SelectedItem != null)
            {
                string selectedUnvanAd = cbUnvan.SelectedItem.ToString();

                using (var dbContext = new OtoparkContext())
                {
                    return dbContext.Unvan.FirstOrDefault(u => u.ad == selectedUnvanAd);
                }
            }

            return null;
        }
        private void dgvPersonel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnYetkili_Click(object sender, EventArgs e)
        {
            if (Program.kullanici.unvanID == 1)
            {
                Yetkili yetkiliForm = new Yetkili();


                yetkiliForm.Show();

                this.Close();

            }
            else
            {
                MessageBox.Show("Yetki Yetersiz!");
            }

        }

        private void cbUnvan_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
