using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kelime_islem
{
    public partial class Form1 : Form
    {
        sayim islem = new sayim(); //sayim class adı islem nesnenin adı new bellekte yer ayırır



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rtbMetin_TextChanged(object sender, EventArgs e)
        {
            string metnim;
            int hs,cs,ks;

            metnim = rtbMetin.Text;

            hs = islem.kac_harf(metnim);
            lbHarf.Text = hs.ToString();

            ks = islem.kac_kelime(metnim);
            lbKelime.Text = ks.ToString();

            cs = islem.kac_cumle(metnim);
            lbCumle.Text = cs.ToString();


        }
    }
}
