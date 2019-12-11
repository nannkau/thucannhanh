using System;

namespace ApplicationCore.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
       
       IMonanRepository Monans { get; }
        INhanvienRepository Nhanviens { get; }
        IHoadonRepository Hoadons { get; }
        IChitietHoadonRepository ChitietHoadons { get; }
        int Complete();
    }
}