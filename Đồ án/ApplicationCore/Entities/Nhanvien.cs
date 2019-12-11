using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public partial class Nhanvien : IAggregateRoot
    {
        public Nhanvien()
        {
            Hoadon = new HashSet<Hoadon>();
            Phieunhap = new HashSet<Phieunhap>();
        }

        public int NhanvienId { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string Sodienthoai { get; set; }

        public virtual ICollection<Hoadon> Hoadon { get; set; }
        public virtual ICollection<Phieunhap> Phieunhap { get; set; }
    }
}
