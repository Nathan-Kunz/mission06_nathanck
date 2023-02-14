using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_nathanck.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }
        public short Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Note { get; set; }


    }
}
