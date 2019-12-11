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
    public class MonanService : IMonanService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MonanService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Monan> GetListMonan()
        {
            var Products = _unitOfWork.Monans.GetAll().ToList<Monan>();
            return Products;
        }

        public void CreateMonan(SaveMonanDto saveMonanDto)
        {
            var monan = _mapper.Map<SaveMonanDto, Monan>(saveMonanDto);
            _unitOfWork.Monans.Add(monan);

            _unitOfWork.Complete();
        }

        public void DeleteMonan(int id)
        {

            var monan = _unitOfWork.Monans.GetBy(id);
            if (monan != null)
            {
                _unitOfWork.Monans.Remove(monan);
                _unitOfWork.Complete();
            }
        }

        public IEnumerable<string> GetLoaiMonan()
        {
            return _unitOfWork.Monans.LoaiMonan();
        }
       

        public MonanDto GetMonan(int id)
        {
            var monan = _unitOfWork.Monans.GetBy(id);
            return _mapper.Map<Monan, MonanDto>(monan);
        }

        public IEnumerable<MonanDto> GetMonans(string searchString, string Loai, int pageIndex, int pageSize, out int count)
        {
            MonanSpecification monanFilterPaginated = new MonanSpecification(searchString, Loai, pageIndex, pageSize);
            MonanSpecification monanFilter = new MonanSpecification(searchString, Loai);

            var monans = _unitOfWork.Monans.Find(monanFilterPaginated);
            count = _unitOfWork.Monans.Count(monanFilter);

            return _mapper.Map<IEnumerable<Monan>, IEnumerable<MonanDto>>(monans);
        }

        public void UpdateMonan(SaveMonanDto saveMonanDto)
        {
            var monan = _unitOfWork.Monans.GetBy(saveMonanDto.MonanId);
            if (monan == null) return;

            _mapper.Map<SaveMonanDto, Monan>(saveMonanDto, monan);

            _unitOfWork.Complete();
        }
    }
}
