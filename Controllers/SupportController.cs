﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Susteni.Controllers
{
    public partial class SupportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}