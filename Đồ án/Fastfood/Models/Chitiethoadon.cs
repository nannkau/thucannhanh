using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fastfood.Models
{
    public class Chitiethoadon
    {
        public int ChitiethoadonId { get; set; }
        public int Soluong { get; set; }
        public Monan Monan { get; set; }
        public Hoadon Hoadon { get; set; }
    }
}
