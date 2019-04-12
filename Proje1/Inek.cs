using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    class Inek : Hayvan
    {
        private int InekSutu;
        public int InekSutuFiyat = 5;
        public string inkSesYolu = "/Resources/inek.wav";
        public override int UrunVer()
        {
            return InekSutu++;
        }
        public override int UrunSayisi()
        {
            return InekSutu;
        }
        public override void UrunSat()
        {
            InekSutu = 0;
        }
    }
}
