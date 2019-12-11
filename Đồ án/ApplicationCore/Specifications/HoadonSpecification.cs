using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Specifications
{
    public class HoadonSpecification : Specification<Hoadon>
    {
        public HoadonSpecification(string searchString)
         : base(MakeCriteria(searchString))
        {
        }
        public HoadonSpecification(string searchString, int pageIndex, int pageSize)
            : this(searchString)
        {
            ApplyPaging(pageIndex, pageSize);
        }
        private static Expression<Func<Hoadon, bool>> MakeCriteria(string searchString)
        {
            Expression<Func<Hoadon, bool>> predicate = m => true;

            if (!string.IsNullOrEmpty(searchString))
            {
                predicate = m => m.Nhanvien.Ten.Contains(searchString);
            }

            return predicate;
        }
    }
}
