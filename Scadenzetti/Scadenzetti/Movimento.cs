using System;
using System.Collections.Generic;
using System.Text;

namespace Scadenzetti
{
    public class Movimento
    {
        private int _id;
        private string _tipo; //entrata o uscita
        private DateTime _dataScad;
        private bool _isDataScadSicura;
        private decimal _importoIvato;
        private bool _isImportoIvatoSicuro;
        private decimal _importoNetto;
        private bool _isMovimentoUltimato;
        private string _causale;
        private string _note;
        private Utente _utente;
        private Destinatario _destinatario;
        private DateTime _dataUltimaggio; //data in cui il pagamento/incasso è stato eseguito/ricevuto

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public Utente Utente
        {
            get
            {
                return this._utente;
            }
            set
            {
                this._utente = value;
            }
        }

        public Destinatario Destinatario
        {
            get
            {
                return this._destinatario;
            }
            set
            {
                this._destinatario = value;
            }
        }

        public bool IsScadenzaSicura { 
            get{
                return this._isDataScadSicura;   
            }
            set{
                this._isDataScadSicura = value;
            }
        }

        public bool IsImportoIvatoSicuro
        {
            get
            {
                return this._isImportoIvatoSicuro;
            }
            set
            {
                this._isImportoIvatoSicuro = value;
            }
        }

        public bool IsMovimentoUltimato
        {
            get
            {
                return this._isMovimentoUltimato;
            }
            set
            {
                this._isMovimentoUltimato = value;
            }
        }


        public string Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                this._tipo = value;
            }
        }

        public string Causale
        {
            get
            {
                return _causale;
            }
            set
            {
                this._causale = value;
            }
        }

        public string Note
        {
            get
            {
                return _note;
            }
            set
            {
                this._note = value;
            }
        }

        public DateTime DataScadenza { 
            get{
                return this._dataScad;
            }
            set
            {
                this._dataScad = value;
            }
        }

        public DateTime DataUltimaggio
        {
            get
            {
                return this._dataUltimaggio;
            }
            set
            {
                this._dataUltimaggio = value;
            }
        }

        public decimal ImportoIvato { 
            get{
                return this._importoIvato;
            }
            set{
             this._importoIvato = value;   
            }
        }

        public decimal ImportoNetto
        {
            get
            {
                return this._importoNetto;
            }
            set
            {
                this._importoNetto = value;
            }
        }
    }
}
