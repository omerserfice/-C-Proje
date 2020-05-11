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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1B6I7V3;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void verileriGoster()
        {
            listViewMesaj.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Mesajlar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["mesajId"].ToString();
                ekle.SubItems.Add(oku["adSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
                listViewMesaj.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

     


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlar(adSoyad,Mesaj) values('"+txtMesajAdsoyad.Text+"','"+txtMesaj.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
            txtMesajAdsoyad.Clear();
            txtMesaj.Clear();
        }
        int id = 0;
        private void listViewMesajDoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listViewMesaj.Items[0].SubItems[0].Text);
            txtMesajAdsoyad.Text = listViewMesaj.SelectedItems[0].SubItems[1].Text;
            txtMesaj.Text = listViewMesaj.SelectedItems[0].SubItems[2].Text;
        }
    }
}
