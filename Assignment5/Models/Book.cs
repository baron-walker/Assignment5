using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Book
    {
        // All Properties required and validated
        [Key]
        [Required]
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthFirst { get; set; }
        public string AuthMid { get; set; } 
        [Required]
        public string AuthLast { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        // Regex requiring ISBN 13 starting with 978 or 979 and validating for function
        [RegularExpression("^(97(8|9))-?\\d{9}[\\dXx]{1}$")]
        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int PageNum { get; set; }
    }
}
