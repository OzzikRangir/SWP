using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swp.Model
{
    [Table("ZOLNIERZ")]
    public partial class Zolnierz
    {
        public Zolnierz()
        {
            Bron = new HashSet<Bron>();
            Detalewiadomosci = new HashSet<Detalewiadomosci>();
            Sluzba = new HashSet<Sluzba>();
            Uzytkownik = new HashSet<Uzytkownik>();
            Wiadomosc = new HashSet<Wiadomosc>();
            Wyjazd = new HashSet<Wyjazd>();
            Wyjscie = new HashSet<Wyjscie>();
        }

        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Column("IDZOLNIERZA")]
        public int Idzolnierza { get; set; }
        [Column("IDGRUPY")]
        [StringLength(10)]
        public string Idgrupy { get; set; }
        [Column("STOPIEN")]
        public int Stopien { get; set; }
        [Column("IMIE")]
        [StringLength(80)]
        public string Imie { get; set; }
        [Column("NAZIWSKO")]
        [StringLength(80)]
        public string Naziwsko { get; set; }
        [Column("ADRES")]
        [StringLength(80)]
        public string Adres { get; set; }
        [Column("IMIEOJCA")]
        [StringLength(80)]
        public string Imieojca { get; set; }
        [Column("IMIEMATKI")]
        [StringLength(80)]
        public string Imiematki { get; set; }
        [Column("PESEL")]
        [StringLength(11)]
        public string Pesel { get; set; }
        [Column("NUMERTELEFONU", TypeName = "numeric(9, 0)")]
        public decimal? Numertelefonu { get; set; }        

        [ForeignKey("Idgrupy")]
        [InverseProperty("Zolnierz")]
        public Grupa IdgrupyNavigation { get; set; }
        [InverseProperty("IdzolnierzaNavigation")]
        public ICollection<Bron> Bron { get; set; }
        [InverseProperty("IdzolnierzaNavigation")]
        public ICollection<Detalewiadomosci> Detalewiadomosci { get; set; }
        [InverseProperty("IdzolnierzaNavigation")]
        public ICollection<Sluzba> Sluzba { get; set; }
        [InverseProperty("IdzolnierzaNavigation")]
        public ICollection<Uzytkownik> Uzytkownik { get; set; }
        [InverseProperty("IdzolnierzaNavigation")]
        public ICollection<Wiadomosc> Wiadomosc { get; set; }
        [InverseProperty("IdzolnierzaNavigation")]
        public ICollection<Wyjazd> Wyjazd { get; set; }
        [InverseProperty("IdzolnierzaNavigation")]
        public ICollection<Wyjscie> Wyjscie { get; set; }

        public Dictionary<int, string> StopnieSlownik = new Dictionary<int, string>()
        {

        {0,"szer." },
        {1,"st. szer." },
        {2,"kpr." },
        {3,"st. kpr." },
        {4,"plut." },
        {5,"sierż." },
        {6,"st. sierż." },
        {7,"mł. chor." },
        {8,"chor." },
        {9,"st. chor." },
        {10,"st. chor. sztab." },
        {11,"ppor." },
        {12,"por." },
        {13,"kpt." },

};
    }
}
