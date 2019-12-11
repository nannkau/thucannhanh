using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public partial class Hoadon : IAggregateRoot
    {
        public Hoadon()
        {
            Chitiethoadon = new HashSet<Chitiethoadon>();
        }

        public int HoadonId { get; set; }
        public DateTime Ngaylap { get; set; }
        public int? NhanvienId { get; set; }

        public virtual Nhanvien Nhanvien { get; set; }
        public virtual ICollection<Chitiethoadon> Chitiethoadon { get; set; }
    }
}
