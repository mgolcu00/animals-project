using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    class Ordek : Hayvan
    {
        private int OrdkYumurta;
        public string OrdekSesYolu = "/Resources/ordek.wav";
        public override int UrunVer()
        {
            return OrdkYumurta++;
        }
        public override int UrunSayisi()
        {
            return OrdkYumurta;
        }
        public int OrdekYumFiyat = 3;
        public override void UrunSat()
        {
            OrdkYumurta = 0;
        }

    }
}
