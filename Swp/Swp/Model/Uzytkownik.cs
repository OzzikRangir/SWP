using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("UZYTKOWNIK")]
    public partial class Uzytkownik
    {
        public Uzytkownik()
        {
            Uzytkownikrola = new HashSet<Uzytkownikrola>();
        }

        [Key]
        [Column("IDUZYTKOWNIKA")]
        public int Iduzytkownika { get; set; }
        [Column("LOGIN")]
        [StringLength(80)]
        public string Login { get; set; }
        [Column("HASLO")]
        [StringLength(1024)]
        public string Haslo { get; set; }

        [InverseProperty("IduzytkownikaNavigation")]
        public ICollection<Uzytkownikrola> Uzytkownikrola { get; set; }
    }
}
