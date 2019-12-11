using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Services
{
   public  class ChitiethoadonService : IChitiethoadonService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ChitiethoadonService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public void CreateChitiethoadon(SaveChitiethoadonDto saveChitiethoadonDto)
        {
            var chitiethd = _mapper.Map<SaveChitiethoadonDto, Chitiethoadon>(saveChitiethoadonDto);
            _unitOfWork.ChitietHoadons.Add(chitiethd);

            _unitOfWork.Complete();
        }
    }
}
