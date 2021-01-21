using System;
using System.Collections.Generic;

namespace POS.Data.Entities.Models
{
    public class Subscriber
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OIB { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Offer> Offers { get; set; }
    }
}
