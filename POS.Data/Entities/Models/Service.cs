using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Entities.Models
{
    public class Service
    {
        public int Id { get; set; }
        public float PricePerHour { get; set; }

        public Offer Offer { get; set; }
    }
}
