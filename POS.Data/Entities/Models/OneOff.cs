using System;

namespace POS.Data.Entities.Models
{
    public class OneOff
    {
        public int Id { get; set; }
        public float TotalCost { get; set; }
        public DateTime DateOfIssue { get; set; }

        public Bill Bill { get; set; }
    }
}
