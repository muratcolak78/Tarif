using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarif
{
    abstract class TarifBasis
    {
        string bezeichnug;
        double basisPreis;
        int freiMinuten;
        double minutenPreis;

        public string Bezeichnug { get => bezeichnug; set => bezeichnug = value; }
        public double BasisPreis { get => basisPreis; set => basisPreis = value; }
        public int FreiMinuten { get => freiMinuten; set => freiMinuten = value; }
        public double MinutenPreis { get => minutenPreis; set => minutenPreis = value; }

        public double berechnung(int minute)
        {
            double preis = 0;

            if (minute <= 0) return BasisPreis;
            else
            {
                minute = minute - FreiMinuten;

                if (minute > 0)
                {
                    return (minute * MinutenPreis) + BasisPreis;

                }
                else return BasisPreis;

            }

        }

    }
}
