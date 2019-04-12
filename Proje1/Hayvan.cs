using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    abstract class Hayvan
    {
        protected int fiyat;
        public abstract int UrunVer();
        public abstract int UrunSayisi();
        public abstract void UrunSat();
    }
}
