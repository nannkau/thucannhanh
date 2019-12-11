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
    public class NhanvienService : INhanvienService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public NhanvienService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public void CreateNhanvien(SaveNhanvienDto savenhanvienDto)
        {
            var nhanvien = _mapper.Map<SaveNhanvienDto, Nhanvien>(savenhanvienDto);
            _unitOfWork.Nhanviens.Add(nhanvien);

            _unitOfWork.Complete();
        }

        public void DeleteNhanvien(int id)
        {
            var nhanvien = _unitOfWork.Nhanviens.GetBy(id);
            if (nhanvien != null)
            {
                _unitOfWork.Nhanviens.Remove(nhanvien);
                _unitOfWork.Complete();
            }

        }

        public int GetIdNhanvien(string ten)
        {
            var id = _unitOfWork.Nhanviens.GetIdNhanvien(ten);
            return id;
        }

        public NhanvienDto GetNhanvien(int id)
        {
            var nhanvien = _unitOfWork.Nhanviens.GetBy(id);
            return _mapper.Map<Nhanvien, NhanvienDto>(nhanvien);
        }

        public IEnumerable<NhanvienDto> GetNhanviens(string searchString, int pageIndex, int pageSize, out int count)
        {
            NhanvienSpecification nhanvienFilterPaginated = new NhanvienSpecification(searchString,  pageIndex, pageSize);
            NhanvienSpecification nhanvienFilter = new NhanvienSpecification(searchString);

            var nhanviens = _unitOfWork.Nhanviens.Find(nhanvienFilterPaginated);
            count = _unitOfWork.Nhanviens.Count(nhanvienFilter);

            return _mapper.Map<IEnumerable<Nhanvien>, IEnumerable<NhanvienDto>>(nhanviens);
        }

        public IEnumerable<string> ListNhanvien()
        {
            return _unitOfWork.Nhanviens.ListNhanvien();
        }

        public void UpdateNhanvien(SaveNhanvienDto saveNhanvienDto)
        {
            var nhanvien = _unitOfWork.Nhanviens.GetBy(saveNhanvienDto.NhanvienId);
            if (nhanvien == null) return;

            _mapper.Map<SaveNhanvienDto, Nhanvien>(saveNhanvienDto, nhanvien);

            _unitOfWork.Complete();
        }

        //test
       
    }
}
