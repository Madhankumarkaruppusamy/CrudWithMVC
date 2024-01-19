using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkMVC
{
    public class DbContxt : DbContext
    {
        public DbContxt(DbContextOptions<DbContxt> options) : base(options)
        {

        }
        public  DbSet<Registration> Registration { get; set; }
    }
}
