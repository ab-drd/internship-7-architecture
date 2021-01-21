using System;
using System.Collections.Generic;

namespace POS.Data.Entities.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Offer> Offers { get; set; }
    }
}
