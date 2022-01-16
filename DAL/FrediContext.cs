using FrediTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrediTask.DAL
{
    public class FrediContext : DbContext
    {
        public FrediContext(DbContextOptions<FrediContext> options) : base(options) { }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
