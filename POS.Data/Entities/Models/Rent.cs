using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Entities.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public float PricePerDay { get; set; }

        public Offer Offer { get; set; }
    }
}
