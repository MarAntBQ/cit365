using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Scripture_Journal.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Book { get; set; }

        [Display(Name = "Added Date"), DataType(DataType.Date)]
        [Required]
        public DateTime AddedDate { get; set; }

        //[Column(TypeName = "integer(18)")]
        [Required]
        public int Chapter { get; set; }

        //[Column(TypeName = "integer(18)")]
        [Required]
        public int Verse { get; set; }

        [StringLength(250, MinimumLength = 10)]
        [Required]
        public string Note { get; set; }
    }
}
