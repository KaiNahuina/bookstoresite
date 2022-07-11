using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Libro_Book_Store.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Libro_Book_Store.Pages
{
    public class ShopModel : PageModel
    {
        private readonly AppDbContext _db;
        public ShopModel(AppDbContext db)
        {
            _db = db;
        }

        public IList<Libros> Libros { get; private set; }


        public void OnGet()
        {
            Libros = _db.LibrosList.FromSqlRaw("SELECT * FROM Book_List").ToList();
        }
    }
}
