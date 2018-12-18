using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("UZYTKOWNIK")]
    public partial class Uzytkownik
    {
        [Column("IDUZYKOWNIKA")]
        public int Iduzykownika { get; set; }
        [Column("IDZOLNIERZA")]
        public int Idzolnierza { get; set; }
        [Column("LOGIN")]
        [StringLength(80)]
        public string Login { get; set; }
        [Column("HASLO")]
        [StringLength(80)]
        public string Haslo { get; set; }
        [Column("UPRAWNIENIA")]
        public int? Uprawnienia { get; set; }

        [ForeignKey("Idzolnierza")]
        [InverseProperty("Uzytkownik")]
        public Zolnierz IdzolnierzaNavigation { get; set; }
    }
}
