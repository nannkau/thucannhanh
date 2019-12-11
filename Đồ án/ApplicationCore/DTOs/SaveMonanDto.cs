using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class SaveMonanDto
    {
        public SaveMonanDto()
        {
            Chitiethoadon = new HashSet<SaveChitiethoadonDto>();
            Chitietphieunhap = new HashSet<SaveChitietphieunhapDto>();
        }

        public int MonanId { get; set; }
        public string Ten { get; set; }
        public string Loai { get; set; }
        public int GiaMua { get; set; }
        public int GiaBan { get; set; }
        public int Soluong { get; set; }
        public string Nhacc { get; set; }

        public virtual ICollection<SaveChitiethoadonDto> Chitiethoadon { get; set; }
        public virtual ICollection<SaveChitietphieunhapDto> Chitietphieunhap { get; set; }
    }
}
