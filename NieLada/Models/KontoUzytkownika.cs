using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NieLada.Models
{
    public class KontoUzytkownika
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Imię")]
        public string Imie { get; set; }

        [Required]
        [Display(Name = "Nazwisko")]
        public string Nazwisko { get; set; }

        public string Nazwa { get { return String.Format("{0} {1}", this.Imie, this.Nazwisko); } }

        [Required]
        public string Telefon { get; set; }
        public  bool CzyTelefon { get { return this.Telefon != ""; } }

        [Required]
        public string Email { get; set; }
        public bool CzyEmail { get { return this.Email != ""; } }

        public string Ulica { get; set; }

        [Display(Name ="Nr domu")]
        public string NrDomu { get; set; }

        [Display(Name = "Nr mieszkania")]
        public string NrMieszkania { get; set; }

        [Display(Name = "Kod pocztowy")]
        public string KodPocztowy { get; set; }

        public string Miasto { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public string KontoUzytkownikaId { get; set; }

        public virtual ICollection<Zamowienie> Zamowienia { get; set; }
    }
}