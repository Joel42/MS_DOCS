﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UnPocoDeMi.Pages
{
    public class HistoriaModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Klk CONTO EL MUNDO.";
        }
    }
}
