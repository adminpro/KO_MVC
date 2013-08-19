using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Company
    {
        public Company()
        {
            this.Sites = new List<Site>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int RetailerId { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
    }
}
