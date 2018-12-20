using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("UZYTKOWNIKROLA")]
    public partial class Uzytkownikrola
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("IDUZYTKOWNIKA")]
        public int Iduzytkownika { get; set; }
        [Column("IDROLI")]
        public int Idroli { get; set; }

        [ForeignKey("Idroli")]
        [InverseProperty("Uzytkownikrola")]
        public Rola IdroliNavigation { get; set; }
        [ForeignKey("Iduzytkownika")]
        [InverseProperty("Uzytkownikrola")]
        public Uzytkownik IduzytkownikaNavigation { get; set; }
    }
}
