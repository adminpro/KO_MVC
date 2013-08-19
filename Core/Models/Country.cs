using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Country
    {
        public string Iso { get; set; }
        public string CountryName { get; set; }
        public string CountryPrintableName { get; set; }
        public string Iso3 { get; set; }
        public Nullable<short> NumCode { get; set; }
        public bool PostalCodeNeeded { get; set; }
        public string PrimaryLanguage { get; set; }
    }
}
