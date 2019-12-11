using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class ChitiethoadonDto
    {
        public int ChitiethoadonId { get; set; }
        public int Soluong { get; set; }
        public int? MonanId { get; set; }
        public int? HoadonId { get; set; }

        public virtual HoadonDto Hoadon { get; set; }
        public virtual MonanDto Monan { get; set; }
    }
}
