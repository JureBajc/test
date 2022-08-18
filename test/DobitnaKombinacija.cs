using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class DobitnaKombinacija : Kombinacija
    {
        private double vrednostDobitka;
        private int stevilozrebanihStevil;
        private List<int> izrebanaStevila;

        public DobitnaKombinacija(int[] seznamIzbranihStevil, int steviloIzrebanihStevil, List<int> izrebanaStevila) : base(seznamIzbranihStevil)
        {
            this.stevilozrebanihStevil = steviloIzrebanihStevil;
            this.izrebanaStevila = izrebanaStevila;
        }
        public DobitnaKombinacija(int[] seznamIzbranihStevil, double vrednostDobitka, int steviloIzrebanihStevil, List<int> izrebanaStevila) : base(seznamIzbranihStevil)
        {
            this.vrednostDobitka = vrednostDobitka;
            this.stevilozrebanihStevil = steviloIzrebanihStevil;
            this.izrebanaStevila = izrebanaStevila;
        }
        public void DodajVrednostDobitka(double vrednostDobitka)
        {
            this.vrednostDobitka = vrednostDobitka;
        }
    }
}
