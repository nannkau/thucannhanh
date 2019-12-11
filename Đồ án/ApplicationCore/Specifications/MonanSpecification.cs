using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Specifications
{
    public class MonanSpecification : Specification<Monan>
    {
        public MonanSpecification(string searchString, string loai)
           : base(MakeCriteria(searchString, loai))
        {
        }
        public MonanSpecification(string searchString, string loai, int pageIndex, int pageSize)
            : this(searchString, loai)
        {
            ApplyPaging(pageIndex, pageSize);
        }
        private static Expression<Func<Monan, bool>> MakeCriteria(string searchString, string loai)
        {
            Expression<Func<Monan, bool>> predicate = m => true;

            if (!string.IsNullOrEmpty(searchString) && !string.IsNullOrEmpty(loai))
            {
                predicate = m => m.Loai == loai && m.Loai.Contains(searchString);
            }
            else if (!string.IsNullOrEmpty(searchString))
            {
                predicate = m => m.Loai.Contains(searchString);
            }
            else if (!string.IsNullOrEmpty(loai))
            {
                predicate = m => m.Loai == loai;
            }

            return predicate;
        }
    }
}
