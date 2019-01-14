using Microsoft.AspNetCore.Identity;
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
            Uzytkownik = new HashSet<Uzytkownik>();
        }

        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Column("IDROLI")]
        public int Idroli { get; set; }
        [Required]
        [Column("NAZWA")]
        [StringLength(20)]
        public string Nazwa { get; set; }
        [InverseProperty("IdroliNavigation")]
        public ICollection<Uzytkownik> Uzytkownik { get; set; }
    }
}
