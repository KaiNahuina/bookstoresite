using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Libro_Book_Store.Data
{
    public class Libros
    {
        [Key]

        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public byte[] ImageData { get; set; }
        public bool Active { get; internal set; }
    }
}
