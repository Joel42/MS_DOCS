using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UnPocoDeMi.Pages
{
    public class GaleriaModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Imagenes de los momentos y logros de Joel en la programacion.";
        }
    }
}
