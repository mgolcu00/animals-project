using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    class Tavuk : Hayvan
    {
        private int TvkYumurta = 0;
        public string TvkSesYolu = "/Resources/tavuk.wav";

        public override int UrunVer()
        {
            TvkYumurta++;
            return TvkYumurta;
        }

        public override int UrunSayisi()
        {
            return TvkYumurta;
        }

        public int tvkYumFiyat = 1;

       
        public override void UrunSat()
        {
            TvkYumurta = 0;
        }
    }
}
