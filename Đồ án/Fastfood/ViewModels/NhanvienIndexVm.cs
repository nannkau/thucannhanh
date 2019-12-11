using ApplicationCore.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fastfood.ViewModels
{
    public class NhanvienIndexVm
    {
        public SelectList TenNhanviens { get; set; }
        public PaginatedList<NhanvienDto> Nhanviens { get; set; }

    }
}
