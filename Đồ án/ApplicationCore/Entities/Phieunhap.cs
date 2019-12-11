using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public partial class Phieunhap : IAggregateRoot
    {
        public Phieunhap()
        {
            Chitietphieunhap = new HashSet<Chitietphieunhap>();
        }

        public int PhieunhapId { get; set; }
        public int Tongtien { get; set; }
        public DateTime Ngaylap { get; set; }
        public int? NhanvienId { get; set; }

        public virtual Nhanvien Nhanvien { get; set; }
        public virtual ICollection<Chitietphieunhap> Chitietphieunhap { get; set; }
    }
}
