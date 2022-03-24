using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.HelperClasses
{
    internal class ListHelper
    {
        readonly ModelHelper modelHelper = new();
        public string PovuciVozilo(int id)
        {
            var vozilo = modelHelper.UcitavanjeVozila(id);

            return $"{vozilo.Proizvodac} {vozilo.Model} {vozilo.Opis}, broj šasije: {vozilo.BrSasije}, " +
                $"registarskih oznaka: {vozilo.RegOznaka}";
        }

        internal string PovuciKeyCard(int id)
        {
            var keyCard = modelHelper.UcitavanjeKeyCard(id);

            return $"Kartica: {keyCard.Naziv}";
        }

        internal string PovuciDataCard(int id)
        {
            var dataCard = modelHelper.UcitavanjeDataCard(id);

            return $"Podatkovna kartica: {dataCard.Imei} {dataCard.SerBr}";
        }

        internal string PovuciEnc(int id)
        {
            var enc = modelHelper.UcitavanjeEnc(id);

            return $"ENC: {enc.Naziv}";
        }

        internal string PovuciIctOprema(int id)
        {
            var ictOprema = modelHelper.UcitavanjeIctOprema(id);

            return $"{ictOprema.Naziv} {ictOprema.InventarniBroj}";
        }
    }
}
