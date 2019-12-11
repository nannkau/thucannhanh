using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
   public interface INhanvienRepository : IRepository<Nhanvien>
    {
        int GetIdNhanvien(string ten);
        IEnumerable<string> ListNhanvien();

    }
}
