using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Proje1
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();
        Tavuk tavuk = new  Tavuk();
        Ordek ordek = new Ordek();
        Inek inek = new Inek();
        Keci keci = new Keci();
        public int gecenSure = 0;
        public int KasaDurum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrTavuk.Interval = 3000;
            tmrTavuk.Enabled = true;
            tmrOrdek.Interval = 5000;
            tmrOrdek.Enabled = true;
            tmrKeci.Interval = 7000;
            tmrKeci.Enabled = true;
            tmrInek.Interval = 8000;
            tmrInek.Enabled = true;
            tmrGenel.Interval = 1000;
            tmrGenel.Enabled = true;
            tvkCan.Value = 100;
            odkCan.Value = 100;
            kciCan.Value = 100;
            inkCan.Value = 100;
            DurumKontrol(100, tvkDurum);
            DurumKontrol(100, odkDurum);
            DurumKontrol(100, kciDurum);
            DurumKontrol(100, inkDurum);
        }

        private void tmrGenel_Tick(object sender, EventArgs e)
        {
            gecenSure++;
            if (2 < tvkCan.Value)
            {
                tvkCan.Value = tvkCan.Value-2;
            }
            else
            {
                DurumKontrol(tvkCan.Value, tvkDurum);
                tvkCan.Value = 0;
                tmrTavuk.Interval = 10;
            }

            if (3 < odkCan.Value)
            {
                odkCan.Value = odkCan.Value-3;
            }
            else
            {
                odkCan.Value = 0;
                DurumKontrol(odkCan.Value, odkDurum);
                tmrOrdek.Interval = 10;
            }

            if (6 < kciCan.Value)
            {
                kciCan.Value = kciCan.Value - 6;
            }
            else
            {
                kciCan.Value = 0;
                DurumKontrol(kciCan.Value, kciDurum);
                tmrKeci.Interval = 10;
            }

            if (8 < inkCan.Value)
            {
                inkCan.Value = inkCan.Value - 8;
            }
            else
            {
                inkCan.Value = 0;
                DurumKontrol(inkCan.Value, inkDurum);
                tmrInek.Interval = 10;
            }
            EkranaYaz();
        }

        public void DurumKontrol(int deger, TextBox t)
        {
            if (deger == 0)
            {
                t.ForeColor = Color.Red;
                t.Text = "ÖLDÜ";
            }
            else
            {
                t.ForeColor = Color.ForestGreen;
                t.Text = "CANLI";
            }
        }

        private void btnTvkYem_Click(object sender, EventArgs e)
        {
            if (tvkCan.Value > 0)
            {
                tvkCan.Value = 100;
            }
        }

        private void btnOdkYem_Click(object sender, EventArgs e)
        {
            if (odkCan.Value > 0)
            {
                odkCan.Value = 100;
            }
        }

        private void btnInekYem_Click(object sender, EventArgs e)
        {
            if (inkCan.Value > 0)
            {
                inkCan.Value = 100;
            }
        }

        private void btnKciYem_Click(object sender, EventArgs e)
        {
            if (kciCan.Value > 0)
            {
                kciCan.Value = 100;
            }
        }

        private void tmrTavuk_Tick(object sender, EventArgs e)
        {
            if (tvkCan.Value > 0)
            {
                tavuk.UrunVer();
            }
            else
            {
                SesCal(tavuk.TvkSesYolu);
                tmrTavuk.Enabled = false;
            }
               
        }

        private void tmrOrdek_Tick(object sender, EventArgs e)
        {
            if (odkCan.Value > 0)
            {
                ordek.UrunVer();
            }
            else
            {
                SesCal(ordek.OrdekSesYolu);
                tmrOrdek.Enabled = false;
            }
        }

        private void tmrInek_Tick(object sender, EventArgs e)
        {
            if (inkCan.Value > 0)
            {
                inek.UrunVer();
            }
            else
            {
                SesCal(inek.inkSesYolu);
                tmrInek.Enabled = false;
            }
                
        }

        private void tmrKeci_Tick(object sender, EventArgs e)
        {
            if (kciCan.Value > 0)
            {
                keci.UrunVer();
            }
            else
            {
                SesCal(keci.KeciSesYolu);
                tmrKeci.Enabled = false;
            }
        }

        private void btnTvkSat_Click(object sender, EventArgs e)
        {
            KasaDurum += tavuk.UrunSayisi() * tavuk.tvkYumFiyat;
            tavuk.UrunSat();
        }
        public void EkranaYaz()
        {
                txtKasaMik.Text = KasaDurum + " TL";
                txtGecenSureMik.Text = gecenSure + " sn";
                txtTvkYumSay.Text = tavuk.UrunSayisi() + " Adet";
                txtOrdekYumSay.Text = ordek.UrunSayisi() + " Adet";
                txtKeciSutKG.Text = keci.UrunSayisi() + " KG";
                txtInekSutKG.Text = inek.UrunSayisi() + " KG";
        }

        private void btnOdkSat_Click(object sender, EventArgs e)
        {
            KasaDurum += ordek.UrunSayisi() * ordek.OrdekYumFiyat;
            ordek.UrunSat();
        }

        private void btnInkSat_Click(object sender, EventArgs e)
        {
            KasaDurum += inek.UrunSayisi() * inek.InekSutuFiyat;
            inek.UrunSat();
        }

        private void btnKeciSat_Click(object sender, EventArgs e)
        {
            KasaDurum += keci.UrunSayisi() * keci.KeciSutuFiyat;
            keci.UrunSat();
        }
        public void SesCal(string sesYolu)
        {
            player.SoundLocation = Application.StartupPath.ToString() + sesYolu;
            player.Play();
        }
    }

}
