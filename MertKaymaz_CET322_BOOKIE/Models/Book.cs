using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MertKaymaz_CET322_BOOKIE.Models
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength =3, ErrorMessage="Must be in between 3 and 100 characters.")]
        [Required(ErrorMessage ="It's required.")]
        public string Title { get; set; }
        public int? PageCount { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Must be in between 3 and 100 characters.")]
        [Required(ErrorMessage = "It's required.")]
        public string Authors { get; set; }
        [StringLength(500, MinimumLength = 3)]
        public string Description { get; set; }
        [Required(ErrorMessage = "It's required.")]
        public decimal MinPrice { get; set; }
        public decimal OfferPrice { get; set; }
        [Required(ErrorMessage = "It's required.")]
        public int PressYear { get; set; }
        [Required(ErrorMessage = "It's required.")]
        public string Condition { get; set; }
        public DateTime CreatedDate { get; set; }
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public Book()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
