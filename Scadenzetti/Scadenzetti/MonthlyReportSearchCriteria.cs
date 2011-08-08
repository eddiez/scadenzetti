using System;
using System.Collections.Generic;
using System.Text;

namespace Scadenzetti
{
    public class MonthlyReportSearchCriteria
    {
        private string _mese;
        private string _anno;
        private List<string> _utenti = new List<string>();

        public void addUser(string user)
        {
            this._utenti.Add(user);
        }

        public string Mese { 
            get{
                return this._mese;
            }
            set{
                this._mese = value;
            }
        }

        public string  Anno { 
            get{
                return this._anno;
            }
            set{
                this._anno = value;
            }
        }
        public List<string> Utenti { 
            get{
                return this._utenti;
            }
        }
    }
}
