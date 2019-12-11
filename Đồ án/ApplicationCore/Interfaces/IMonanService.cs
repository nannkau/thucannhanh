using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IMonanService
    {
        MonanDto GetMonan(int id);
        IEnumerable<MonanDto> GetMonans(string searchString, string loai, int pageIndex, int pageSize, out int count);
        IEnumerable<string> GetLoaiMonan();
        void CreateMonan(SaveMonanDto savemonanDto);
        IEnumerable<Monan> GetListMonan();
        void UpdateMonan(SaveMonanDto saveMonanDto);
        void DeleteMonan(int id);
    }
}
