using System;
using System.Collections.Generic;
using System.Text;

namespace Scadenzetti
{
    class DestinatarioDropDownItem
    {
        private int _id;
        private string _nome;
        public DestinatarioDropDownItem(int id, string nome)
        {
            this._id = id;
            this._nome = nome;
        }

        public int Id {
            get { return _id; }
        }

        public string Nome {
            get { return _nome; }
        }

        public override string ToString()
        {
            return _nome;
        }
    }
}
