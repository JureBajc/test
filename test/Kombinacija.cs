using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Kombinacija
    {
        private int[] seznamIzbraniStevil;
        private DateTime datumVplacila;

        public int[] IzbranaStevila{
            get { return seznamIzbraniStevil; }
        }
        public DateTime Datum
        {
            get { return datumVplacila; }
        }

        public Kombinacija(int[] seznamIzbranihStevil)
        {
            this.seznamIzbraniStevil = seznamIzbraniStevil;
            this.datumVplacila = DateTime.Now;
        }
    }
}
