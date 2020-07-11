using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MertKaymaz_CET322_BOOKIE.ViewModel
{
    public class SearchViewModel
    {
        [Display(Name="Search Text")]
        public string SearchText { get; set; }
        [Display(Name = "Search in Description?")]
        public bool SearchInDescription { get; set; }
        [Display(Name = "Category Selection")]
        public int? CategoryId { get; set; }
        [Display(Name = "Minimum Price")]
        public decimal? MinPrice { get; set; }
        [Display(Name = "Maximum Price")]
        public decimal? MaxPrice { get; set; }
        public List<Models.Book> Results { get; set; }

    }
}
