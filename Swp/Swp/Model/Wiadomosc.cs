using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("WIADOMOSC")]
    public partial class Wiadomosc
    {
        [Key]
        [Column("IDWIADOMOSCI")]
        public int Idwiadomosci { get; set; }
        [Column("IDZOLNIERZA")]
        public int? Idzolnierza { get; set; }
        [Column("TYTUL")]
        [StringLength(80)]
        public string Tytul { get; set; }
        [Column("TRESC")]
        [StringLength(80)]
        public string Tresc { get; set; }

        [ForeignKey("Idzolnierza")]
        [InverseProperty("Wiadomosc")]
        public Zolnierz IdzolnierzaNavigation { get; set; }
        [InverseProperty("IdwiadomosciNavigation")]
        public Detalewiadomosci Detalewiadomosci { get; set; }
    }
}
