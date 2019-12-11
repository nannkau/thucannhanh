using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IHoadonService
    {
        
        HoadonDto GetHoadon(int id);

        IEnumerable<HoadonDto> GetHoadons(string searchString, int pageIndex, int pageSize, out int count);

        void CreateHoadon(SaveHoadonDto saveHoadonDto);
        void UpdateHoadon(SaveHoadonDto saveHoadonDto);
        void DeleteHoadon(int id);
        void AddOrder(string currentusername, Hoadon Order, List<Item> cart,Chitiethoadon OrderDetail);
    }
}
