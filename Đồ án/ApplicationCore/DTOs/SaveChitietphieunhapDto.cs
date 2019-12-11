using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class SaveChitietphieunhapDto
    {
        public int ChitietphieunhapId { get; set; }
        public int Soluong { get; set; }
        public int? MonanId { get; set; }
        public int? PhieunhapId { get; set; }

        public virtual SaveMonanDto Monan { get; set; }
        public virtual SavePhieunhapDto Phieunhap { get; set; }
    }
}
