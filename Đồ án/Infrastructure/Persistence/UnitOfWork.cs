using ApplicationCore.Interfaces;
using Infrastructure.Persistence.Repositories;

namespace Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FastfoodContext _context;

        public UnitOfWork(FastfoodContext context)
        {
            Monans = new MonanRepository(context);
            Nhanviens = new NhanvienRepository(context);
            Hoadons = new HoadonRepository(context);
            ChitietHoadons = new ChitiethoadonRepository(context);
            _context = context;
        }

        public IMonanRepository Monans { get; private set; }
        public INhanvienRepository Nhanviens { get; private set; }
        public IHoadonRepository Hoadons { get; private set; }
        public IChitietHoadonRepository ChitietHoadons { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}