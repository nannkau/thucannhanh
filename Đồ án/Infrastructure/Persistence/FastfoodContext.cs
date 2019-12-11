using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Persistence
{

    public class FastfoodContext : DbContext
    {
        public FastfoodContext (DbContextOptions<FastfoodContext> options)
            : base(options)
        {
        }

        public DbSet<Nhanvien> Nhanvien { get; set; }

        public DbSet<Monan> Monan { get; set; }

        public DbSet<Chitiethoadon> Chitiethoadon { get; set; }
        public DbSet<Hoadon> Hoadon { get; set; }
        public DbSet<Chitietphieunhap> Chitietphieunhap { get; set; }

        public DbSet<User> User { get; set; }
    }
}
