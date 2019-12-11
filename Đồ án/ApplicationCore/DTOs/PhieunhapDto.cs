using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class PhieunhapDto
    {
        public PhieunhapDto()
        {
            Chitietphieunhap = new HashSet<ChitietphieunhapDto>();
        }

        public int PhieunhapId { get; set; }
        public int Tongtien { get; set; }
        public DateTime Ngaylap { get; set; }
        public int? NhanvienId { get; set; }

        public virtual NhanvienDto Nhanvien { get; set; }
        public virtual ICollection<ChitietphieunhapDto> Chitietphieunhap { get; set; }
    }
}
