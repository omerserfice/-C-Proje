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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris frmgiris = new FrmAdminGiris();
            frmgiris.Show();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri frmMusteri = new FrmYeniMusteri();
            frmMusteri.Show();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar frmOdalar = new FrmOdalar();
            frmOdalar.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmMusteriler frm = new FrmMusteriler();
            frm.Show();

        }

        

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnHakkimizda_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Orange Hotel 2020 // Sivas-Merkez");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeldate.Text = DateTime.Now.ToLongDateString();
            labeltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersonelMaaslar_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();

        }

        private void btnStoklar_Click(object sender, EventArgs e)
        {
            Stoklar st = new Stoklar();
            st.Show();
        }

        private void btnRadyoDinle_Click(object sender, EventArgs e)
        {
            FrmRadyo radyo = new FrmRadyo();
            radyo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmGazete gzt = new FrmGazete();
            gzt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle guncelle = new FrmSifreGuncelle();
            guncelle.Show();
        }

        private void btnMusteriMesajlari_Click(object sender, EventArgs e)
        {
            FrmMesajlar msj = new FrmMesajlar();
            msj.Show();

        }
    }
}