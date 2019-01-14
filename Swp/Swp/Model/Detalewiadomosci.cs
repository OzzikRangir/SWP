using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("DETALEWIADOMOSCI")]
    public partial class Detalewiadomosci
    {

        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Column("IDWIADOMOSCI")]
        public int Idwiadomosci { get; set; }
        [Column("IDZOLNIERZA")]
        public int? Idzolnierza { get; set; }
        [Column("DATAOTRZYMANIA", TypeName = "datetime")]
        public DateTime? Dataotrzymania { get; set; }

        [ForeignKey("Idwiadomosci")]
        [InverseProperty("Detalewiadomosci")]
        public Wiadomosc IdwiadomosciNavigation { get; set; }
        [ForeignKey("Idzolnierza")]
        [InverseProperty("Detalewiadomosci")]
        public Zolnierz IdzolnierzaNavigation { get; set; }
    }
}
