using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Data.Entities;

namespace POS.Domain.Repositories
{
    public class OfferRepository
    {
        public OfferRepository(POSDbContext dbContext) : base(dbContext) { }
    }
}
