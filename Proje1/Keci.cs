using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    class Keci :Hayvan
    {
        private int KeciSutu;
        public int KeciSutuFiyat=8;
        public string KeciSesYolu = "/Resources/keci.wav";
        public override int UrunVer()
        {
            return KeciSutu++;
        }
        public override int UrunSayisi()
        {
            return KeciSutu;
        }
        public override void UrunSat()
        {
            KeciSutu = 0;
        }
    }
}
