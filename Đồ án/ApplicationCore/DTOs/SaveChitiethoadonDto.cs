using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class SaveChitiethoadonDto
    {
        public int ChitiethoadonId { get; set; }
        public int Soluong { get; set; }
        public int? MonanId { get; set; }
        public int? HoadonId { get; set; }

        public virtual SaveHoadonDto Hoadon { get; set; }
        public virtual SaveMonanDto Monan { get; set; }
    }
}
