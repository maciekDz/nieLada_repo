using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NieLada.Models
{
    public class Wielkosc
    {
        public int Id { get; set; }
        [Display(Name ="Typ")]
        public string Nazwa { get; set; }

        private int numer;
        [Display(Name ="W kolejności")]
        public int Numer {
            get { return numer; }
            set
            {
                if (value > Ilosc)
                {
                    value = 0;
                }
                else
                {
                    numer= value;
                };
            }  
        }
        public string ZdjecieUrl { get; set; }
        [Display(Name ="Szczegóły")]
        public string Opis { get; set; }

        public int Ilosc { get { return 5; }}
    }
}