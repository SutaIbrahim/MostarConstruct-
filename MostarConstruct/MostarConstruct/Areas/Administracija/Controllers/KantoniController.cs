﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MostarConstruct.Web.Areas.Administracija.Controllers
{
    public class KantoniController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}