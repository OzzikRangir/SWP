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
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Column("IDWYJAZDU")]
        public int Idwyjazdu { get; set; }
        [Column("IDZOLNIERZA")]
        public int? Idzolnierza { get; set; }
        [Column("RODZAJ_WYJAZDU")]
        public int? RodzajWyjazdu { get; set; }
        [Column("DATAWYJAZDU", TypeName = "datetime")]
        public DateTime? Datawyjazdu { get; set; }

        [ForeignKey("Idzolnierza")]
        [InverseProperty("Wyjazd")]
        public Zolnierz IdzolnierzaNavigation { get; set; }
    }
}
