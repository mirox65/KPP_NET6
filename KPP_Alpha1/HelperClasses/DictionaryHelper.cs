using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace KPP_Alpha1.HelperClasses
{
    internal class DictionaryHelper
    {

        /// <summary>
        /// Metode za izradu riječnika aplikacije
        /// </summary>
        private readonly DbClass db = new();
        // Rijećnik sa dvije varijable, jedna kolona i tablica
        internal Dictionary<int, string> DictIntString(string kolona, string tablica)
        {
            Dictionary<int, string> dict = new();

            var dbs = $"SELECT id, {kolona} FROM {tablica} WHERE status='Aktivno';";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(dbs, conn);
            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var key = Convert.ToInt32(reader["id"].ToString());
                    var value = reader[$"{kolona}"].ToString();
                    dict.Add(key, value);
                }
            }
            catch (Exception) { throw; }
            finally
            {
                conn.Close();
            }
            return dict;
        }
        // Riječnik sa tri varijable, tablica i dvije kolone
        internal Dictionary<int, string> DictIntString(string kolona1, string kolona2, string tablica)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            var dbs = $"SELECT id, {kolona1}, {kolona2} FROM {tablica} WHERE status='Aktivno';";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(dbs, conn);
            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var key = Convert.ToInt32(reader["id"].ToString());
                    var kol1 = reader[$"{kolona1}"].ToString();
                    var kol2 = reader[$"{kolona2}"].ToString();
                    var value = $"{kol1} {kol2}";
                    dict.Add(key, value);
                }
            }
            catch (Exception) { throw; }
            finally
            {
                conn.Close();
            }
            return dict;
        }

        internal Dictionary<string, int> DicStringInt(Dictionary<string, int> dict, string keyString1, string tablica)
        {
            var dic = dict;
            var dbs = $"SELECT id, {keyString1} FROM {tablica} WHERE status='Aktivno'";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(dbs, conn);
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var keyS1 = reader[$"{keyString1}"].ToString();
                    var value = Convert.ToInt32(reader[$"id"].ToString());
                    var key = $"{keyS1}";
                    dic.Add(key, value);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dict;
        }

        internal Dictionary<string, int> DicStringInt(Dictionary<string, int> dict, string keyString1, string keyString2, string tablica)
        {
            var dic = dict;
            var dbs = $"SELECT id, {keyString1}, {keyString2} FROM {tablica} WHERE status='Aktivno';";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(dbs, conn);
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var keyS1 = reader[$"{keyString1}"].ToString();
                    var keyS2 = reader[$"{keyString2}"].ToString();
                    var value = Convert.ToInt32(reader[$"id"].ToString());
                    var key = $"{keyS1} {keyS2}";
                    dic.Add(key, value);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dict;
        }

        internal Dictionary<string, string> DictStringString(Dictionary<string, string> opremaBazaDic, string keyString1, string tablica)
        {
            var dict = opremaBazaDic;
            var dbs = $"SELECT {keyString1} FROM {tablica} WHERE status='Aktivno';";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(dbs, conn);
            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var keyS1 = reader[$"{keyString1}"].ToString();
                    var key = $"{keyS1}";
                    var value = $"{tablica}";
                    dict.Add(key, value);
                }
            }
            catch (Exception) { throw; }
            finally
            {
                conn.Close();
            }
            return dict;
        }

        internal Dictionary<string, string> DictStringString(Dictionary<string, string> opremaBazaDic, string keyString1, string keyString2, string tablica)
        {
            var dict = opremaBazaDic;
            var dbs = $"SELECT {keyString1}, {keyString2} FROM {tablica} WHERE status='Aktivno';";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(dbs, conn);
            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var keyS1 = reader[$"{keyString1}"].ToString();
                    var keyS2 = reader[$"{keyString2}"].ToString();
                    var key = $"{keyS1} {keyS2}";
                    var value = $"{tablica}";
                    dict.Add(key, value);
                }
            }
            catch (Exception) { throw; }
            finally
            {
                conn.Close();
            }
            return dict;
        }
    }
}
