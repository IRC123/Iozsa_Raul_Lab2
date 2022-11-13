using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Iozsa_Raul_Lab2.Models;

namespace Iozsa_Raul_Lab2.Data
{
    public class Iozsa_Raul_Lab2Context : DbContext
    {
        public Iozsa_Raul_Lab2Context (DbContextOptions<Iozsa_Raul_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Iozsa_Raul_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Iozsa_Raul_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
