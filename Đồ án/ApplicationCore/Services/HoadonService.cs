using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Specifications;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationCore.Services
{
  public  class HoadonService : IHoadonService

    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HoadonService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public void AddOrder(string currentusername, Hoadon Order, List<Item> cart, Chitiethoadon OrderDetail)
        {
            int customerid = _unitOfWork.Nhanviens.GetIdNhanvien(currentusername);

            Order.NhanvienId = customerid;


            Order.Ngaylap = DateTime.Now;

            //add Order

            var orderAdded = _unitOfWork.Hoadons.Add(Order);

            _unitOfWork.Complete(); //save

            //add item
         
            for (var i = 0; i < cart.Count; i++)
            {


                //them vao bang OrderDetail
                OrderDetail = new Chitiethoadon();

                OrderDetail.ChitiethoadonId = cart[i].Product.MonanId;
                OrderDetail.ChitiethoadonId = orderAdded.HoadonId;  //orderid
                OrderDetail.Soluong = cart[i].Quantity;



                _unitOfWork.ChitietHoadons.Add(OrderDetail);
                _unitOfWork.Complete();//luu database
            }

            cart.Clear(); //xoa gio hang


        }

        public void CreateHoadon(SaveHoadonDto saveHoadonDto)
        {
            var hoadon = _mapper.Map<SaveHoadonDto, Hoadon>(saveHoadonDto);
            _unitOfWork.Hoadons.Add(hoadon);

            _unitOfWork.Complete();
        }

        public void DeleteHoadon(int id)
        {
            var hoadon = _unitOfWork.Hoadons.GetBy(id);
            if (hoadon != null)
            {
                _unitOfWork.Hoadons.Remove(hoadon);
                _unitOfWork.Complete();
            }
        }

        public HoadonDto GetHoadon(int id)
        {
            var hoadon = _unitOfWork.Hoadons.GetBy(id);
            return _mapper.Map<Hoadon, HoadonDto>(hoadon);
        }

        public IEnumerable<HoadonDto> GetHoadons(string searchString, int pageIndex, int pageSize, out int count)
        {
            HoadonSpecification HoadonFilterPaginated = new HoadonSpecification(searchString, pageIndex, pageSize);
            HoadonSpecification HoadonFilter = new HoadonSpecification(searchString);

            var hoadons = _unitOfWork.Hoadons.Find(HoadonFilterPaginated);
            count = _unitOfWork.Hoadons.Count(HoadonFilter);

            return _mapper.Map<IEnumerable<Hoadon>, IEnumerable<HoadonDto>>(hoadons);
        }

        public void UpdateHoadon(SaveHoadonDto saveHoadonDto)
        {

            var hoadon = _unitOfWork.Hoadons.GetBy(saveHoadonDto.HoadonId);
            if (hoadon == null) return;

            _mapper.Map<SaveHoadonDto, Hoadon>(saveHoadonDto, hoadon);

            _unitOfWork.Complete();
        }
    }
}
