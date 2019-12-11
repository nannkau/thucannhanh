using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public partial class Monan  : IAggregateRoot
    {
        public Monan()
        {
            Chitiethoadon = new HashSet<Chitiethoadon>();
            Chitietphieunhap = new HashSet<Chitietphieunhap>();
        }

        public int MonanId { get; set; }
        public string Ten { get; set; }
        public string Loai { get; set; }
        public int GiaMua { get; set; }
        public int GiaBan { get; set; }
        public int Soluong { get; set; }
        public string Nhacc { get; set; }

        public virtual ICollection<Chitiethoadon> Chitiethoadon { get; set; }
        public virtual ICollection<Chitietphieunhap> Chitietphieunhap { get; set; }
    }
}
