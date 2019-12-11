using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Repositories
{
    class ChitiethoadonRepository : Repository<Chitiethoadon>, IChitietHoadonRepository
    {
        public ChitiethoadonRepository(FastfoodContext context) : base(context)
        {
        }
        protected new FastfoodContext Context => base.Context as FastfoodContext;
    }
}
