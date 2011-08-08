using System;
using System.Collections.Generic;
using System.Text;

namespace Scadenzetti
{
    public class MonthlyExpenseReportItem
    {
        private DateTime _scad;
        private decimal _importo;
        private string _debitore;
        private string _creditore;
        private string _causale;
        private string _tipo;
        private bool _ultimato;

        public string Tipo { 
            get{
             return this._tipo;   
            }
            set{
                this._tipo = value;
            }
        }

        public bool Ultimato { 
            get{
                return this._ultimato;
            } 
            set{
                this._ultimato = value;
            }
        }

        public DateTime Scadenza { 
            get{
                return this._scad;
            }
            set{
                this._scad = value;
            }
        }

        public decimal Importo { 
            get{
                return this._importo;
            }
            set{
                this._importo = value;
            }
        }

        public string Debitore { 
            get{
                return this._debitore;
            }
            set {
                this._debitore = value;
            }
        }

        public string Creditore
        {
            get
            {
                return this._creditore;
            }
            set
            {
                this._creditore = value;
            }
        }
        public string Causale
        {
            get
            {
                return this._causale;
            }
            set
            {
                this._causale = value;
            }
        }
    }
}
