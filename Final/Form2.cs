using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form2 : Form
    {
        public Dictionary<string, string> kategori_detayları = new Dictionary<string, string>();
        public int secili;
        public static string secili_id,ilanlarim_secili;
        public string kopyalanacakdosyayolu;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HNKEAPM;initial catalog=sahibinden;integrated security=true;");
        public Form2()
        {
            InitializeComponent();
            datagrid();
            datagrid2();
            ayarlar();
            ana_icerik();
            ilanlarim();
            sabit_icerik();
        }

        public void ayarlar()
        {
            hg_msg.Text = Form1.kul_ad + " " + Form1.kul_soyad;
            durum_combo.SelectedIndex = 1;
            isit_combo.SelectedIndex = 1;
            balkon_combo.SelectedIndex = 1;
            vasita_durum.SelectedIndex = 1;
            cekis.SelectedIndex = 1;
            yakit.SelectedIndex = 1;
            renk.SelectedIndex = 1;
           // iller.SelectedIndex = 1;
           // ilceler.SelectedIndex = 1;
        }

        public void datagrid()
        {
            DataGridViewImageColumn dgvImageColumn = new DataGridViewImageColumn();
            DataGridViewTextBoxColumn dgvIdColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn kategoriColum = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn baslikColum = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn adresColum = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn tarihColum = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn fiyatColum = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn saticiColum = new DataGridViewTextBoxColumn();
            DataGridViewButtonColumn testColum = new DataGridViewButtonColumn();
            dgvIdColumn.HeaderText = "İlan No";
            kategoriColum.HeaderText = "Kategori";
            baslikColum.HeaderText = "Başlık";
            adresColum.HeaderText = "Adres";
            tarihColum.HeaderText = "Tarih";
            fiyatColum.HeaderText = "Fiyat";
            saticiColum.HeaderText = "Satıcı";
            testColum.HeaderText = "Detay";
            dgvImageColumn.HeaderText = "Fotoğraf";
            dgvImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 130;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns.Add(dgvImageColumn);
            dataGridView1.Columns.Add(dgvIdColumn);
            dataGridView1.Columns.Add(kategoriColum);
            dataGridView1.Columns.Add(baslikColum);
            dataGridView1.Columns.Add(adresColum);
            dataGridView1.Columns.Add(tarihColum);
            dataGridView1.Columns.Add(fiyatColum);
            dataGridView1.Columns.Add(saticiColum);
            dataGridView1.Columns.Add(testColum);
        }

        public void datagrid2()
        {
            DataGridViewImageColumn dgvImageColumn = new DataGridViewImageColumn();
            DataGridViewTextBoxColumn dgvIdColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn kategoriColum = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn baslikColum = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn aciklamaColum = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn adresColum = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn tarihColum = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn fiyatColum = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn saticiColum = new DataGridViewTextBoxColumn();
            DataGridViewButtonColumn testColum = new DataGridViewButtonColumn();
            DataGridViewButtonColumn silmeColum = new DataGridViewButtonColumn();
            dgvIdColumn.HeaderText = "İlan No";
            kategoriColum.HeaderText = "Kategori";
            baslikColum.HeaderText = "Başlık";
            aciklamaColum.HeaderText = "Açıklama";
            adresColum.HeaderText = "Adres";
            tarihColum.HeaderText = "Tarih";
            fiyatColum.HeaderText = "Fiyat";
            saticiColum.HeaderText = "Satıcı";
            testColum.HeaderText = "Düzenle";
            silmeColum.HeaderText = "Sil";
            dgvImageColumn.HeaderText = "Fotoğraf";
            dgvImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.RowTemplate.Height = 90;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.Columns.Add(dgvImageColumn);
            dataGridView2.Columns.Add(dgvIdColumn);
            dataGridView2.Columns.Add(kategoriColum);
            dataGridView2.Columns.Add(baslikColum);
            dataGridView2.Columns.Add(aciklamaColum);
            dataGridView2.Columns.Add(adresColum);
            dataGridView2.Columns.Add(tarihColum);
            dataGridView2.Columns.Add(fiyatColum);
            dataGridView2.Columns.Add(saticiColum);
            dataGridView2.Columns.Add(testColum);
            dataGridView2.Columns.Add(silmeColum);
        }

        public void datagridtemizle()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
        }

        public void sabit_icerik()
        {
            try
            {
                
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("Select * From kategoriler", baglanti);
                SqlDataReader veri = sorgu.ExecuteReader(CommandBehavior.CloseConnection);
                if (veri.HasRows)
                {
                    while (veri.Read())
                    {

                        kategori_listbox.Items.Add(veri["kategori_adi"].ToString());

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kategori Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }

            try
            {
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("Select * From iller", baglanti);
                SqlDataReader veri = sorgu.ExecuteReader(CommandBehavior.CloseConnection);
                if (veri.HasRows)
                {
                    while (veri.Read())
                    {

                        iller.Items.Add(veri["baslik"].ToString());
                        ilanlarim_il.Items.Add(veri["baslik"].ToString());

                    }

                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İl Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }
        
        public void ana_icerik()
        {
            try
            {
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("Select ilanlar.resim,ilanlar.id,ilanlar.kullanici_id,ilanlar.baslik,ilanlar.aciklama,ilanlar.detay,ilanlar.adres,ilanlar.fiyat,ilanlar.tarih,kategoriler.kategori_adi,kategori_detay.kategori_detay,kullanicilar.kullanici_adi from ilanlar inner join kategoriler on ilanlar.kategori_id=kategoriler.id inner join kategori_detay on kategori_detay.id=ilanlar.kategori_detay_id inner join kullanicilar on kullanicilar.id=ilanlar.Kullanici_id;", baglanti);
                SqlDataReader veri = sorgu.ExecuteReader();
                if (veri.HasRows)
                {
                    while (veri.Read())
                    {
                        Image img1;
                        img1 = Image.FromFile(veri["resim"].ToString());
                        /*ÖRNEK ŞABLON
                        dataGridView1.Rows.Add(img1, "1", "emlak", "Uygun Fiyatlı ev", "Tekirdağ/Şarköy", "6/7/2020", "600.000₺", "kullanıcı adı", "detay");*/
                        dataGridView1.Rows.Add(img1, veri["id"].ToString(), veri["kategori_adi"].ToString() + "--" + veri["kategori_detay"].ToString(), veri["baslik"].ToString(), veri["adres"].ToString(), veri["tarih"].ToString(), veri["fiyat"].ToString() + "₺", veri["kullanici_adi"],"Detaylar");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ilanlar hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                baglanti.Close();
            }
        }

        public void ilanlarim()
        {
            try
            {
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("Select ilanlar.resim,ilanlar.id,ilanlar.kullanici_id,ilanlar.baslik,ilanlar.aciklama,ilanlar.detay,ilanlar.adres,ilanlar.fiyat,ilanlar.tarih,kategoriler.kategori_adi,kategori_detay.kategori_detay,kullanicilar.kullanici_adi from ilanlar inner join kategoriler on ilanlar.kategori_id=kategoriler.id inner join kategori_detay on kategori_detay.id=ilanlar.kategori_detay_id inner join kullanicilar on kullanicilar.id=ilanlar.Kullanici_id WHERE kullanici_id='" + Form1.kul_id+"'", baglanti);
                SqlDataReader veri = sorgu.ExecuteReader();
                if (veri.HasRows)
                {
                    while (veri.Read())
                    {
                        Image img1;
                        img1 = Image.FromFile(veri["resim"].ToString());
                        /*ÖRNEK ŞABLON
                        dataGridView1.Rows.Add(img1, "1", "emlak", "Uygun Fiyatlı ev", "Tekirdağ/Şarköy", "6/7/2020", "600.000₺", "kullanıcı adı", "detay");*/
                        dataGridView2.Rows.Add(img1, veri["id"].ToString(), veri["kategori_adi"].ToString() + "--" + veri["kategori_detay"].ToString(), veri["baslik"].ToString(), veri["aciklama"].ToString(), veri["adres"].ToString(), veri["tarih"].ToString(), veri["fiyat"].ToString(), veri["kullanici_adi"], "Düzenle..","Sil");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ilanlarım hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                baglanti.Close();
            }
        }

        private void resim_sec_Click(object sender, EventArgs e)
        {
            string dosyaAdi;
            string klasor = Application.StartupPath.ToString() + "\\" + "resimler";
            if (!Directory.Exists(klasor)) 
            {
                Directory.CreateDirectory(klasor);
            }
            openFileDialog1.FileName = "*";
            openFileDialog1.Filter = "Resim Dosyaları (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|Tüm Dosyalar (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "Resim Dosyası Aç";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Random rastgele = new Random();
                int sayi = rastgele.Next(255);
                string dosyayolu = openFileDialog1.FileName;
                kopyalanacakdosyayolu = klasor + "\\" + sayi+ openFileDialog1.SafeFileName;

                File.Copy(dosyayolu, kopyalanacakdosyayolu, true);
                Console.WriteLine(kopyalanacakdosyayolu,dosyayolu);
                secilen_res.ImageLocation = dosyayolu;
                dosyaAdi = openFileDialog1.SafeFileName;
            }
            else
            {
                MessageBox.Show("Dosya Seçilmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void kategori_adi_SelectedIndexChanged(object sender, EventArgs e)
        {
            detay_listbox.Items.Clear();
            string secili_olan = kategori_listbox.SelectedItem.ToString();
            secili = Convert.ToInt32(kategori_listbox.SelectedIndex.ToString());
            secili++;
            kategori_detayları.Clear();
            try
            {
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("Select kategoriler.kategori_adi,kategori_detay.id,kategori_detay.kategori_detay From kategoriler inner join kategori_detay on kategoriler.id=kategori_detay.kategori_id where kategoriler.id='" + secili+"'",baglanti);
                SqlDataReader veri = sorgu.ExecuteReader(CommandBehavior.CloseConnection);
                if (veri.HasRows)
                {
                    while (veri.Read())
                    {
                        kategori_detayları.Add(veri["kategori_detay"].ToString(), veri["id"].ToString());
                        detay_listbox.Items.Add(veri["kategori_detay"].ToString());
                        
                    }

                    if (secili == 1){ilan_detayları.Visible = true;}
                    else { ilan_detayları.Visible = false;}
                    if(secili == 2){vasis.Visible = true;}
                    else {vasis.Visible = false; }

                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "kategori seçimi hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                baglanti.Close();
            }
        }

        private void iller_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceler.Items.Clear();
            int secili;
            secili = Convert.ToInt32(iller.SelectedIndex.ToString());
            secili++;
            Console.WriteLine(iller.SelectedItem.ToString());
            Console.WriteLine(secili);
            try
            {
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("Select iller.baslik,ilceler.ilceler_baslik From iller inner join ilceler on iller.id=ilceler.ilid where iller.id='" + secili + "'", baglanti);
                SqlDataReader veri = sorgu.ExecuteReader(CommandBehavior.CloseConnection);
                if (veri.HasRows)
                {
                    while (veri.Read())
                    {
                        ilceler.Items.Add(veri["ilceler_baslik"].ToString());
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İlceler Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                baglanti.Close();
            }
        }

        private void gndr_btn_Click(object sender, EventArgs e)
        {
            
            string baslik, aciklama, detay, adres, kategori_detay;
            int fiyat;
            string tarih = DateTime.Now.ToShortDateString();
            aciklama = Convert.ToString(acik_textbox.Text);
            baslik = Convert.ToString(baslik_txt.Text);
            fiyat = Convert.ToInt32(fiyat_txt.Text);
            adres = iller.SelectedItem.ToString() + " / " + ilceler.SelectedItem.ToString();
            kategori_detay = kategori_detayları[detay_listbox.SelectedItem.ToString()] ;

            if (secili == 1)
            {
                detay = "Durum: " + durum_combo.SelectedItem.ToString() + "\nM^2: " + m2.Text + "\nOda Sayısı: " + oda.Text + "\nBanyo Sayısı: " + banyo.Text +
                    "\nBulunduğu Kat: " + kat.Text + "\nAidat: " + aidat.Text + "\nBinanın Yaşı: " + yas.Text + "\nIsıtma Türü: " + isit_combo.SelectedItem.ToString() +
                    "\nBalkon: " + balkon_combo.SelectedItem.ToString();
            }
            else if (secili == 2)
            {
                detay = "Durum: " + vasita_durum.SelectedItem.ToString() + "\nYapım Yılı: " + yılı.Text + "\nMarkası: " + Marka.Text + "\nSerisi: " +
                    serisi.Text + "\nVites: " + vites.Text + "\nKM: " + km.Text + "\nÇekiş: " + cekis.SelectedItem.ToString() + "\nYakıt Türü: " + yakit.SelectedItem.ToString() +
                    "\nRenk: " + renk.SelectedItem.ToString();
            }
            else
            {
                detay = "";
            }

            Console.WriteLine(secili + kategori_detay);
           

            //Console.WriteLine(tarih+" "+ baslik + " "+aciklama+" "+fiyat+" "+adres+" "+kategori+" "+kategori_detay);
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into ilanlar (resim,kategori_id,kategori_detay_id,kullanici_id,baslik,aciklama,detay,adres,fiyat,tarih) VALUES (@resim,@kategori_id,@kategori_detay_id,@kullanici_id,@baslik,@aciklama,@detay,@adres,@fiyat,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@resim", kopyalanacakdosyayolu);
                komut.Parameters.AddWithValue("@kategori_id", secili);
                komut.Parameters.AddWithValue("@kategori_detay_id", kategori_detay);
                komut.Parameters.AddWithValue("@kullanici_id", Form1.kul_id);
                komut.Parameters.AddWithValue("@baslik", baslik);
                komut.Parameters.AddWithValue("@aciklama", aciklama);
                komut.Parameters.AddWithValue("@detay", detay);
                komut.Parameters.AddWithValue("@adres", adres);
                komut.Parameters.AddWithValue("@fiyat", fiyat);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.ExecuteNonQuery();
                MessageBox.Show("İlan Eklendi");
            }
             
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message,"gönderirken hata");
            }
            finally
            {
                baglanti.Close();
                datagridtemizle();
                ilanlarim();
                ana_icerik();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==8)
            {
                int numberRow = Convert.ToInt32(e.RowIndex);
                var valueIndex = dataGridView1.Rows[numberRow].Cells[1].Value;
                secili_id = Convert.ToString(valueIndex);
                Console.WriteLine(secili_id);
                var test = new Form4();
                test.Show();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                ilanlarim_group.Visible = true;
                int numberRow = Convert.ToInt32(e.RowIndex);
                var valueIndex = dataGridView2.Rows[numberRow].Cells[1].Value;
                var baslik = dataGridView2.Rows[numberRow].Cells[3].Value;
                var aciklama = dataGridView2.Rows[numberRow].Cells[4].Value;
                var fiyat = dataGridView2.Rows[numberRow].Cells[7].Value;
                var adres = dataGridView2.Rows[numberRow].Cells[5].Value;
                ilanlarim_secili = Convert.ToString(valueIndex);
                Console.WriteLine(ilanlarim_secili);
                ilanlarim_baslik.Text = Convert.ToString(baslik);
                ilanlarim_aciklama.Text = Convert.ToString(aciklama);
                ilanlarim_fiyat.Text = Convert.ToString(fiyat);

                string sa = adres.ToString();
                string[] hee = Regex.Split(sa, @"\s\/\s");
                ilanlarim_il.SelectedIndex = ilanlarim_il.FindStringExact(hee[0]);
                ilanlarim_ilceler.SelectedIndex = ilanlarim_ilceler.FindStringExact(hee[1]);
                Console.WriteLine(hee[0]+hee[1]);
            }
  
            if (e.ColumnIndex == 10)
            {
                int test = Convert.ToInt32(e.RowIndex);
                var silinecek = dataGridView2.Rows[test].Cells[1].Value;
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from ilanlar where id='"+Convert.ToInt32(silinecek)+"'", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("İlan Silindi");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Silme Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    baglanti.Close();
                    datagridtemizle();
                    ana_icerik();
                    ilanlarim();
                }

            }
        }

        private void ilanlarim_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilanlarim_ilceler.Items.Clear();
            int ilaniarim_secili;
            ilaniarim_secili = Convert.ToInt32(ilanlarim_il.SelectedIndex.ToString());
            ilaniarim_secili++;
            Console.WriteLine(ilanlarim_il.SelectedItem.ToString());
            Console.WriteLine(ilaniarim_secili);
            try
            {
                //   SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HNKEAPM;initial catalog=sahibinden;integrated security=true;");
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("Select iller.baslik,ilceler.ilceler_baslik From iller inner join ilceler on iller.id=ilceler.ilid where iller.id='" + ilaniarim_secili + "'", baglanti);
                SqlDataReader veri = sorgu.ExecuteReader(CommandBehavior.CloseConnection);
                if (veri.HasRows)
                {
                    while (veri.Read())
                    {
                        ilanlarim_ilceler.Items.Add(veri["ilceler_baslik"].ToString());
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İlceler Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var cikis = new Form1();
            cikis.Show();

        }

        private void ilanlarim_guncelle_Click(object sender, EventArgs e)
        {
            string yeni_baslik, yeni_fiyat, yeni_aciklama, yeni_adres;
            yeni_baslik = ilanlarim_baslik.Text;
            yeni_aciklama = ilanlarim_aciklama.Text;
            yeni_fiyat = ilanlarim_fiyat.Text;
            yeni_adres = ilanlarim_il.SelectedItem.ToString()+" / "+ilanlarim_ilceler.SelectedItem.ToString();
            Console.WriteLine(yeni_baslik+yeni_fiyat+yeni_aciklama+yeni_adres);
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update ilanlar set baslik=@baslik , aciklama=@aciklama , fiyat=@fiyat , adres=@adres where id='"+ ilanlarim_secili + "' ",baglanti);
                komut.Parameters.AddWithValue("@baslik", yeni_baslik);
                komut.Parameters.AddWithValue("@aciklama", yeni_aciklama);
                komut.Parameters.AddWithValue("@fiyat", yeni_fiyat);
                komut.Parameters.AddWithValue("@adres", yeni_adres);
                komut.ExecuteNonQuery();
                MessageBox.Show("İlan Güncellendi");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Güncelleme Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                baglanti.Close();
                datagridtemizle();
                ana_icerik();
                ilanlarim();
            }

        }


    }
}