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
            Zolnierz = new HashSet<Zolnierz>();
        }

        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Column("IDUZYTKOWNIKA")]
        public int Iduzytkownika { get; set; }
        [Column("LOGIN")]
        [StringLength(80)]
        public string Login { get; set; }
        [Column("HASLO")]
        [StringLength(1024)]
        public string Haslo { get; set; }
        [Column("IDROLI")]
        public int? Idroli { get; set; }

        [ForeignKey("Idroli")]
        [InverseProperty("Uzytkownik")]
        public Rola IdroliNavigation { get; set; }

        [InverseProperty("IduzytkownikaNavigation")]
        public ICollection<Zolnierz> Zolnierz { get; set; }
    }
}
