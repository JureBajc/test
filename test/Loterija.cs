using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Loterija
    {
        private string ime;
        private double maksimalniNagradniSklad;
        private List<Zreb> seznamZrebov;
        private SkupekStevil naborStevil;
        private double cenaKombinacije;
        private List<Dobitek> seznamDobitkov;
        private double garantiranDobitniSklad;
        public double GarantiraniDobitniSklad
        {
            get { return garantiranDobitniSklad; }
        }
        public List<Zreb> SeznamZrebov
        {
            get { return seznamZrebov; }
        }

        public Loterija(string ime, double maksimalniNagradniSklad,
        SkupekStevil naborStevil,
        double cenaKombinacije,
        double garantiranDobitniSklad)
        {
            this.ime = ime;
            this.maksimalniNagradniSklad = maksimalniNagradniSklad;
            this.naborStevil = naborStevil;
            this.cenaKombinacije = cenaKombinacije;
            this.garantiranDobitniSklad = garantiranDobitniSklad;
        }
        public void dodajSeznamZrebov(List<Zreb> seznamZrebov)
        {
            this.seznamZrebov = seznamZrebov;
        }
        public void dodajDobitke(List<Dobitek> seznamDobitkov)
        {
            this.seznamDobitkov = seznamDobitkov;
        }
    }
}
