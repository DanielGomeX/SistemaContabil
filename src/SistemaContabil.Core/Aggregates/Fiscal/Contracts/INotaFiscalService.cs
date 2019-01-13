using SistemaContabil.Core.Aggregates.Fiscal.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaContabil.Core.Aggregates.Fiscal.Contracts
{
    public interface INotaFiscalService
    {
        Task<NotaFiscalEntity> InsertNotaFiscal(NotaFiscalEntity notaFiscalEntity);
        void DeleteNotaFiscal(Guid id);
        bool HasNotification();
        void UpdateNotaFiscal(Guid id,NotaFiscalEntity notaFiscalEntity);
        IEnumerable<NotaFiscalEntity> GetAll();
        Task<NotaFiscalEntity> GetNotaFiscal(Guid id);
    }
}
