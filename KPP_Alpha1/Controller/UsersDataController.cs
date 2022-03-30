using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.Controller
{
    internal class UsersDataController
    {
        readonly DbClass db = new();

        internal bool Insert(UsersDataModel usersData)
        {
            var Insert = "INSERT INTO usersData(djelatnikId, username, [password], email, phoneNumber, korisnikId, ažurirano) " +
                "VALUES(?, ?, ?, ?, ?, ?, ?)";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(Insert, conn);
            cmd.Parameters.AddWithValue("@djelatnikId", usersData.DjelatnikId);
            cmd.Parameters.AddWithValue("@username", usersData.Username);
            cmd.Parameters.AddWithValue("@password", usersData.Password);
            cmd.Parameters.AddWithValue("@email", usersData.Email);
            cmd.Parameters.AddWithValue("@phoneNumber", usersData.PhoneNumber);
            cmd.Parameters.AddWithValue("@korisnikId", usersData.KorisnikId);
            cmd.Parameters.AddWithValue("@ažurirano", usersData.Ažurirano);

            return db.ExcecuteNonQuery(cmd, conn);
        }

        internal bool Update(UsersDataModel usersData)
        {
            string Update = "UPDATE usersData SET djelatnikId=?, username=?, [password]=?, email=?, " +
                "phoneNumber=?, korisnikId=?, ažurirano=? WHERE ID=?";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(Update, conn);
            cmd.Parameters.AddWithValue("@djelatnikId", usersData.DjelatnikId);
            cmd.Parameters.AddWithValue("@username", usersData.Username);
            cmd.Parameters.AddWithValue("@password", usersData.Password);
            cmd.Parameters.AddWithValue("@email", usersData.Email);
            cmd.Parameters.AddWithValue("@phoneNumber", usersData.PhoneNumber);
            cmd.Parameters.AddWithValue("@korisnikId", usersData.KorisnikId);
            cmd.Parameters.AddWithValue("@ažurirano", usersData.Ažurirano);
            cmd.Parameters.AddWithValue("@ID", usersData.Id);

            return db.ExcecuteNonQuery(cmd, conn);
        }
    }
}
