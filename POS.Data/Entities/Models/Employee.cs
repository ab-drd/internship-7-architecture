using System;
using System.Collections.Generic;

namespace POS.Data.Entities.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime WorktimeStart { get; set; }
        public DateTime WorktimeEnd { get; set; }

        public ICollection<Offer> Offers { get; set; }
    }
}
