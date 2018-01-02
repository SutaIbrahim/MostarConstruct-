﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarConstruct.Web.Areas.Administracija.ViewModels
{
    public class KorisniciIndexViewModel
    {
        public List<Row> Rows { get; set; }

        public class Row
        {
            public int KorisnikID { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public string KorisnickoIme { get; set; }
            public string Email { get; set; }
            public DateTime DatumRegistracije { get; set; }
            public string Aktivan { get; set; }
        }
    }
}
