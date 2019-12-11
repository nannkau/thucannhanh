using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class SaveHoadonDto
    {
        public SaveHoadonDto()
        {
            Chitiethoadon = new HashSet<SaveChitiethoadonDto>();
        }

        public int HoadonId { get; set; }
        public DateTime Ngaylap { get; set; }
        public int? NhanvienId { get; set; }

        public virtual SaveNhanvienDto Nhanvien { get; set; }
        public virtual ICollection<SaveChitiethoadonDto> Chitiethoadon { get; set; }
    }
}
