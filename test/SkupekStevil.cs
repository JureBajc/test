using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class SkupekStevil
    {
        private int naborVrednostiMin;
        private int naborVrednostiMax;
        
        public int Min
        {
            get { return naborVrednostiMin; }
        }
        public int Max
        {
            get { return naborVrednostiMax; }
        }

        public SkupekStevil(int naborVrednostiMin, int naborVrednostiMax)
        {
            this.naborVrednostiMin = naborVrednostiMin;
            this.naborVrednostiMax = naborVrednostiMax;
        }
    }
}
