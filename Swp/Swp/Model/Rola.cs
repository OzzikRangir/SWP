using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("ROLA")]
    public partial class Rola
    {
        public Rola()
        {
            Uzytkownikrola = new HashSet<Uzytkownikrola>();
        }

        [Key]
        [Column("IDROLI")]
        public int Idroli { get; set; }
        [Required]
        [Column("NAZWA")]
        [StringLength(20)]
        public string Nazwa { get; set; }

        [InverseProperty("IdroliNavigation")]
        public ICollection<Uzytkownikrola> Uzytkownikrola { get; set; }
    }
}
