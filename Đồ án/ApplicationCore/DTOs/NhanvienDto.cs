using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class NhanvienDto
    {
        public NhanvienDto()
        {
            Hoadon = new HashSet<HoadonDto>();
            Phieunhap = new HashSet<PhieunhapDto>();
        }

        public int NhanvienId { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string Sodienthoai { get; set; }

        public virtual ICollection<HoadonDto> Hoadon { get; set; }
        public virtual ICollection<PhieunhapDto> Phieunhap { get; set; }
    }
}
