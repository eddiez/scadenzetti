using System;
using System.Collections.Generic;
using System.Text;

namespace Scadenzetti
{
    public class Destinatario
    {
        private int _id;
        private string _piva;
        private string _nome;
        private string _sede;
        private string _descrizione;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
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
    }
}
