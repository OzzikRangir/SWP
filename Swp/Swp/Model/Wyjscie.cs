using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("WYJSCIE")]
    public partial class Wyjscie
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Column("IDWYJSCIA")]
        public int Idwyjscia { get; set; }
        [Column("IDZOLNIERZA")]
        public int? Idzolnierza { get; set; }
        [Column("RODZAJ_WYJSCIA")]
        public int RodzajWyjscia { get; set; }
        [Column("DATAWYJSCIA", TypeName = "datetime")]
        public DateTime? Datawyjscia { get; set; }
        [Column("DATAPOWROTU", TypeName = "datetime")]
        public DateTime? Datapowrotu { get; set; }


        [ForeignKey("Idzolnierza")]
        [InverseProperty("Wyjscie")]
        public Zolnierz IdzolnierzaNavigation { get; set; }

        public Dictionary<int, string> WyjsciaSlownik = new Dictionary<int, string>()
        {

        {0,"PS" },
        {1, "PJ" },
        {2,"KU" },
        {3,"PSŁ" }
      

};
    }
}
