using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("SLUZBA")]
    public partial class Sluzba
    {
        [Key]
        [Column("IDSLUZBY")]
        public int Idsluzby { get; set; }
        [Column("IDZOLNIERZA")]
        public int? Idzolnierza { get; set; }
        [Column("DATASLUZBY", TypeName = "datetime")]
        public DateTime? Datasluzby { get; set; }
        [Column("RODZAJSLUZBY")]
        public int? Rodzajsluzby { get; set; }

        [ForeignKey("Idzolnierza")]
        [InverseProperty("Sluzba")]
        public Zolnierz IdzolnierzaNavigation { get; set; }
    }
}
