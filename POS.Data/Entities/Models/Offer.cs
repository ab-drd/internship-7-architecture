using System.Collections.Generic;

namespace POS.Data.Entities.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Category> Categories { get; set; }
        public int? OfferBillId { get; set; }
        public OfferBill OfferBill { get; set; }

        public int? ArticleId { get; set; }
        public Article Article { get; set; }

        public int? ServiceId { get; set; }
        public Service Service { get; set; }

        public int? RentId { get; set; }
        public Rent Rent { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<Subscriber> Subscribers { get; set; }

    }
}
