using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Linq;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Repositories
{
   public class NhanvienRepository : Repository<Nhanvien>,INhanvienRepository
    {
    
        public NhanvienRepository(FastfoodContext context) : base(context)
        {

        }
       
        protected new FastfoodContext Context => base.Context as FastfoodContext;

        public int GetIdNhanvien(string ten)
        {


            var _ten = from m in Context.Nhanvien
                      where m.Ten == ten
                            select m.NhanvienId ;

                return _ten.First<int>();


          
        }

        public IEnumerable<string> ListNhanvien()
        {
            var nhanviens = from m in Context.Nhanvien
                        orderby m.Ten
                        select m.Ten;

            return nhanviens.Distinct().ToList();

        }
    }
}
