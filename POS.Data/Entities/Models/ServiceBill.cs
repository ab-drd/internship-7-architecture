using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Entities.Models
{
    public class ServiceBill
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int OfferBillId { get; set; }
        public OfferBill OfferBill { get; set; }
    }
}
