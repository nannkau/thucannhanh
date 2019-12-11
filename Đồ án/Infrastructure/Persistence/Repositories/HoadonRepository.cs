using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Repositories
{
  public class HoadonRepository : Repository<Hoadon>, IHoadonRepository
    {
        public HoadonRepository(FastfoodContext context) : base(context)
        {
        }
        protected new FastfoodContext Context => base.Context as FastfoodContext;
    }
}
