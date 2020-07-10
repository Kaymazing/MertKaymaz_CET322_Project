using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MertKaymaz_CET322_BOOKIE.Models
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength =3)]
        public string Title { get; set; }
        public int? PageCount { get; set; }
        public string Authors { get; set; }
        public string Description { get; set; }
        public decimal MinPrice { get; set; }
        public decimal OfferPrice { get; set; }
        public int PressYear { get; set; }
        public string Condition { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public Book()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
