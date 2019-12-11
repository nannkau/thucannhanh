using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Monan, MonanDto>();
            CreateMap<SaveMonanDto, Monan>();
            CreateMap<MonanDto, SaveMonanDto>();
            CreateMap<Nhanvien, NhanvienDto>();
            CreateMap<SaveNhanvienDto, Nhanvien>();
            CreateMap<NhanvienDto, SaveNhanvienDto>();
            CreateMap<Hoadon, HoadonDto>();
            CreateMap<SaveHoadonDto, Hoadon>();
            CreateMap<HoadonDto, SaveHoadonDto>();
        }
    }
}
