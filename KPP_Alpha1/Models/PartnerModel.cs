﻿using System;

namespace KPP_Alpha1.Models
{
    public class PartnerModel
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int KorisnikId { get; set; } = EditClass.IdKorisnika;
        public DateTime Azurirano { get; set; } = DateTime.Now.Date;
    }
}