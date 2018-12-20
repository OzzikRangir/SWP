using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("WNIOSEK")]
    public partial class Wniosek
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Column("IDWNIOSKU")]
        public int Idwniosku { get; set; }
        [Column("NAZWAPLIKU")]
        [StringLength(80)]
        public string Nazwapliku { get; set; }
    }
}
