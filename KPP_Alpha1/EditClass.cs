using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KPP_Alpha1
{
    class EditClass
    {
        dbClass dbc = new dbClass();
        //Get i seteri
        //Get, seteri za mjesto
        public int idMjesto { get; set; }
        public string Ptt { get; set; }
        public string Mjesto { get; set; }
        public int idZupaija { get; set; }
        public int secKey { get; set; }

        //Get, seteri za odjel
        public string NazivOdjela { get; set; }
        public int OdjelId { get; set; }

        //Get, seteri za korisnika
        public int KorisnikId { get; set; }
        public string KorisnikIme { get; set; }
        public string KorisnikPrezime { get; set; }
        public string KorisnikKorisnicko { get; set; }
        public string KorisnikLozinka { get; set; }
        public string KorisnikUloga { get; set; }

        //Get. seteri za Posiljatelja
        public int PosiljateljId { get; set; }
        public string PosiljateljNaziv { get; set; }
        public int PosiljateljMjesto { get; set; }
        public int TrazenaSifra { get; set; }
        




        //          UNOS I IZMJENA MJESTA

        public bool UpdateMjesto(EditClass e)
        {
            bool isSuccess = false;

            OleDbConnection conn = new OleDbConnection(dbc.conn_string);

            try
            {
                string Uredi = "UPDATE mjesta SET ID=@ID, ptt=@ptt, mjesto=@mjesto," +
                    "idZupanije=@idZupanije, secKey=@secKey WHERE ID=@ID";

                OleDbCommand cmd = new OleDbCommand(Uredi, conn);
                cmd.Parameters.AddWithValue("@id", e.idMjesto);
                cmd.Parameters.AddWithValue("@ptt", e.Ptt);
                cmd.Parameters.AddWithValue("@mjesto", e.Mjesto);
                cmd.Parameters.AddWithValue("@idZupanije", e.idZupaija);
                cmd.Parameters.AddWithValue("@secKey", e.secKey);

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
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            conn.Close();
            return isSuccess;
        }

        public bool InsertMjesto(EditClass e)
        {
            bool isSuccess = false;

            OleDbConnection conn = new OleDbConnection(dbc.conn_string);

            try
            {
                string Unos = "INSERT INTO mjesta(ptt, mjesto, idZupanije, secKey) VALUES(@ptt, @mjesto, @idZupanije, @secKey)";

                OleDbCommand cmd = new OleDbCommand(Unos, conn);
                cmd.Parameters.AddWithValue("@ptt", e.Ptt);
                cmd.Parameters.AddWithValue("@mjesto", e.Mjesto);
                cmd.Parameters.AddWithValue("@idZupanije", e.idZupaija);
                cmd.Parameters.AddWithValue("@secKey", e.secKey);

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
            catch(Exception ex) { }
            finally
            {
                conn.Close();
            }

            conn.Close();
            return isSuccess;
        }

        //          UNOS I IZMJENA ODJELA

        public bool InsertOdjel(EditClass e)
        {
            bool isSuccess = false;

            OleDbConnection conn = new OleDbConnection(dbc.conn_string);

            try
            {
                string Unos = "INSERT INTO odjeli(Naziv) VALUES(@Naziv)";

                OleDbCommand cmd = new OleDbCommand(Unos, conn);
                cmd.Parameters.AddWithValue("@Naziv", e.NazivOdjela);
               
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
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }

            conn.Close();
            return isSuccess;
        }

        public bool UpdateOdjel(EditClass e)
        {
            bool isSuccess = false;

            OleDbConnection conn = new OleDbConnection(dbc.conn_string);

            try
            {
                string Uredi = "UPDATE odjeli SET ID=@ID, Naziv=@Naziv WHERE ID=@ID";

                OleDbCommand cmd = new OleDbCommand(Uredi, conn);
                cmd.Parameters.AddWithValue("@ID", e.OdjelId);
                cmd.Parameters.AddWithValue("@Naziv", e.NazivOdjela);

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
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            conn.Close();
            return isSuccess;
        }

        //          UNOS I IZMJENA KORISNIKA


        public bool InsertKorisnik(EditClass e)
        {
            bool isSuccess = false;

            OleDbConnection conn = new OleDbConnection(dbc.conn_string);

            try
            {
                string Unos = "INSERT INTO korisnici(Ime, Prezime, KorisnickoIme, Lozinka, Uloga) VALUES(@Ime, @Prezime, @KorisnickoIme, @Lozinka, @Uloga)";

                OleDbCommand cmd = new OleDbCommand(Unos, conn);
                cmd.Parameters.AddWithValue("@Ime", e.KorisnikIme);
                cmd.Parameters.AddWithValue("@Prezime", e.KorisnikPrezime);
                cmd.Parameters.AddWithValue("@KorisnickoIme", e.KorisnikKorisnicko);
                cmd.Parameters.AddWithValue("@Lozinka", e.KorisnikLozinka);
                cmd.Parameters.AddWithValue("@Uloga", e.KorisnikUloga);

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
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }

            conn.Close();
            return isSuccess;
        }

        public bool UpdateKorsinik(EditClass e)
        {
            bool isSuccess = false;

            OleDbConnection conn = new OleDbConnection(dbc.conn_string);

            try
            {
                string Uredi = "UPDATE korisnici SET id=@id, ime=@ime, prezime=@prezime, KorisnickoIme=@KorisnickoIme, Lozinka=@Lozinka, Uloga=@Uloga WHERE id=@id";

                OleDbCommand cmd = new OleDbCommand(Uredi, conn);
                cmd.Parameters.AddWithValue("@id", e.KorisnikId);
                cmd.Parameters.AddWithValue("@ime", e.KorisnikIme);
                cmd.Parameters.AddWithValue("@prezime", e.KorisnikPrezime);
                cmd.Parameters.AddWithValue("@KorisnickoIme", e.KorisnikKorisnicko);
                cmd.Parameters.AddWithValue("@Lozinka", e.KorisnikLozinka);
                cmd.Parameters.AddWithValue("@Uloga", e.KorisnikUloga);

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
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            conn.Close();
            return isSuccess;
        }

        //          UNOS I IZMJENA POSILJATELJA

        public bool InsertPosiljatelj(EditClass e)
        {
            bool isSuccess = false;

            OleDbConnection conn = new OleDbConnection(dbc.conn_string);

            try
            {
                string Unos = "INSERT INTO posiljatelji(naziv, idMjesto) VALUES(@Naziv, @idMjesto)";

                OleDbCommand cmd = new OleDbCommand(Unos, conn);
                cmd.Parameters.AddWithValue("@naziv", e.PosiljateljNaziv);
                cmd.Parameters.AddWithValue("@idMjesto", e.PosiljateljMjesto);

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
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }

            conn.Close();
            return isSuccess;
        }

        public bool UpdatePosiljatelj(EditClass e)
        {
            bool isSuccess = false;

            OleDbConnection conn = new OleDbConnection(dbc.conn_string);

            try
            {
                string Uredi = "UPDATE posiljatelji SET id=@id, naziv=@naziv, idMjesto=@idMjesto WHERE id=@id";

                OleDbCommand cmd = new OleDbCommand(Uredi, conn);
                cmd.Parameters.AddWithValue("@id", e.PosiljateljId);
                cmd.Parameters.AddWithValue("@naziv", e.PosiljateljNaziv);
                cmd.Parameters.AddWithValue("@idMjesto", e.PosiljateljMjesto);

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
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            conn.Close();
            return isSuccess;
        }
        public int Sifra (string _sifra, string IzTablice, string GdjeTrazim)
        {            
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);            
            try
            {
                string Trazi = "SELECT id FROM " + IzTablice +" WHERE " + GdjeTrazim + " = '" +_sifra+"';";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(Trazi, conn);                
                
                Int32 TrazenaSifra = (Int32)cmd.ExecuteScalar();
                return TrazenaSifra;
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            return TrazenaSifra;
        }
    }
}
