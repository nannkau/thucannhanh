using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class User : IAggregateRoot
    {
        public int UserId { get; set; }
        public  string Taikhoan { get; set; }
        public string Matkhau { get; set; }
        public string Quyen { get; set; }

    }
}
