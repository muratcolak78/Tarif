using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarif
{
    internal class Mobil:TarifBasis
    {
        private int dijitalMöglich;

        public Mobil(string bezeichnung, double basispreis, int freiminute, double minutenpreis, int dijitalmöglich)
        {
            Bezeichnug = bezeichnung;
            BasisPreis = basispreis;
            FreiMinuten = freiminute;
            MinutenPreis = minutenpreis;
            this.dijitalMöglich = dijitalmöglich;
        }

        public int DijitalMöglich { get => dijitalMöglich; set => dijitalMöglich = value; }
       
    }
}
