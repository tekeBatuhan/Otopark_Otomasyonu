using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Otopark_Otomasyonu.Model;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace Otopark_Otomasyonu
{
    public partial class Giris : Form
    {
        private readonly OtoparkContext dbContext;

        public Giris()
        {
            InitializeComponent();
            dbContext = new OtoparkContext();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void lblGiris_Click(object sender, EventArgs e)
        {

        }

        private void lblKullaniciSifre_Click(object sender, EventArgs e)
        {

        }



        private void btnGiris_Click(object sender, EventArgs e)
        {
            string eposta = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(eposta) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!");
                return;
            }

            Kullanici kullanici = dbContext.Kullanici
                .FirstOrDefault(k => k.eposta == eposta && k.sifre == sifre);

            if (kullanici != null)
            {
                Program.kullanici = kullanici;
                MessageBox.Show("GİRİŞ BAŞARILI :)");
                this.Hide();
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }

        }
       
    }
}
