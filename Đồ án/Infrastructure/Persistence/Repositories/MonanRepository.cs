using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Linq;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Repositories
{
    public class MonanRepository : Repository<Monan>, IMonanRepository
    {
        public MonanRepository(FastfoodContext context) : base(context)
        {
        }
        protected new FastfoodContext Context => base.Context as FastfoodContext;
        public IEnumerable<string> LoaiMonan()
        {
           
                var loais = from m in Context.Monan
                             orderby m.Loai
                             select m.Loai;

                return loais.Distinct().ToList();
            

        }
    }
}
