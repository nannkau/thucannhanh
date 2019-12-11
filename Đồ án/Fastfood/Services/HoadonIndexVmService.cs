using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using Fastfood.Interfaces;
using Fastfood.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fastfood.Services
{
    public class HoadonIndexVmService : IHoadonIndexVmService
    {
        private int pageSize = 3;
        private readonly IHoadonService _service;

        public HoadonIndexVmService(IHoadonService monanService)
        {
            _service = monanService;
        }
        public HoadonIndexVm GetHoadonListVm(string searchString,  int pageIndex = 1)
        {
            int count;
            var hoadons = _service.GetHoadons(searchString, pageIndex, pageSize, out count);

            return new HoadonIndexVm
            {

                Hoadons = new PaginatedList<HoadonDto>(hoadons, pageIndex, pageSize, count)
            };
        }
    }
}
