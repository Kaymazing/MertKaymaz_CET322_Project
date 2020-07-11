using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MertKaymaz_CET322_BOOKIE.Models
{
    public class User
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Must be in between 3 and 100 characters.")]
        [Required(ErrorMessage = "It's required.")]
        public string Name { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Must be in between 3 and 100 characters.")]
        [Required(ErrorMessage = "It's required.")]
        public string Surname { get; set; }
     
        [Required(ErrorMessage = "It's required.")]
        public DateTime BirthDate { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Must be in between 3 and 100 characters.")]
        [Required(ErrorMessage = "It's required.")]
        public string Mail { get; set; }
        [StringLength(16, MinimumLength = 3, ErrorMessage = "Must be in between 3 and 16 characters.")]
        [Required(ErrorMessage = "It's required.")]
        public string Password { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
