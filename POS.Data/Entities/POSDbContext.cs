using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace POS.Data.Entities
{
    class POSDbContext : DbContext
    {
        public POSDbContext(DbContextOptions options) : base(options) 
        {
        }
    }
}
