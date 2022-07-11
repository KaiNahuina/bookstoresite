using Libro_Book_Store.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Libro_Book_Store.Pages
{
    public class CheckoutModel : PageModel
    {

        private readonly AppDbContext _db;
        public decimal Total = 0;
        public long AmountPayable = 0;


        




        public void OnGet()
        {
        }
    }
}
