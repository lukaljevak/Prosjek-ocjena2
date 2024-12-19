using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prosjek_ocjena1
{
    internal class Prosjek
    {
        string nazivPredmeta;
        int ocjena;

        public Prosjek(string nazivPredmeta, int ocjena)
        {
            this.NazivPredmeta = nazivPredmeta;
            this.Ocjena = ocjena;
        }
        public Prosjek() 
        {
             
        }
        public string NazivPredmeta { get => nazivPredmeta; set => nazivPredmeta = value; }
        public int Ocjena { get => ocjena; set => ocjena = value; }
        

    }
}
