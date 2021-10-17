using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenPhuongThuyLinh128.Models
{
    public class PersonNPTL128
    {
        [Column(TypeName="varchar(20)")]
        public int PersonId { get; set; }

        [Column(TypeName="varchar(50)")]
        [Required]
        public string PersonName { get; set; }
    }
}