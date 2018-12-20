using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("GRUPA")]
    public partial class Grupa
    {
        public Grupa()
        {
            Zajecie = new HashSet<Zajecie>();
            Zolnierz = new HashSet<Zolnierz>();
        }

        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Column("IDGRUPY")]
        [StringLength(10)]
        public string Idgrupy { get; set; }
        [Column("NAZWAGRUPY")]
        [StringLength(30)]
        public string Nazwagrupy { get; set; }

        [InverseProperty("IdgrupyNavigation")]
        public ICollection<Zajecie> Zajecie { get; set; }
        [InverseProperty("IdgrupyNavigation")]
        public ICollection<Zolnierz> Zolnierz { get; set; }
    }
}
