using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class SavePhieunhapDto
    {
        public SavePhieunhapDto()
        {
            Chitietphieunhap = new HashSet<SaveChitietphieunhapDto>();
        }

        public int PhieunhapId { get; set; }
        public int Tongtien { get; set; }
        public DateTime Ngaylap { get; set; }
        public int? NhanvienId { get; set; }

        public virtual SaveNhanvienDto Nhanvien { get; set; }
        public virtual ICollection<SaveChitietphieunhapDto> Chitietphieunhap { get; set; }
    }
}
