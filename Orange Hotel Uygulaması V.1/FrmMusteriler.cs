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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1B6I7V3;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        private void verileriGoster()
        {
            listViewKayit.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Müsteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listViewKayit.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }
        int id=0;
        private void listViewKayit_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listViewKayit.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = listViewKayit.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = listViewKayit.SelectedItems[0].SubItems[2].Text;
            cmbCinsiyet.Text = listViewKayit.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listViewKayit.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listViewKayit.SelectedItems[0].SubItems[5].Text;
            txtTc.Text = listViewKayit.SelectedItems[0].SubItems[6].Text;
            txtOdaNo.Text = listViewKayit.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listViewKayit.SelectedItems[0].SubItems[8].Text;
            dtpGirisTarihi.Text = listViewKayit.SelectedItems[0].SubItems[9].Text;
            dtpCikisTarihi.Text = listViewKayit.SelectedItems[0].SubItems[10].Text;
        }
      

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where Müsteriid=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();


            if (txtOdaNo.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda101", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();

            }
            if (txtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("delete from Oda102", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();

            }
            if (txtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut6 = new SqlCommand("delete from Oda106", baglanti);
                komut6.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();

            }
           




        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='"+txtAdi.Text+ "', Soyadi='" + txtSoyadi.Text+ "',Cinsiyet='" + cmbCinsiyet.Text+ "',Telefon='"+MskTxtTelefon.Text+ "',Mail='" + txtMail.Text + "',TC='" + txtTc.Text+ "',OdaNo='" + txtOdaNo.Text + "',Ucret='" + txtUcret.Text + "',GirisTarihi='" +dtpGirisTarihi.Value.ToString("yyyy-MM-dd")+ "',CikisTarihi='" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "' where Müsteriid=" +id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listViewKayit.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%"+textBox1.Text+ "%' and Soyadi like '%" + textBox1.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Müsteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listViewKayit.Items.Add(ekle);
            }
            baglanti.Close();

        }
    }
}
