using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService1.Models
{
    public class NorthwindEntities : DbContext
    {
        public NorthwindEntities()
        {
        }

        public NorthwindEntities(DbContextOptions<NorthwindEntities> options) : base(options)
        {
            


        }

        public DbSet<User > Kullanicilar { get; set; }
    }
}
