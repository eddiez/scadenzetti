using System;
using System.Collections.Generic;
using System.Text;

namespace Scadenzetti
{
    public class Categoria
    {
        private int _id;
        private string _nome;
        private string _descr;
        private List<Movimento> _movimenti;

        public List<Movimento> Movimenti { 
            get{
                return this._movimenti;
            }
        }

        public void addMovimento(Movimento m)
        {
            this._movimenti.Add(m);
        }

        public int Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }

        public string Nome { 
            get{
                return this._nome;
            }
            set {
                this._nome = value;
            }
        }

        public string Descr
        {
            get
            {
                return this._descr;
            }
            set
            {
                this._descr = value;
            }
        }
    }
}
