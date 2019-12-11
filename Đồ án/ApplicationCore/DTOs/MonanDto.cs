using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class MonanDto
    {
        public MonanDto()
        {
            Chitiethoadon = new HashSet<ChitiethoadonDto>();
            Chitietphieunhap = new HashSet<ChitietphieunhapDto>();
        }

        public int MonanId { get; set; }
        public string Ten { get; set; }
        public string Loai { get; set; }
        public int GiaMua { get; set; }
        public int GiaBan { get; set; }
        public int Soluong { get; set; }
        public string Nhacc { get; set; }

        public virtual ICollection<ChitiethoadonDto> Chitiethoadon { get; set; }
        public virtual ICollection<ChitietphieunhapDto> Chitietphieunhap { get; set; }
    }
}
