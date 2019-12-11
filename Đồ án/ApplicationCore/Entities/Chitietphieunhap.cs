using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public partial class Chitietphieunhap : IAggregateRoot
    {
        public int ChitietphieunhapId { get; set; }
        public int Soluong { get; set; }
        public int? MonanId { get; set; }
        public int? PhieunhapId { get; set; }

        public virtual Monan Monan { get; set; }
        public virtual Phieunhap Phieunhap { get; set; }
    }
}
