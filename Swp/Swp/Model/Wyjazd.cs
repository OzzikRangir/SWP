using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("WYJAZD")]
    public partial class Wyjazd
    {
        [Key]
        [Column("IDWYJAZDU")]
        public int Idwyjazdu { get; set; }
        [Column("IDZOLNIERZA")]
        public int? Idzolnierza { get; set; }
        [Column("RODZAJ_WYJAZDU")]
        [StringLength(80)]
        public string RodzajWyjazdu { get; set; }
        [Column("DATAWYJAZDU", TypeName = "datetime")]
        public DateTime? Datawyjazdu { get; set; }

        [ForeignKey("Idzolnierza")]
        [InverseProperty("Wyjazd")]
        public Zolnierz IdzolnierzaNavigation { get; set; }
    }
}
