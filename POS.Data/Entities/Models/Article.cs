using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Entities.Models
{
    public class Article
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        public Offer Offer { get; set; }
    }
}
