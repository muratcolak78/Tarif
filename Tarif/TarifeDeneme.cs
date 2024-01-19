using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarif
{
    internal class TarifeDeneme
    {
        private string bezeichnug;
        private double basisPreis;
        private int freiMinuten;
        private double minutenPreis;

        public TarifeDeneme(string bezeichnug, double basisPreis, int freiMinuten, double minutenPreis)
        {
            this.bezeichnug = bezeichnug;
            this.basisPreis = basisPreis;
            this.freiMinuten = freiMinuten;
            this.minutenPreis = minutenPreis;
        }

        public string Bezeichnug { get => bezeichnug; set => bezeichnug = value; }
        public double BasisPreis { get => basisPreis; set => basisPreis = value; }
        public int FreiMinuten { get => freiMinuten; set => freiMinuten = value; }
        public double MinutenPreis { get => minutenPreis; set => minutenPreis = value; }
    }
}
