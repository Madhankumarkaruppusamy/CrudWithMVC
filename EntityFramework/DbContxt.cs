using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class DbContxt : DbContext
    {
        public DbContxt(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Registration> Registration { get; set; }
    }
}
