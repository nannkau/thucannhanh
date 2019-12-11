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
    public class MonanIndexVmService : IMonanIndexVmService
    {
        private int pageSize = 3;
        private readonly IMonanService _service;

        public MonanIndexVmService(IMonanService monanService)
        {
            _service = monanService;
        }
        public MonanIndexVm GetMonanListVm(string searchString, string loai, int pageIndex = 1)
        {
            int count;
            var monans = _service.GetMonans(searchString, loai, pageIndex, pageSize, out count);
            var loais = _service.GetLoaiMonan();

            return new MonanIndexVm
            {
                Loai = new SelectList(loais),
                Monans = new PaginatedList<MonanDto>(monans, pageIndex, pageSize, count)
            };
        }
    }
}
