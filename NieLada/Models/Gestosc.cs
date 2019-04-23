using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NieLada.Models
{
    public class Gestosc
    {
        public int Id { get; set; }
        [Display(Name = "Typ")]
        public string Nazwa { get; set; }

        private int numer;
        [Display(Name = "W kolejności")]
        public int Numer
        {
            get { return numer; }
            set
            {
                if (value > Ilosc)
                {
                    value = 0;
                }
                else
                {
                    numer = value;
                };
            }
        }
        public string ZdjecieUrl { get; set; }
        [Display(Name = "Szczegóły")]
        public string Opis { get; set; }

        public int Ilosc { get { return 4; } }
    }
}