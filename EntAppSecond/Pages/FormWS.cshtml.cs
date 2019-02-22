using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages
{
    public class FormWSModel : PageModel
    {
        [BindProperty]
        public string Radio1 { get; set; }

        [BindProperty]
        public string Radio2 { get; set; }

        [BindProperty]
        public string Radio3 { get; set; }

        public void OnGet()
        {

        }
    }
}