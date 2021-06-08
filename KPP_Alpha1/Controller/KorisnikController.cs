using KPP_Alpha1.HelperClasses;
using KPP_Alpha1.Models;
using System;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace KPP_Alpha1.Controller
{
    class KorisnikController
    {
        readonly DbClass db = new DbClass();
        readonly EditClass edit = new EditClass();

        internal bool Edit(KorisnikModel korisnik)
        {
            string Uredi = "UPDATE korisnici SET djelatnikId=?, korisnickoIme=?, " +
                "uloga=?, aktivan=?, korisnikId=?, azurirano=? WHERE id=?";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(Uredi, conn);
            cmd.Parameters.AddWithValue("@djelatnikId", korisnik.DjelatnikId);
            cmd.Parameters.AddWithValue("@korisnickoIme", korisnik.KorisnickoIme);
            cmd.Parameters.AddWithValue("@uloga", korisnik.Uloga);
            cmd.Parameters.AddWithValue("@aktivan", korisnik.Aktivan);
            cmd.Parameters.AddWithValue("@korisnikId", korisnik.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", korisnik.Azurirano);
            cmd.Parameters.AddWithValue("@id", korisnik.Id);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }

        internal bool EditWithPassword(KorisnikModel korisnik)
        {
            var sol = CreateSalt();
            string Uredi = "UPDATE korisnici SET djelatnikId=?, korisnickoIme=?, " +
                "lozinka=?, sol=?, uloga=?, aktivan=?, korisnikId=?, azurirano=? WHERE id=?";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Uredi, conn);
            cmd.Parameters.AddWithValue("@djelatnikId", korisnik.DjelatnikId);
            cmd.Parameters.AddWithValue("@korisnickoIme", korisnik.KorisnickoIme);
            cmd.Parameters.AddWithValue("@lozinka", HashLozinkaSHA256(korisnik.Lozinka, sol));
            cmd.Parameters.AddWithValue("@sol", sol);
            cmd.Parameters.AddWithValue("@uloga", korisnik.Uloga);
            cmd.Parameters.AddWithValue("@aktivan", korisnik.Aktivan);
            cmd.Parameters.AddWithValue("@korisnikId", korisnik.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", korisnik.Azurirano);
            cmd.Parameters.AddWithValue("@id", korisnik.Id);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }
        // Metoda se koristi kad korsnik sam 
        internal bool UpdatePasswordByUser(LoginModel loginModel)
        {
            var sol = CreateSalt();
            var Uredi = "UPDATE korisnici SET lozinka=?, sol=?, korisnikId=?, azurirano=? " +
                "WHERE id=?";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(Uredi, conn);
            cmd.Parameters.AddWithValue("@lozinka", HashLozinkaSHA256(loginModel.NovaLozinka, sol));
            cmd.Parameters.AddWithValue("@sol", sol);
            cmd.Parameters.AddWithValue("@korisnikId", LoginHelper.StaticId);
            cmd.Parameters.AddWithValue("@azurirano", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@id", LoginHelper.StaticId);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }        
        
        // Metoda se koristi dok svi korisnici ne pređu na SHA hashiranje lozinki
        internal bool UpdatePasswordBySystemTransitionToSha(KorisnikModel korisnikModel)
        {
            var sol = CreateSalt();
            var Uredi = "UPDATE korisnici SET lozinka=?, sol=?, korisnikId=?, azurirano=? " +
                "WHERE id=?";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(Uredi, conn);
            cmd.Parameters.AddWithValue("@lozinka", HashLozinkaSHA256(korisnikModel.Lozinka, sol));
            cmd.Parameters.AddWithValue("@sol", sol);
            cmd.Parameters.AddWithValue("@korisnikId", korisnikModel.Id);
            cmd.Parameters.AddWithValue("@azurirano", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@id", korisnikModel.Id);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }

        internal bool Insert(KorisnikModel korisnik)
        {
            var sol = CreateSalt();
            string edit = "INSERT INTO korisnici(djelatnikId, korisnickoIme, lozinka, sol, " +
                "uloga, aktivan, korisnikId, azurirano) " +
                "VALUES(?, ?, ?, ?, ?, ?, ?, ?)";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(edit, conn);
            cmd.Parameters.AddWithValue("@djelatnikId", korisnik.DjelatnikId);
            cmd.Parameters.AddWithValue("@korisnickoIme", korisnik.KorisnickoIme);
            cmd.Parameters.AddWithValue("@lozinka", HashLozinkaSHA256(korisnik.Lozinka, sol));
            cmd.Parameters.AddWithValue("@sol", sol);
            cmd.Parameters.AddWithValue("@uloga", korisnik.Uloga);
            cmd.Parameters.AddWithValue("@korisnikId", korisnik.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", korisnik.Azurirano);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }

        private KorisnikModel GetSalt(string korisnickoIme)
        {
            var korisnikModel = new KorisnikModel();
            var select = $"SELECT id, sol FROM korisnici WHERE korisnickoIme=?;";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(select, conn);
            cmd.Parameters.AddWithValue("@korisnickoIme", korisnickoIme);
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (string.IsNullOrWhiteSpace(reader.GetValue(1).ToString()))
                        {
                            korisnikModel.Id = reader.GetInt32(0);
                            korisnikModel.Sol = null;
                        }
                        else
                        {
                            korisnikModel.Id = reader.GetInt32(0);
                            korisnikModel.Sol = reader.GetString(1);
                        }
                    }
                }
            }
            catch(Exception ex) { edit.MessageException(ex); }
            return korisnikModel;
        }

        // Metoda za hash-anje passworda koji se sprema u bazu kodiran zbog sigurnosti
        public string NapraviMD5(string lozinka)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(lozinka));
            byte[] rezultat = md5.Hash;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < rezultat.Length; i++)
            {
                sb.Append(rezultat[i].ToString("x2"));
            }
            return sb.ToString();
        }

        private string HashLozinkaSHA256(string lozinka, string sol)
        {
            var sha = new SHA256Managed();
            var papar = "h";
            var saltNpepa = $"{ sol }-{ lozinka }-{ papar }";
            var lozinkaBytes = Encoding.ASCII.GetBytes(saltNpepa);
            var hash = sha.ComputeHash(lozinkaBytes);
            var hashed = ByteToString(hash);
            return hashed;
        }

        private string CreateSalt()
        {
            var rand = new Random();
            var solLength = rand.Next(4, 16);
            var solBytes = new byte[solLength];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(solBytes);
            return Convert.ToBase64String(solBytes);
        }

        private string ByteToString(byte[] hash)
        {
            var sb = new StringBuilder();
            foreach (byte hb in hash)
            {
                sb.Append(hb.ToString("x2"));
            }
            return sb.ToString();
        }

        internal string HashPasswordForCheck(string korisnickoIme, string lozinka)
        {
            var korisnikModel = GetSalt(korisnickoIme);
            korisnikModel.Lozinka = lozinka;
            string hashedLozinka;
            if(korisnikModel.Sol is null)
            {
                hashedLozinka = NapraviMD5(lozinka);
                MessageBox.Show("Prešli smo na novi sustav zaštite.\n\nMolim da prvom sljedećom prilikom promjeniti lozinku!\n\nHvala!!!", edit.CelijaNazivUpozorenje);
            }
            else
            {
                hashedLozinka = HashLozinkaSHA256(lozinka, korisnikModel.Sol);
            }
            return hashedLozinka;
        }
    }
}
