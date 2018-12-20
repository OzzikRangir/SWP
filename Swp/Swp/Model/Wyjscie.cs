using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("WYJSCIE")]
    public partial class Wyjscie
    {
        [Key]
        [Column("IDWYJSCIA")]
        public int Idwyjscia { get; set; }
        [Column("IDZOLNIERZA")]
        public int? Idzolnierza { get; set; }
        [Column("RODZAJ_WYJSCIA")]
        public int? RodzajWyjscia { get; set; }

        [ForeignKey("Idzolnierza")]
        [InverseProperty("Wyjscie")]
        public Zolnierz IdzolnierzaNavigation { get; set; }
    }
}
