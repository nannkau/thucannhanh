using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public partial class Chitiethoadon : IAggregateRoot
    {
        public int ChitiethoadonId { get; set; }
        public int Soluong { get; set; }
        public int? MonanId { get; set; }
        public int? HoadonId { get; set; }

        public virtual Hoadon Hoadon { get; set; }
        public virtual Monan Monan { get; set; }
    }
}
