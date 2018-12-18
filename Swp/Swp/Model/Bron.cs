using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("BRON")]
    public partial class Bron
    {
        [Key]
        [Column("IDBRONI")]
        public int Idbroni { get; set; }
        [Column("IDZOLNIERZA")]
        public int? Idzolnierza { get; set; }
        [Column("NAZWABRONI")]
        [StringLength(80)]
        public string Nazwabroni { get; set; }
        [Column("STAN_BRONI")]
        [StringLength(10)]
        public string StanBroni { get; set; }

        [ForeignKey("Idzolnierza")]
        [InverseProperty("Bron")]
        public Zolnierz IdzolnierzaNavigation { get; set; }
    }
}
