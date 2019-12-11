using ApplicationCore.Entities;
using ApplicationCore.Specifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IMonanRepository : IRepository<Monan>
    {
        IEnumerable<string> LoaiMonan();
       
    }
}
