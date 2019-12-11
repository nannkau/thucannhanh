using ApplicationCore.DTOs;
using Fastfood.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fastfood.ViewModels
{
    public class HoadonIndexVm 
    {
        public PaginatedList<HoadonDto> Hoadons { get; set; }
    }
}
