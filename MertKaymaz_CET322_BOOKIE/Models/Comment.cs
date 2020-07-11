using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MertKaymaz_CET322_BOOKIE.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Must be in between 3 and 100 characters.")]
        [Required(ErrorMessage = "It's required.")]
        public string Title { get; set; }
        [StringLength(500, MinimumLength = 3, ErrorMessage = "Must be in between 3 and 500 characters.")]
        [Required(ErrorMessage = "It's required.")]
        public string Detail { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BookId { get; set; }
        public  Book Book { get; set; }
    }
}
