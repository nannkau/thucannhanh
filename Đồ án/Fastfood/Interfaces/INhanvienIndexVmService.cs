using ApplicationCore.Entities;
using Fastfood.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fastfood.Interfaces
{
    public interface INhanvienIndexVmService
    {
        NhanvienIndexVm GetNhanvienListVm(string searchString, int pageIndex = 1);

        NhanvienIndexVm GetTen();

    }
}
