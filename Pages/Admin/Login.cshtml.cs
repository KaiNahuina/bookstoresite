using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Libro_Book_Store.Pages.Admin
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginUser Input { get; set; }

        private readonly 

        public void OnGet()
        {
        }
    }
}
