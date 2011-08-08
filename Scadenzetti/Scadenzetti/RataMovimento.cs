using System;
using System.Collections.Generic;
using System.Text;

namespace Scadenzetti
{
    public class RataMovimento
    {
        private int progrRata;
        private DateTime scadRata;
        private decimal importoRata;

        public int Progr {
            get{
                return this.progrRata;
            }
            set {
                this.progrRata = value;
            }
        }

        public DateTime Scadenza
        {
            get
            {
                return this.scadRata;
            }
            set
            {
                this.scadRata = value;
            }
        }

        public decimal Importo
        {
            get
            {
                return this.importoRata;
            }
            set
            {
                this.importoRata = value;
            }
        }
    }
}
