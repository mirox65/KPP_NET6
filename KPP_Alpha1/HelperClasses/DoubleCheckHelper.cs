using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.HelperClasses
{
    internal class DoubleCheckHelper
    {
        private readonly DbClass db = new();

        internal bool DoubleInsertChecker(string atribut, string tablica, string provjeri)
        {
            var query = $"SELECT COUNT(id) FROM {tablica} WHERE {atribut}='{provjeri}';";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(query, conn);
            
            return db.ExecuteScalar(cmd, conn);
        }
    }
}
