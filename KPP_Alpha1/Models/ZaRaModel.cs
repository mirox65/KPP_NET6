using KPP_Alpha1.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.Models
{
    /// <summary>
    /// Model ZaRa služi za zaduživavnje i razduživanje oprema.
    /// Pod opremu se smatra ICT (mob, latpop, tablet...), vozila,
    /// key cards, enc itd
    /// Grupa služi za povlačenje opreme iz njihvih jedinstvenih baza.
    /// Kad se učita ICT u texbox se učita dictionary iz baze itOprema,
    /// vozila iz vozila baze itd.
    /// Polje djetanik služi kao search polje upisivanjem imena djelanika u dgv
    /// se učitava sva oprema po kriteriju odabranog filtera zaduženo/razduežno
    /// Iz ove baze se može kasnije odraditi Revers koji će ispisivati dokument
    /// sa zaduženom opremom. Checkbox razduženje će biti koristišteno if true 
    /// da editira unos u bazi sa ili bez datuma razuženja, ako je isti false
    /// onda se samo može editirati datum zaduženja. 
    /// Unos u bazu (insert) uvijek ide bez datuma razduženja
    /// </summary>
    internal class ZaRaModel
    {
        public int Id { get; set; }
        public int DjelatnikId { get; set; }
        public string NazivZaRaTablice { get; set; }
        public int OpremaId { get; set; }
        public DateTime DatumZaduženja { get; set; }
        public DateTime DatumRazduženja { get; set; }
        public int KorisnikId { get; set; } = LoginHelper.StaticId;
        public DateTime EditedOn { get; set; } = DateTime.Now.Date;
    }
}
