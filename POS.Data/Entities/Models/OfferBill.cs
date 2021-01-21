using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Entities.Models
{
    public class OfferBill
    {
        public int Id { get; set; }

        public DateTime DateOfIssue { get; set; }

        public int? ServiceBillId { get; set; }
        public ServiceBill ServiceBill { get; set; }

        public ICollection<Offer> Offers { get; set; }
        public ICollection<Bill> Bills { get; set; }
    }
}
