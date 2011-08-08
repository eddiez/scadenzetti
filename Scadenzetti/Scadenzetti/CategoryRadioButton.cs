using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Scadenzetti
{
    class CategoryRadioButton : RadioButton
    {
        private int _idCategory;

        public int IdCategoria
        {
            get { return _idCategory; }
            set { this._idCategory = value; }

        }
    }
}
