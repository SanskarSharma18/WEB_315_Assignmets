using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuestItems.Models
{
    public class QuestItems
    {
        // add properties
        public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Location { get; set; }
    
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public int Rating { get; set; }
    }
}
