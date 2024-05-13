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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Otopark_Otomasyonu
{
    public partial class Yetkili : Form
    {
        public Yetkili()
        {
            InitializeComponent();
        }

        private void txt1Saat_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (var Context = new OtoparkContext())
                {
                    string yeniDeger1 = txt1Saat.Text; 
                    string yeniDeger2 = txt3eKadarSaat.Text; 
                    string yeniDeger3 = txt3DenFazlaSaat.Text; 


                    SaatlikUcret saatlikUcretToUpdate = Context.SaatlikUcret.FirstOrDefault(); 

                    if (saatlikUcretToUpdate != null)
                    {
                        saatlikUcretToUpdate.birSaat = yeniDeger1; 
                        saatlikUcretToUpdate.ucSaat = yeniDeger2; 
                        saatlikUcretToUpdate.ucdenFazlaSaat = yeniDeger2; 
                                                                 

                        Context.SaveChanges(); 
                    }
                    else
                    {
                        MessageBox.Show("SaatlikUcret tablosunda güncellenecek bir kayıt bulunamadı.");
                    }
                    txt1Saat.Text = yeniDeger1;
                    txt3eKadarSaat.Text = yeniDeger2;
                    txt3DenFazlaSaat.Text = yeniDeger3;

                }


                MessageBox.Show("Veriler başarıyla güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }


        }
        private void txtGuncelle()
        {
            try
            {
                using (var Context = new OtoparkContext())
                {
                    var saatlikUcret = Context.SaatlikUcret.FirstOrDefault(); 

                    if (saatlikUcret != null)
                    {
                        txt1Saat.Text = saatlikUcret.birSaat;
                        txt3eKadarSaat.Text = saatlikUcret.ucSaat;
                        txt3DenFazlaSaat.Text = saatlikUcret.ucdenFazlaSaat;

                    }
                    else
                    {
                        MessageBox.Show("SaatlikUcret tablosunda gösterilecek veri bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void Yetkili_Load(object sender, EventArgs e)
        {
            txtGuncelle();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Personeller personeller = new Personeller();
            personeller.Show();
            this.Close();
        }
    }
}
