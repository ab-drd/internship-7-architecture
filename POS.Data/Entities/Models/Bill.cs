using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Entities.Models
{
    public class Bill
    {
        public int Id { get; set; }

        public ICollection<Offer> Offers { get; set; }
    }
}
