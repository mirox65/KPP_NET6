using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace KPP_Alpha1
{    
    class KPPeditClass
    {
        dbClass dbc = new dbClass();
        //Geteri i seteri za glavnu formu KPP        
        public int KnjigaID { get; set; }
        public string DatumPrimitka { get; set; }
        public string Pismeno { get; set; }
        public string Brojcano { get; set; }
        public int Idposiljatelj { get; set; }
        public string Datum { get; set; }
        public int Idodjel { get; set; }
        public int Idkorisnik { get; set; }

       public bool Insert(KPPeditClass k)
        {
            bool isSuccess = false;
            string ole = "INSERT INTO knjiga(datumPrimitka, pismeno, brojcano, idPosiljatelj, datum, IDodjel, IDkorisnik)" +
                            "VALUES(@datumPrimitka, @pismeno, @brojcano, @idPosiljatelj, @datum, @IDodjel, @IDkorisnik)";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            try
            {
                OleDbCommand cmd = new OleDbCommand(ole, conn);
                cmd.Parameters.AddWithValue("@datumPrimitka", k.DatumPrimitka);
                cmd.Parameters.AddWithValue("@pismeno", k.Pismeno);
                cmd.Parameters.AddWithValue("@brojcano", k.Brojcano);
                cmd.Parameters.AddWithValue("@idPosiljatelj", k.Idposiljatelj);
                cmd.Parameters.AddWithValue("@datum", k.Datum);
                cmd.Parameters.AddWithValue("@IDodjel", k.Idodjel);
                cmd.Parameters.AddWithValue("@IDkorisnik", k.Idkorisnik);
                cmd.Parameters.AddWithValue("@IDkorisnik", k.Idkorisnik);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex) { }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public bool Update(KPPeditClass k)
        {
            bool isSuccess = false;
            string Uredi = "UPDATE knjiga SET id=@id, datumPrimitka=@datumPrimitka, pismeno = @pismeno, brojcano=@brojcano," +
                            "idPosiljatelj=@idPosiljatelj, datum=@datum, idOdjel=@idOdjel, idkorisnik=@idkorisnik WHERE id=@id";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            try
            {
                OleDbCommand cmd = new OleDbCommand(Uredi, conn);
                cmd.Parameters.AddWithValue("@id", k.KnjigaID);
                cmd.Parameters.AddWithValue("@datumPrimitka", k.DatumPrimitka);
                cmd.Parameters.AddWithValue("@pismeno", k.Pismeno);
                cmd.Parameters.AddWithValue("@brojcano", k.Brojcano);
                cmd.Parameters.AddWithValue("@idPosiljatelj", k.Idposiljatelj);
                cmd.Parameters.AddWithValue("@datum", k.Datum);
                cmd.Parameters.AddWithValue("@idOdjel", k.Idodjel);
                cmd.Parameters.AddWithValue("@idkorisnik", k.Idkorisnik);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
