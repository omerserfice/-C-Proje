using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmRadyo : Form
    {
        public FrmRadyo()
        {
            InitializeComponent();
        }

        private void lnkLabelKanal1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://mpegpowerturk.listenpowerapp.com/powerturk/mpeg/icecast.audio";
        }

        private void lnkLblKanal2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/166/ ";
        }

        private void lnkLblKanal3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://yayin1.canliyayin.org:8180/";
        }
    }
}
