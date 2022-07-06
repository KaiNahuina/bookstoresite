using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Libro_Book_Store.Data;

namespace Libro_Book_Store.Pages.Admin
{
    public class CreateModel : PageModel
    {
        private AppDbContext _db;
        public Libros Book { get; set; }
        public CreateModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
    }
}
