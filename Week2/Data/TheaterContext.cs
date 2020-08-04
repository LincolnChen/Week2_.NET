using Week2.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week2.Data
{
        public class Week2Context : DbContext
        {
            public Week2Context(DbContextOptions<Week2Context> options)
                : base(options)
            {
            }

            public DbSet<Week2.Models.Movie> Movie { get; set; }
        }

}
