using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    class UserCheckBox : CheckBox
    {
        private int _idUser;

        public int IdUtente
        {
            get { return _idUser; }
            set { this._idUser = value; }

        }

        public override string ToString()
        {
            return this.Text;
        }
    }
}
