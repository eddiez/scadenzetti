using System;
using System.Collections.Generic;
using System.Text;

namespace Scadenzetti
{
    public class DateSearchCriteria
    {
        private DateTime _from;
        private DateTime _to;

        public DateTime From { 
            get{
                return this._from;
            }

            set
            {
                this._from = value;
            }
        }

        public DateTime To
        {
            get
            {
                return this._to;
            }

            set
            {
                this._to = value;
            }
        }
    }
}
