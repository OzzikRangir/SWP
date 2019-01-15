using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("ZAJECIE")]
    public partial class Zajecie
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Column("IDZAJECIA")]
        public int Idzajecia { get; set; }
        [Column("IDGRUPY")]
        [StringLength(10)]
        public string Idgrupy { get; set; }
        [Column("DATAZAJECIA", TypeName = "datetime")]
        public DateTime? Datazajecia { get; set; }
        [Column("NAZWAZAJECIA")]
        [StringLength(20)]
        public string Nazwazajecia { get; set; }
        [Column("MIEJSCE")]
        [StringLength(10)]
        public string Miejsce { get; set; }


        [ForeignKey("Idgrupy")]
        [InverseProperty("Zajecie")]
        public Grupa IdgrupyNavigation { get; set; }
    }
}
