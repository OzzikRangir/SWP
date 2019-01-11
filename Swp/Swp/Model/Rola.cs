﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("ROLA")]
    public partial class Rola : IdentityRole<string>
    {
        public Rola()
        {
            Uzytkownikrola = new HashSet<Uzytkownikrola>();
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
        public ICollection<Uzytkownikrola> Uzytkownikrola { get; set; }
    }
}
