using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NieLada.Models
{
    public class Zamowienie
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nazwij Mnie")]
        public string Nazwa { get; set; }

        //[Required]
        [Display(Name = "Data złożenia")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime KiedyZlozone { get; set; }

        [Display(Name = "Zdjęcie")]
        public string ZdjecieUrl { get; set; }

        [Required]
        [Display(Name ="Na kiedy")]
        //[DisplayFormat(DataFormatString = "{0:dd MMM yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime NaKiedy { get; set; }

        [Required]
        [Display(Name = "Twój budżet")]
        [DataType(DataType.Currency)]
        public Single Budzet { get; set; }

        public string Telefon { get; set; }
        public string Email { get; set; }

        public bool Zdostawa { get; set; }

        public string Ulica { get; set; }
        public string NrDomu { get; set; }
        public string NrMieszkania { get; set; }
        public string KodPocztowy { get; set; }
        public string Miasto { get; set; }

        [DataType(DataType.MultilineText)]
        public string Opis { get; set; }

        public string Status { get; set; }

        //public List<Zamowienie> Zamowienia { get; set; }
        [Required]
        public string KontoUzytkownikaId { get; set; }
        public virtual KontoUzytkownika kontoUzytkownika { get; set; }

    }

}