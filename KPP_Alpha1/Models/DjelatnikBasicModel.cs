using KPP_Alpha1.HelperClasses;
using System;

namespace KPP_Alpha1.Models
{
    internal class DjelatnikBasicModel
    {
        public int Id { get; set; }
        public int DjelatnikId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Spol { get; set; }
        public string Adresa { get; set; }
        public int MjestoId { get; set; }
        public string Postion { get; set; }
        public string ChartNumber { get; set; }
        public string WorkRegion { get; set; }
        public string WorkRelationship { get; set; }
        public int KorisnikId { get; set; } = LoginHelper.StaticId;
        public DateTime Ažurirano { get; set; } = DateTime.Now.Date;
    }
}
