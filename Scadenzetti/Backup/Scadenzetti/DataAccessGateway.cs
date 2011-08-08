using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Scadenzetti
{
    class DataAccessGateway
    {

        public scadenzettiDbDataSet.MovimentoDataTable cercaMovimenti(int idutente, int iddestinatario, DateTime from, DateTime to)
        {
            scadenzettiDbDataSetTableAdapters.MovimentoTableAdapter mta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.MovimentoTableAdapter();

            if (idutente == -1 && iddestinatario == -1)
            {
                return mta.GetDataByData(from, to);
            }
            
            if (idutente == -1)
            {
                return mta.GetDataByDestData(iddestinatario, from, to);
            }

            if (iddestinatario == -1)
            {
                return mta.GetDataByUtenteData(idutente, from, to);
            }

            return mta.GetDataByUtenteDestData(idutente, iddestinatario, from, to);
        }

        public List<Movimento> cercaMovimentiScaduti()
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.scadenzettiDbConnectionString);
            string queryString = "SELECT * FROM QueryMovimentiUntil";
            OleDbCommand cmd = new OleDbCommand(queryString, conn);
            cmd.Parameters.Add("DataScadenza", OleDbType.Date).Value = DateTime.Today;
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            List<Movimento> list = new List<Movimento>();
            while (reader.Read())
            {
                Movimento mov = new Movimento();
                mov.DataScadenza = DateTime.Parse(reader[0].ToString());
                mov.Tipo = reader[1].ToString();
                mov.ImportoIvato = decimal.Parse(reader[2].ToString());
                Utente u = new Utente();
                u.Nome = reader[3].ToString();
                mov.Utente = u;
                Destinatario d = new Destinatario();
                d.Nome = reader[4].ToString();
                mov.Destinatario = d;
                mov.Id = int.Parse(reader[5].ToString());
                list.Add(mov);
            }
            reader.Close();
            conn.Close();
            return list;
        }

        public List<Movimento> cercaMovimentiProssimoMese()
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.scadenzettiDbConnectionString);
            string queryString = "SELECT * FROM QueryMovimentiBetween";
            OleDbCommand cmd = new OleDbCommand(queryString, conn);
            cmd.Parameters.Add("DataFrom", OleDbType.Date).Value = DateTime.Today;
            cmd.Parameters.Add("DataTo", OleDbType.Date).Value = DateTime.Today.AddMonths(1);
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            List<Movimento> list = new List<Movimento>();
            while (reader.Read())
            {
                Movimento mov = new Movimento();
                mov.DataScadenza = DateTime.Parse(reader[0].ToString());
                mov.Tipo = reader[1].ToString();
                mov.ImportoIvato = decimal.Parse(reader[2].ToString());
                Utente u = new Utente();
                u.Nome = reader[3].ToString();
                mov.Utente = u;
                Destinatario d = new Destinatario();
                d.Nome = reader[4].ToString();
                mov.Destinatario = d;
                mov.Id = int.Parse(reader[5].ToString());
                list.Add(mov);
            }
            reader.Close();
            conn.Close();
            return list;
        }

        public List<YearMatrixReportItem> cercaMovimentiAnnata(int year)
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.scadenzettiDbConnectionString);
            string queryString = "SELECT * FROM QueryMovimentiForMatrixYear";
            OleDbCommand cmd = new OleDbCommand(queryString, conn);
            cmd.Parameters.Add("DataFrom", OleDbType.Date).Value = new DateTime(year, 1, 1);
            cmd.Parameters.Add("DataTo", OleDbType.Date).Value = (new DateTime(year, 12, 31)).AddDays(1).AddSeconds(-1);
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            List<YearMatrixReportItem> list = new List<YearMatrixReportItem>();
            while (reader.Read())
            {
                YearMatrixReportItem mov = new YearMatrixReportItem();
                mov.DataScadenza = DateTime.Parse(reader[0].ToString());
                mov.ImportoIvato = decimal.Parse(reader[1].ToString());
                mov.Utente = reader[2].ToString();
                list.Add(mov);
            }
            reader.Close();
            conn.Close();
            return list;
        }

        public List<MonthlyExpenseReportItem> cercaMovimentiCategoria(int idCat)
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.scadenzettiDbConnectionString);
            string queryString = "SELECT * FROM QueryReportCategoria";
            OleDbCommand cmd = new OleDbCommand(queryString, conn);
            cmd.Parameters.Add("idCat", OleDbType.Integer).Value = idCat;
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            List<MonthlyExpenseReportItem> list = new List<MonthlyExpenseReportItem>();
            while (reader.Read())
            {
                MonthlyExpenseReportItem mov = new MonthlyExpenseReportItem();
                mov.Scadenza = DateTime.Parse(reader[0].ToString());
                mov.Importo = decimal.Parse(reader[1].ToString());
                mov.Debitore = reader[2].ToString();
                mov.Creditore = reader[3].ToString();
                mov.Causale = reader[4].ToString();
                mov.Tipo = reader[5].ToString();
                mov.Ultimato = bool.Parse(reader[6].ToString());

                list.Add(mov);
            }
            reader.Close();
            conn.Close();
            return list;
        }

        public int salvaUtente(string tipo, string CF, string piva, string nome, string sede, string descr)
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.scadenzettiDbConnectionString);
            string queryString = "INSERT INTO Utente (Tipo, CF, PIVA, Nome, Sede, Descrizione) VALUES (?, ?, ?, ?, ?, ?)";
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(queryString, conn);
            cmd.Parameters.Add("Tipo", OleDbType.Char, 255).Value = tipo;
            cmd.Parameters.Add("CF", OleDbType.Char, 255).Value = CF;
            cmd.Parameters.Add("PIVA", OleDbType.Char, 255).Value = piva;
            cmd.Parameters.Add("Nome", OleDbType.Char, 255).Value = nome;
            cmd.Parameters.Add("Sede", OleDbType.Char, 255).Value = sede;
            cmd.Parameters.Add("Descrizione", OleDbType.Char, 255).Value = descr;
            
            cmd.ExecuteNonQuery();

            cmd = new OleDbCommand("SELECT @@IDENTITY", conn);
            int newid = (int)cmd.ExecuteScalar();
            conn.Close();

            return newid;
        }

        public int salvaDestinatario(string piva, string nome, string sede, string descr)
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.scadenzettiDbConnectionString);
            string queryString = "INSERT INTO DestinatarioMov (PIVA, Nome, Descrizione, Sede) VALUES (?, ?, ?, ?)";
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(queryString, conn);
            cmd.Parameters.Add("PIVA", OleDbType.Char, 255).Value = piva;
            cmd.Parameters.Add("Nome", OleDbType.Char, 255).Value = nome;
            cmd.Parameters.Add("Descrizione", OleDbType.Char, 255).Value = descr;
            cmd.Parameters.Add("Sede", OleDbType.Char, 255).Value = sede;

            cmd.ExecuteNonQuery();

            cmd = new OleDbCommand("SELECT @@IDENTITY", conn);
            int newid = (int)cmd.ExecuteScalar();
            conn.Close();

            return newid;
        }

        public int salvaCategoria(string nome, string descr)
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.scadenzettiDbConnectionString);
            string queryString = "INSERT INTO Categoria (Nome, Descrizione) VALUES (?, ?)";
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(queryString, conn);
            cmd.Parameters.Add("Nome", OleDbType.Char, 255).Value = nome;
            cmd.Parameters.Add("Descrizione", OleDbType.Char, 255).Value = descr;

            cmd.ExecuteNonQuery();

            cmd = new OleDbCommand("SELECT @@IDENTITY", conn);
            int newid = (int)cmd.ExecuteScalar();
            conn.Close();

            return newid;
        }

        public int salvaMovimento(string tipo, DateTime scad, bool scadappr, decimal impIvato, bool impAppros,
            decimal impNetto, string causale, string note, int idUtente, int idDest, List<int> categorie)
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.scadenzettiDbConnectionString);
            
            string queryStringMov = "INSERT INTO Movimento (Tipo, DataScadenza, DataApprossimata, ImportoIvato, ImportoIvatoApprossimato, ImportoNetto, Ultimato, Causale, [Note], Utente, DestinatarioMov) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(queryStringMov, conn);
            cmd.Parameters.Add("Tipo", OleDbType.Char, 255).Value = tipo;
            cmd.Parameters.Add("DataScadenza", OleDbType.Date).Value = scad;
            cmd.Parameters.Add("DataApprossimata", OleDbType.Boolean).Value = scadappr;
            cmd.Parameters.Add("ImportoIvato", OleDbType.Double).Value = impIvato;
            cmd.Parameters.Add("ImportoIvatoApprossimato", OleDbType.Boolean).Value = impAppros;
            cmd.Parameters.Add("ImportoNetto", OleDbType.Double).Value = impNetto;
            cmd.Parameters.Add("Ultimato", OleDbType.Boolean).Value = false;
            cmd.Parameters.Add("Causale", OleDbType.Char, 255).Value = causale;
            cmd.Parameters.Add("Note", OleDbType.Char, 255).Value = note;
            cmd.Parameters.Add("Utente", OleDbType.Integer).Value = idUtente;
            cmd.Parameters.Add("DestinatarioMov", OleDbType.Integer).Value = idDest;

            cmd.ExecuteNonQuery();

            cmd = new OleDbCommand("SELECT @@IDENTITY", conn);
            int newIdMov = (int)cmd.ExecuteScalar();

            if (categorie != null)
            {
                string queryStringCat = "INSERT INTO CategoriaMovimento (Movimento, Categoria) VALUES (?, ?)";
                foreach (int i in categorie)
                {
                    OleDbCommand cmdCat = new OleDbCommand(queryStringCat, conn);
                    cmdCat.Parameters.Add("Movimento", OleDbType.Integer).Value = newIdMov;
                    cmdCat.Parameters.Add("Categoria", OleDbType.Integer).Value = i;

                    cmdCat.ExecuteNonQuery();
                }
            }
            conn.Close();

            return newIdMov;
        }

        public void aggiornaMovimento(int idMov, bool stato, DateTime scad, bool dataAppr, DateTime? dataUlt,
            decimal impIvato, bool impAppr, decimal impNetto, string causale, string note, List<int> categorie)
        {
            scadenzettiDbDataSetTableAdapters.MovimentoTableAdapter mta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.MovimentoTableAdapter();
            if(!stato){
                dataUlt = null;
            }
            mta.UpdateById(scad, 
                dataAppr, 
                impIvato, 
                impAppr, 
                impNetto, 
                stato, 
                causale, 
                note, 
                dataUlt, 
                idMov);

            scadenzettiDbDataSetTableAdapters.CategoriaMovimentoTableAdapter cmta = new Scadenzetti.scadenzettiDbDataSetTableAdapters.CategoriaMovimentoTableAdapter();
            //elimino tutte le categorie precedenti
            cmta.DeleteByMovimento(idMov);
            //assegno le nuove categorie
            foreach (int cat in categorie)
                cmta.Insert(idMov, cat);
        }

        public List<MonthlyExpenseReportItem> getDataForMonthlyExpense(int month, int year, List<int> idUsers)
        {
            List<MonthlyExpenseReportItem> itemList = new List<MonthlyExpenseReportItem>();

            DateTime startDate = new DateTime(year, month, 1);
            DateTime endDate = startDate.AddMonths(1);
            

            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.scadenzettiDbConnectionString);

            string prefixQueryStringMov = "SELECT Utente.Nome, DestinatarioMov.Nome, Movimento.DataScadenza, Movimento.ImportoIvato, Movimento.Causale FROM Utente, DestinatarioMov, Movimento WHERE (Utente.ID =Movimento.Utente) AND (DestinatarioMov.ID=Movimento.DestinatarioMov)";
            
            
            MonthlyExpenseReportItem itemReport;
            conn.Open();
            foreach(int user in idUsers){
                string queryString = prefixQueryStringMov + " AND (Utente.ID = " + user + ") AND (Movimento.DataScadenza BETWEEN #" +
                    startDate.Month+"/"+startDate.Day+"/"+startDate.Year + "# AND #" +
                    endDate.Month + "/" + endDate.Day + "/" + endDate.Year + "#) AND Movimento.Ultimato=0 ORDER BY Movimento.DataScadenza;";
                OleDbCommand cmd = new OleDbCommand(queryString, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    itemReport = new MonthlyExpenseReportItem();
                    itemReport.Debitore = reader[0].ToString();
                    itemReport.Creditore = reader[1].ToString();
                    itemReport.Scadenza = DateTime.Parse(reader[2].ToString());
                    itemReport.Importo = decimal.Parse(reader[3].ToString());
                    itemReport.Causale = reader[4].ToString();
                    itemList.Add(itemReport);
                }
                reader.Close();
            }
            conn.Close();


            return itemList;
            

        }

        public List<MonthlyExpenseReportItem> cercaTuttiMov(DateTime from, DateTime to)
        {
            List<MonthlyExpenseReportItem> itemList = new List<MonthlyExpenseReportItem>();

            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.scadenzettiDbConnectionString);

            string queryString = "SELECT * FROM QueryReportAll";

            MonthlyExpenseReportItem itemReport;
            conn.Open();
            
            OleDbCommand cmd = new OleDbCommand(queryString, conn);
            cmd.Parameters.Add("DataFrom", OleDbType.Date).Value = from;
            cmd.Parameters.Add("DataTo", OleDbType.Date).Value = to;
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                itemReport = new MonthlyExpenseReportItem();
                itemReport.Scadenza = DateTime.Parse(reader[0].ToString());
                itemReport.Importo = decimal.Parse(reader[1].ToString());
                itemReport.Debitore = reader[2].ToString();
                itemReport.Creditore = reader[3].ToString();
                itemReport.Causale = reader[4].ToString();
                itemReport.Tipo = reader[5].ToString();
                itemReport.Ultimato = bool.Parse(reader[6].ToString());
                itemList.Add(itemReport);
            }
            reader.Close();
            conn.Close();
            return itemList;

        }
        
        
    }
}


