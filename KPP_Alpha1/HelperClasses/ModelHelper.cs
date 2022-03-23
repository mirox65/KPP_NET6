using KPP_Alpha1.Models;
using System;
using System.Data;

namespace KPP_Alpha1.HelperClasses
{
    internal class ModelHelper
    {
        readonly DbClass db = new();

        internal VozilaModel UcitavanjeVozila(int id)
        {

            var select = $"SELECT * FROM vozila WHERE id = {id}";
            var dt = db.Select(select);

            VozilaModel vozilo = new();

            foreach (DataRow row in dt.Rows)
            {
                vozilo.Id = Convert.ToInt32(row["ID"].ToString());
                vozilo.Proizvodac = row["proizvođač"].ToString();
                vozilo.Model = row["model"].ToString();
                vozilo.Opis = row["opis"].ToString();
                vozilo.BrSasije = row["brŠasije"].ToString();
                vozilo.BrUgovora = row["brUgovora"].ToString();
                vozilo.RegOznaka = row["regOznaka"].ToString();
            }

            return vozilo;
        }

        internal DjelatnikModel UcitavanjeDjelatnika(int id)
        {
            var select = $"SELECT * FROM djelatnici WHERE id = {id}";
            var dt = db.Select(select);

            DjelatnikModel djelatnik = new();

            foreach (DataRow row in dt.Rows)
            {
                djelatnik.Id = Convert.ToInt32(row["id"].ToString());
                djelatnik.Oib = row["oib"].ToString();
            }

            return djelatnik;
        }
        internal KeyCardModel UcitavanjeKeyCard(int id)
        {
            var select = $"SELECT * FROM keyCards WHERE id = {id}";
            var dt = db.Select(select);

            KeyCardModel kartica = new();

            foreach (DataRow row in dt.Rows)
            {
                kartica.Id = Convert.ToInt32(row["id"].ToString());
                kartica.Naziv = row["naziv"].ToString();
            }

            return kartica;
        }
        internal DataCardModel UcitavanjeDataCard(int id)
        {
            var select = $"SELECT * FROM dataCards WHERE id = {id}";
            var dt = db.Select(select);

            DataCardModel kartica = new();

            foreach (DataRow row in dt.Rows)
            {
                kartica.Id = Convert.ToInt32(row["id"].ToString());
                kartica.Imei = row["imei"].ToString();
                kartica.SerBr = row["SerBr"].ToString();
            }

            return kartica;
        }
        internal EncModel UcitavanjeEnc(int id)
        {
            var select = $"SELECT * FROM enc WHERE id = {id}";
            var dt = db.Select(select);

            EncModel enc = new();

            foreach (DataRow row in dt.Rows)
            {
                enc.Id = Convert.ToInt32(row["id"].ToString());
                enc.Naziv = row["naziv"].ToString();
            }

            return enc;
        }
        internal IctOpremaModel UcitavanjeIctOprema(int id)
        {
            var select = $"SELECT * FROM ictOprema WHERE id = {id}";
            var dt = db.Select(select);

            IctOpremaModel oprema = new();

            foreach (DataRow row in dt.Rows)
            {
                oprema.Id = Convert.ToInt32(row["id"].ToString());
                oprema.Naziv = row["naziv"].ToString();
                oprema.InventarniBroj = row["invBr"].ToString();
            }

            return oprema;
        }
    }
}
