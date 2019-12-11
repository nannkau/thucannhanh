using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using Fastfood.Interfaces;
using Fastfood.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fastfood.Services
{
    public class NhanvienIndexVmService : INhanvienIndexVmService
    {
        private int pageSize = 3;
        private readonly INhanvienService _service;

        public NhanvienIndexVmService(INhanvienService nhanvienService)
        {
            
            _service = nhanvienService;
           
        }
        public NhanvienIndexVm GetNhanvienListVm(string searchString, int pageIndex = 1)
        {
            int count;
            var nhanviens = _service.GetNhanviens(searchString, pageIndex, pageSize, out count);
            var tennhanviens = _service.ListNhanvien();
            return new NhanvienIndexVm
            {
                TenNhanviens = new SelectList(tennhanviens),
                Nhanviens = new PaginatedList<NhanvienDto>(nhanviens, pageIndex, pageSize, count)
            };
        }

        public NhanvienIndexVm GetTen()
        {
            var tennhanviens = _service.ListNhanvien();
            return new NhanvienIndexVm
            {
                TenNhanviens = new SelectList(tennhanviens)
                
            };
        }
    }
}
