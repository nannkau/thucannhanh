using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fastfood.Models;

namespace Fastfood.Data
{
    public class FastfoodContext : DbContext
    {
        public FastfoodContext (DbContextOptions<FastfoodContext> options)
            : base(options)
        {
        }

        public DbSet<Fastfood.Models.Nhanvien> Nhanvien { get; set; }

        public DbSet<Fastfood.Models.Monan> Monan { get; set; }

        public DbSet<Fastfood.Models.Chitiethoadon> Chitiethoadon { get; set; }

        public DbSet<Fastfood.Models.Chitietphieunhap> Chitietphieunhap { get; set; }

        public DbSet<Fastfood.Models.User> User { get; set; }
    }
}
