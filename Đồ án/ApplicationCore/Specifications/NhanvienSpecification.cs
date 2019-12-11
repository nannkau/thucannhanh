using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Specifications
{
    public class NhanvienSpecification : Specification<Nhanvien>
    {
        public NhanvienSpecification(string searchString)
         : base(MakeCriteria(searchString))
        {
        }
        public NhanvienSpecification(string searchString, int pageIndex, int pageSize)
            : this(searchString)
        {
            ApplyPaging(pageIndex, pageSize);
        }
        private static Expression<Func<Nhanvien, bool>> MakeCriteria(string searchString)
        {
            Expression<Func<Nhanvien, bool>> predicate = m => true;

            if (!string.IsNullOrEmpty(searchString))
            {
                predicate = m => m.Ten.Contains(searchString);
            }
          
            return predicate;
        }
    }
}
