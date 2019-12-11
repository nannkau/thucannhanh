using Fastfood.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fastfood.Interfaces
{
    public interface IHoadonIndexVmService
    {
        HoadonIndexVm GetHoadonListVm(string searchString, int pageIndex = 1);
    }
}
