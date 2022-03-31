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

                vozilo.Id = Convert.ToInt32(dt.Rows[0]["ID"]);
                vozilo.Proizvodac = dt.Rows[0]["proizvođač"].ToString();
                vozilo.Model = dt.Rows[0]["model"].ToString();
                vozilo.Opis = dt.Rows[0]["opis"].ToString();
                vozilo.BrSasije = dt.Rows[0]["brŠasije"].ToString();
                vozilo.BrUgovora = dt.Rows[0]["brUgovora"].ToString();
                vozilo.RegOznaka = dt.Rows[0]["regOznaka"].ToString();
            
            return vozilo;
        }

        internal DjelatnikModel UcitavanjeDjelatnika(int id)
        {
            var select = $"SELECT * FROM djelatnici WHERE id = {id}";
            var dt = db.Select(select);

            DjelatnikModel djelatnik = new();

            djelatnik.Id = Convert.ToInt32(dt.Rows[0]["ID"]);
            djelatnik.PerNum = Convert.ToInt32(dt.Rows[0]["PN"]);
            djelatnik.Ime = dt.Rows[0]["Ime"].ToString();
            djelatnik.Prezime = dt.Rows[0]["Prezime"].ToString();
            djelatnik.Oib = dt.Rows[0]["Oib"].ToString();
            
            return djelatnik;
        }
        internal KeyCardModel UcitavanjeKeyCard(int id)
        {
            var select = $"SELECT * FROM keyCards WHERE id = {id}";
            var dt = db.Select(select);

            KeyCardModel kartica = new();

                kartica.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                kartica.Naziv = dt.Rows[0]["naziv"].ToString();
            
            return kartica;
        }
        internal DataCardModel UcitavanjeDataCard(int id)
        {
            var select = $"SELECT * FROM dataCards WHERE id = {id}";
            var dt = db.Select(select);

            DataCardModel kartica = new();

                kartica.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                kartica.Imei = dt.Rows[0]["imei"].ToString();
                kartica.SerBr = dt.Rows[0]["SerBr"].ToString();
            
            return kartica;
        }
        internal EncModel UcitavanjeEnc(int id)
        {
            var select = $"SELECT * FROM enc WHERE id = {id}";
            var dt = db.Select(select);

            EncModel enc = new();

                enc.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                enc.Naziv = dt.Rows[0]["naziv"].ToString();
            
            return enc;
        }
        internal IctOpremaModel UcitavanjeIctOprema(int id)
        {
            var select = $"SELECT * FROM ictOprema WHERE id = {id}";
            var dt = db.Select(select);

            IctOpremaModel oprema = new();

                oprema.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                oprema.Naziv = dt.Rows[0]["naziv"].ToString();
                oprema.InventarniBroj = dt.Rows[0]["invBr"].ToString();
            
            return oprema;
        }
    }
}
