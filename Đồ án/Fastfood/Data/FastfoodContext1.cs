using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Fastfood.Models
{
    public class FastfoodContext1 : DbContext
    {
        public FastfoodContext1 (DbContextOptions<FastfoodContext1> options)
            : base(options)
        {
        }

        public DbSet<Fastfood.Models.Hoadon> Hoadon { get; set; }
    }
}
