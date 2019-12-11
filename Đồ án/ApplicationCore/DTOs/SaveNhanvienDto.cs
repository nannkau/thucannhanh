using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class SaveNhanvienDto
    {
        public SaveNhanvienDto()
        {
            Hoadon = new HashSet<SaveHoadonDto>();
            Phieunhap = new HashSet<SavePhieunhapDto>();
        }

        public int NhanvienId { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string Sodienthoai { get; set; }

        public virtual ICollection<SaveHoadonDto> Hoadon { get; set; }
        public virtual ICollection<SavePhieunhapDto> Phieunhap { get; set; }
    }
}
