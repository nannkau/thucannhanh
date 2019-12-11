using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface INhanvienService
    {
        NhanvienDto GetNhanvien(int id);
        IEnumerable<NhanvienDto> GetNhanviens(string searchString, int pageIndex, int pageSize, out int count);
        int GetIdNhanvien(string ten);
        IEnumerable<string> ListNhanvien();
        //
       // IEnumerable<Monan> GetListMonan();
        void CreateNhanvien(SaveNhanvienDto savenhanvienDto);
        void UpdateNhanvien(SaveNhanvienDto saveNhanvienDto);
        void DeleteNhanvien(int id);
    }
}
