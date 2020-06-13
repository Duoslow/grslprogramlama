using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HNKEAPM;initial catalog=sahibinden;integrated security=true;");
        public static string kul_id;
        public static string kul_ad;
        public static string kul_soyad;
        public static string kullanici_adi;
        public static string kullanici_sifre;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void grs_btn_Click(object sender, EventArgs e)
        {
            kullanici_adi = Convert.ToString(kul_textbox.Text);
            kullanici_sifre = Convert.ToString(sifre_textbox.Text);
            if (kullanici_adi == "")
            {
                MessageBox.Show("Kullanici Adi Giriniz","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                kul_textbox.Focus();
                return;
            }
            if (kullanici_sifre == "")
            {
                MessageBox.Show("Şifre Adi Giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sifre_textbox.Focus();
                return;
            }
            //Console.WriteLine("kullanici adi:"+kullanici_adi+" Sifre:"+kullanici_sifre);

            try
            {
                
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("Select * From kullanicilar WHERE kullanici_adi='" + kullanici_adi + "'AND sifre='" + kullanici_sifre + "' ", baglanti);
                SqlDataReader veri = sorgu.ExecuteReader(CommandBehavior.CloseConnection);
                if (veri.HasRows)
                {
                    while (veri.Read())
                    {
                        kul_id = veri["id"].ToString();
                        kul_ad = veri["ad"].ToString();
                        kul_soyad = veri["soyad"].ToString();
                        var test = new Form2();
                        test.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adın yada Şifren Yanlış","HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Giriş Yapılırken hata", MessageBoxButtons.OK, MessageBoxIcon.Error);     
            }
            finally
            {
                baglanti.Close();
                this.Hide();
            }
        }

        private void sifre_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                grs_btn.PerformClick();
            }
        }

        private void uye_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var kayit = new Form3();
            kayit.Show();
        }



    }
}
