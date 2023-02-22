using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_nathanck.Models
{
    public class MovieCategory
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string CategoryName { get; set; }

    }
}
