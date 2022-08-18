using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal interface IZreb
    {
        void vplaciloKombinacije(Kombinacija vplacanaKombinacija);
        void nakljucnaVplacila(int steviloNakljucnihKombinacij, SkupekStevil stevila);
        void priprava();
        void izvedba(double cenaKombinacije, double garantiranDobitniSklad, SkupekStevil stevila);
    }
}
