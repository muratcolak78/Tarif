using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarif
{
    internal class Festnetz:TarifBasis
    {
        private bool dijitalMöglich;

        public Festnetz(string bezeichnung, double basispreis,int freiminute, double minutenpreis, bool dijitalmöglich)   
        {
            Bezeichnug = bezeichnung;
            BasisPreis = basispreis;
            FreiMinuten = freiminute;
            MinutenPreis = minutenpreis;
            this.dijitalMöglich = dijitalmöglich;
        }

        public bool DijitalMöglich { get => dijitalMöglich; set => dijitalMöglich = value; }

        
    }

}
