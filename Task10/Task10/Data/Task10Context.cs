using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task10.Models;

namespace Task10.Data
{
    public class Task10Context : DbContext
    {
        public Task10Context (DbContextOptions<Task10Context> options)
            : base(options)
        {
        }

        public DbSet<Task10.Models.Movie> Movie { get; set; }
    }
}
