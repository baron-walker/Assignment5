using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        // return the total pages as number of books divided by books per page with a remainder page
        public int TotalPages => (int)(Math.Ceiling((decimal) TotalNumItems / ItemsPerPage));

    }
}
