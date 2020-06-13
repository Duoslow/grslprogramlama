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
    public partial class Form3 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HNKEAPM;initial catalog=sahibinden;integrated security=true;");
        public Form3()
        {
            InitializeComponent();
        }

        public void uye_btn_Click(object sender, EventArgs e)
        {
            string ad, soyad, kullanici, sifre, kul_ad, telefon;

            ad = Convert.ToString(ad_textbox.Text);
            soyad = Convert.ToString(soyad_textbox.Text);
            kullanici = Convert.ToString(kul_textbox.Text);
            sifre = Convert.ToString(sifre_textbox.Text);
            telefon = Convert.ToString(tel_textbox.Text);


            try
            {
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("Select * From kullanicilar WHERE kullanici_adi='" + kullanici + "'", baglanti);
                SqlDataReader veri = sorgu.ExecuteReader(CommandBehavior.CloseConnection);
                if (veri.HasRows)
                {
                    while (veri.Read())
                    {
                        kul_ad = veri["kullanici_adi"].ToString();
                        if (kul_ad == kullanici)
                        {
                            MessageBox.Show("Aynı Kullanıcı adıyla biri kayıt olmuş lütfen başka Kullanıcı adı seçiniz");
                            return;
                        }
                    }

                }
                else
                {
                    baglanti.Close();
                    try
                    {
                        
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("insert into kullanicilar (ad,soyad,kullanici_adi,sifre,telefon) VALUES (@ad,@soyad,@kullanici,@sifre,@telefon)",baglanti);
                        komut.Parameters.AddWithValue("@ad", ad);
                        komut.Parameters.AddWithValue("@soyad", soyad);
                        komut.Parameters.AddWithValue("@kullanici", kullanici);
                        komut.Parameters.AddWithValue("@sifre", sifre);
                        komut.Parameters.AddWithValue("@telefon", telefon);
                        komut.ExecuteNonQuery();
                        //MessageBox.Show("Başarıyla Kayıt olundu \n Kullanıcı adı:" + kullanici + " şifre: " + sifre + " ile Giriş Yapabilirsiniz");
                        this.Close();
                        var test = new Form1();
                        test.Show();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "form3", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        baglanti.Close();
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "form3", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

           
         
        }

        private void tel_textbox_Leave(object sender, EventArgs e)
        {
            if ((new Regex(@"05\d{9}")).IsMatch(tel_textbox.Text))
            {
                tel_textbox.ForeColor = Color.Black;
            }
            else
            {
                tel_textbox.ForeColor = Color.Red;
                MessageBox.Show("Lütfen Düzgün Telefon Numarası Giriniz \n örnek: 0531234567");
            }
        }

        private void ad_textbox_Leave(object sender, EventArgs e)
        {
            if (!(new Regex(@"\d")).IsMatch(ad_textbox.Text))
            {
                ad_textbox.ForeColor = Color.Black;
            }
            else
            {
                ad_textbox.ForeColor = Color.Red;
                MessageBox.Show("Lütfen Düzgün Bir Ad giriniz \nÖrnek: Uğur");
            }
        }

        private void soyad_textbox_Leave(object sender, EventArgs e)
        {
            if (!(new Regex(@"\d")).IsMatch(soyad_textbox.Text))
            {
                soyad_textbox.ForeColor = Color.Black;
            }
            else
            {
                soyad_textbox.ForeColor = Color.Red;
                MessageBox.Show("Lütfen Düzgün Bir Soyad giriniz \nÖrnek: Yavaş");
            }
        }
    }
}
