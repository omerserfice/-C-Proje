using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1B6I7V3;Initial Catalog=AycicegiPansiyon;Integrated Security=True");



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn101_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101 (Adi,Soyadi) values ('"+txtAdi.Text+"','"+txtSoyadi.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();


        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli odalar dolu odaları gösterir.");

        }

        private void btnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli odalar boş odaları gösterir.");
        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime BuyukTarih= Convert.ToDateTime(dtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

           // label11.Text = 

            ucret = Convert.ToInt32(Sonuc.TotalDays.ToString())*50;
            txtUcret.Text = ucret.ToString();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + cmbCinsiyet.Text+ "','" + MskTxtTelefon.Text + "','" + txtMail.Text + "','" + txtTc.Text + "','" + txtOdaNo.Text + "','" + txtUcret.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd")+"','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd")+"')", baglanti);
         komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı.");

            txtAdi.Clear();
            txtSoyadi.Clear();
            cmbCinsiyet.Text = "";
            MskTxtTelefon.Clear();
            txtMail.Text = "";
            txtTc.Clear();
            txtOdaNo.Clear();
            txtUcret.Clear();
            dtpGirisTarihi.Text = "";
            dtpCikisTarihi.Text = "";

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
          

        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            // ODA 101
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                btn101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
                btn101.Enabled = false;
            }
            // ODA 102
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                btn102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.Red;
                btn102.Enabled = false;
            }
            // ODA 103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                btn103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn103.Text != "103")
            {
                btn102.BackColor = Color.Red;
                btn103.Enabled = false;
            }
            // ODA 104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                btn104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn104.Text != "104")
            {
                btn104.BackColor = Color.Red;
                btn104.Enabled = false;
            }
            // ODA 105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                btn105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn105.Text != "105")
            {
                btn105.BackColor = Color.Red;
                btn105.Enabled = false;
            }
            // ODA 106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                btn106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn106.Text != "106")
            {
                btn106.BackColor = Color.Red;
                btn106.Enabled = false;
            }
            // ODA 107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                btn107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn107.Text != "107")
            {
                btn107.BackColor = Color.Red;
                btn107.Enabled = false;
            }
            // ODA 108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                btn108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn108.Text != "108")
            {
                btn108.BackColor = Color.Red;
                btn108.Enabled = false;
            }
            // ODA 109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                btn109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn109.Text != "109")
            {
                btn109.BackColor = Color.Red;
                btn109.Enabled = false;
            }
        }
    }
}
//Data Source=DESKTOP-1B6I7V3;Initial Catalog=AycicegiPansiyon;Integrated Security=True