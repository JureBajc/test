using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Zreb : IZreb
    {
        private DateTime casovniZigZreba;
        private bool izveden;
        private List<Kombinacija> vplacaneKombinacije = new List<Kombinacija>();
        private double dobitniSklad;
        private List<DobitnaKombinacija> dobitneKombinacije = new List<DobitnaKombinacija>();
        private double koncniSaldo;
        private int[] izrebanaStevila = new int[7]; //velikost je array-a je 7 stevil

        public bool Izveden
        {
            get { return izveden; }
        }

        public void vplaciloKombinacije(Kombinacija vplacanaKombinacija)
        {
            vplacaneKombinacije.Add(vplacanaKombinacija);
        }
        public void nakljucnaVplacila(int steviloNakljucnihKombinacij, SkupekStevil stevila)
        {
            Random rand = new Random();
            for (int i = 0; i < steviloNakljucnihKombinacij; i++)
            {
                int[] kombinacije = new int[7];
                for (int j = 0; j < 7; j++)
                {
                    int number;
                    do
                    {
                        number = rand.Next(stevila.Min, stevila.Max+1);
                    } while (kombinacije.Contains(number));
                    kombinacije[j] = number;
                }
                Kombinacija k = new Kombinacija(kombinacije);
                vplacaneKombinacije.Add(k);
            }
        }
        public void priprava()
        {
            // Ta funkcija bi morala biti v Loteriji, ne pa v interfacu Zreba
            this.casovniZigZreba = DateTime.Now;
        }
        public void izvedba(double cenaKombinacije, double garantiranDobitniSklad, SkupekStevil stevila)
        {
            // Ta tudi

            //i + ii
            dobitniSklad = (cenaKombinacije * 0.9 * (double)vplacaneKombinacije.Count) + koncniSaldo;
            if(dobitniSklad < garantiranDobitniSklad)
            {
                dobitniSklad = garantiranDobitniSklad;
            }
            double noviKoncniSaldo = dobitniSklad;

            //iii Žrebanje števil
            Random rand = new Random();
            for (int j = 0; j < 7; j++)
            {
                int number;
                do
                {
                    number = rand.Next(stevila.Min, stevila.Max + 1);
                } while (izrebanaStevila.Contains(number));
                izrebanaStevila[j] = number;
            }

            //iv
            List<DobitnaKombinacija> zadeliSest = new List<DobitnaKombinacija>();
            List<DobitnaKombinacija> zadeliSedem = new List<DobitnaKombinacija>();
            foreach (var kombinacija in vplacaneKombinacije)
            {
                int zadetkov = 0;
                List<int> izrebanaStevilaDobitka = new List<int>();
                
                for (int i = 0; i < 7; i++)
                {
                    if (kombinacija.IzbranaStevila[i] == izrebanaStevila[i])
                    {
                        zadetkov++;
                        izrebanaStevilaDobitka.Add(kombinacija.IzbranaStevila[i]);
                    }
                }
                if(zadetkov > 2)
                {
                    // Lahk bi blo bolš sam ni cajta
                    // Magari if stavki
                    DobitnaKombinacija d;
                    if (zadetkov == 3)
                    {
                        d = new DobitnaKombinacija(
                            kombinacija.IzbranaStevila,
                            5.0,
                            3,
                            izrebanaStevilaDobitka
                            );
                        dobitneKombinacije.Add(d);
                        noviKoncniSaldo -= 5.0;
                    }
                    else if (zadetkov == 4)
                    {
                        d = new DobitnaKombinacija(
                            kombinacija.IzbranaStevila,
                            50.0,
                            4,
                            izrebanaStevilaDobitka
                            );
                        dobitneKombinacije.Add(d);
                        noviKoncniSaldo -= 50.0;
                    }
                    else if (zadetkov == 5)
                    {
                        d = new DobitnaKombinacija(
                            kombinacija.IzbranaStevila,
                            500.0,
                            5,
                            izrebanaStevilaDobitka
                            );
                        dobitneKombinacije.Add(d);
                        noviKoncniSaldo -= 500.0;
                    }
                    else if (zadetkov == 6) zadeliSest.Add(new DobitnaKombinacija(
                        kombinacija.IzbranaStevila,
                        6,
                        izrebanaStevilaDobitka
                        ));
                    else if (zadetkov == 7) zadeliSedem.Add(new DobitnaKombinacija(
                        kombinacija.IzbranaStevila,
                        7,
                        izrebanaStevilaDobitka
                        ));
                }                
            }
            foreach (var kombinacija in zadeliSest)
            {
                double vrednost = dobitniSklad * 0.1 / (double)zadeliSest.Count;
                kombinacija.DodajVrednostDobitka(vrednost);
                noviKoncniSaldo -= vrednost;
            }
            foreach(var kombinacija in zadeliSest)
            {
                double vrednost = dobitniSklad * 0.9 / (double)zadeliSedem.Count;
                kombinacija.DodajVrednostDobitka(vrednost);
                noviKoncniSaldo -= vrednost;
            }

            //v
            this.koncniSaldo = noviKoncniSaldo;
            this.izveden = true;
        }
    }
}
