﻿using MostarConstruct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarConstruct.Web.Areas.ClanUprave.ViewModels
{
    public class IzvjestajIndexViewModel
    {
        public List<Izvjestaj> izvjestaji { get; set; }
        public string srchTxt { get; set; }


    }
}
