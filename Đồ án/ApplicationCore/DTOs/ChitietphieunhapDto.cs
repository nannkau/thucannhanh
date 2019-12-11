using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class ChitietphieunhapDto
    {
        public int ChitietphieunhapId { get; set; }
        public int Soluong { get; set; }
        public int? MonanId { get; set; }
        public int? PhieunhapId { get; set; }

        public virtual MonanDto Monan { get; set; }
        public virtual PhieunhapDto Phieunhap { get; set; }
    }
}
