using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Libro_Book_Store.Data;

namespace Libro_Book_Store.Pages.Admin
{
    public class CreateModel : PageModel
    {
        private AppDbContext _db;

        [BindProperty]
        public Libros Book { get; set; }
        public CreateModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) { return Page(); }
            Book.Active = true;
            foreach(var file in Request.Form.Files)
            {
                MemoryStream ms = new MemoryStream();
                file.CopyTo(ms);
                Book.ImageData = ms.ToArray();
                ms.Close();
                ms.Dispose();

            }


            _db.LibrosList.Add(Book);
            await _db.SaveChangesAsync();
            return RedirectToPage("/Admin/Create");
        }

    }
}
