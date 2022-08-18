using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class LoterijaSlovenije
    {
        private List<Loterija> loterijeVSloveniji;

        public double najvecjiDobitniSkladNaLoteriji()
        {
            double najvecji = 0.0;
            foreach (var loterija in loterijeVSloveniji)
            {
                if (loterija.GarantiraniDobitniSklad > najvecji) najvecji = loterija.GarantiraniDobitniSklad;
            }
            return najvecji;
        }
        public List<Zreb> IzvedeniZrebi()
        {
            List<Zreb> izvedeniZrebi = new List<Zreb>();
            foreach (var loterija in loterijeVSloveniji)
            {
                foreach (var zreb in loterija.SeznamZrebov)
                {
                    if (zreb.Izveden) izvedeniZrebi.Add(zreb);
                }
            }
            return izvedeniZrebi;
        }
    }
}
