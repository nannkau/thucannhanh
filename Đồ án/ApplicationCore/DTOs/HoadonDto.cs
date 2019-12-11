using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class HoadonDto
    {
        public HoadonDto()
        {
            Chitiethoadon = new HashSet<ChitiethoadonDto>();
        }

        public int HoadonId { get; set; }
        public DateTime Ngaylap { get; set; }
        public int? NhanvienId { get; set; }

        public virtual NhanvienDto Nhanvien { get; set; }
        public virtual ICollection<ChitiethoadonDto> Chitiethoadon { get; set; }
    }
}
