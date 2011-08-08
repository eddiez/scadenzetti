using System;
using System.Collections.Generic;
using System.Text;

namespace Scadenzetti
{
    public class YearMatrixReportItem
    {
        private DateTime _dataScad;
        private decimal _importoIvato;
        private string _utente;

        public DateTime DataScadenza {
            get
            {
                return this._dataScad;
            }
            set
            {
                this._dataScad = value;
            }
        }

        public decimal ImportoIvato
        {
            get
            {
                return this._importoIvato;
            }
            set
            {
                this._importoIvato = value;
            }
        }

        public string Utente
        {
            get
            {
                return _utente;
            }
            set
            {
                this._utente = value;
            }
        }
    }
}
