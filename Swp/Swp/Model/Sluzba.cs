using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("SLUZBA")]
    public partial class Sluzba
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Column("IDSLUZBY")]
        public int Idsluzby { get; set; }
        [Column("IDZOLNIERZA")]
        public int? Idzolnierza { get; set; }
        [Column("DATASLUZBY", TypeName = "datetime")]
        [DataType(DataType.Date)]
        public DateTime? Datasluzby { get; set; }
        [Column("RODZAJSLUZBY")]
        public int? Rodzajsluzby { get; set; }

        [ForeignKey("Idzolnierza")]
        [InverseProperty("Sluzba")]
        public Zolnierz IdzolnierzaNavigation { get; set; }





        [NotMapped]
        public string Rodzaj
        {
            get
            {
                return SluzbySlownik[Rodzajsluzby];
            }

        }

        [NotMapped]
        public string Kolor
        {
            get
            {
                return KolorSlownik[Rodzajsluzby];
            }

        }

        public Dictionary<int?, string> SluzbySlownik = new Dictionary<int?, string>()
        {

        {0,"Podoficer Dyżurny" },
        {1,"Dyżurny" },
        {2,"I POD" },
       

};
        public Dictionary<int?, string> KolorSlownik = new Dictionary<int?, string>()
        {

        {0,"danger" },
        {1,"info" },
        {2,"warning" },


};

    }
}
