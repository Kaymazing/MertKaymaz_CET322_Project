using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MertKaymaz_CET322_BOOKIE.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Must be in between 3 and 100 characters.")]
        [Required(ErrorMessage = "It's required.")]
        public string Name { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
