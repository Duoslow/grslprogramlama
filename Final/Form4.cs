using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form4 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HNKEAPM;initial catalog=sahibinden;integrated security=true;");

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("select ilanlar.resim,ilanlar.id,ilanlar.baslik,ilanlar.aciklama,ilanlar.detay,ilanlar.adres,ilanlar.fiyat,ilanlar.tarih,kategoriler.kategori_adi,kategori_detay.kategori_detay,kullanicilar.kullanici_adi,kullanicilar.telefon from ilanlar inner join kullanicilar on ilanlar.kullanici_id=kullanicilar.id inner join kategoriler on ilanlar.kategori_id=kategoriler.id  inner join kategori_detay on ilanlar.kategori_detay_id=kategori_detay.id where ilanlar.id='" + Form2.secili_id+"'", baglanti);
                SqlDataReader veri = sorgu.ExecuteReader(CommandBehavior.CloseConnection);
                if (veri.HasRows)
                {
                    while (veri.Read())
                    {
                        Image img1;
                        img1 = Image.FromFile(veri["resim"].ToString());
                        pictureBox1.Image = img1;
                        baslik.Text = veri["baslik"].ToString();
                        kategori.Text = "> "+ veri["kategori_adi"].ToString()+" > "+ veri["kategori_detay"].ToString();
                        aciklama.Text = veri["aciklama"].ToString();
                        adres.Text = veri["adres"].ToString();
                        fiyat.Text = veri["fiyat"].ToString()+"₺";
                        ilan_tarihi.Text = veri["tarih"].ToString();
                        satıcı.Text = veri["kullanici_adi"].ToString();
                        ilan_no.Text = veri["id"].ToString();
                        telefon_text.Text = veri["telefon"].ToString();

                        string sa = veri["detay"].ToString();

                        string[] hee = Regex.Split(sa, @"\\n\s?");
                        foreach (string deger in hee)
                        {
                            detay.AppendText(deger + Environment.NewLine);
                        }

                    }

                }
                baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "form4", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
