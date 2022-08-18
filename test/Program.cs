using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static public void Main(String[] args)
        {
            Loterija loterija1 = new Loterija(
                "Loterija1", 
                10000000, 
                new SkupekStevil(1,40),
                1,
                200000
                );
            Loterija loterija2 = new Loterija(
                "Loterija2",
                10000000,
                new SkupekStevil(1, 40),
                1,
                200000
                );

            int[] stevila = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            Zreb zreb1 = new Zreb();
            zreb1.nakljucnaVplacila(100000, new SkupekStevil(1, 40));
            Zreb zreb2 = new Zreb();
            zreb2.nakljucnaVplacila(100000, new SkupekStevil(1, 40));
            Zreb zreb3 = new Zreb();
            zreb3.nakljucnaVplacila(100000, new SkupekStevil(1, 40));

            List<Zreb> zrebi1 = new List<Zreb>
            {
                zreb1, zreb2, zreb3
            };



        }
    }
}
