using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MertKaymaz_CET322_BOOKIE.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BookId { get; set; }
        public  Book Book { get; set; }
    }
}
