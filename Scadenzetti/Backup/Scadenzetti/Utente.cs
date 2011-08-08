using System;
using System.Collections.Generic;
using System.Text;

namespace Scadenzetti
{
    public class Utente
    {
        private int _id;
        private string _tipo;
        private string _cf;
        private string _piva;
        private string _nome;
        private string _sede;
        private string _descrizione;

        public int Id { 
            get{
                return _id;
            }
            set {
                this._id = value;
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

        public string Cf
        {
            get
            {
                return _cf;
            }
            set
            {
                this._cf = value;
            }
        }

        public string Piva
        {
            get
            {
                return _piva;
            }
            set
            {
                this._piva = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                this._nome = value;
            }
        }

        public string Sede
        {
            get
            {
                return _sede;
            }
            set
            {
                this._sede = value;
            }
        }

        public string Descr
        {
            get
            {
                return _descrizione;
            }
            set
            {
                this._descrizione = value;
            }
        }
        public override string ToString()
        {
            return this._nome;
        }
    }
}
