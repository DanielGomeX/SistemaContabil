using SistemaContabil.Core.Aggregates.Fiscal.Contracts;
using SistemaContabil.Core.Aggregates.Fiscal.Entities;
using SistemaContabil.Core.Aggregates.Fiscal.Repositories;
using SistemaContabil.Core.Contracts;
using SistemaContabil.Core.SharedKernel.Contracts;
using SistemaContabil.Core.SharedKernel.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaContabil.Core.Aggregates.Fiscal.Services
{
    public class NotaFiscalService : BaseService, INotaFiscalService
    {
        private readonly INotaFiscalRepository _notaFiscalRepository;

        public NotaFiscalService(INotaFiscalRepository notaFiscalRepository,
            INotificationHandler notificationHandler,
            IUnitOfWork unitOfWork)
            : base(notificationHandler, unitOfWork)
        {
            _notaFiscalRepository = notaFiscalRepository;
        }

        public void DeleteNotaFiscal(Guid id)
        {
            _notaFiscalRepository.Remove(id);
            Commit();
        }

        public IEnumerable<NotaFiscalEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<NotaFiscalEntity> GetNotaFiscal(Guid id)
        {
            return await _notaFiscalRepository.GetAsync(id);
        }

        public Task<NotaFiscalEntity> InsertNotaFiscal(NotaFiscalEntity notaFiscalEntity)
        {
            if (!notaFiscalEntity.IsValid())
            {
                NotificarValidacoesErro(notaFiscalEntity.ValidationResult);
                return null;
            }

            var notaFiscal = _notaFiscalRepository.Add(notaFiscalEntity);
            Commit();

            return notaFiscal;
        }

        public void UpdateNotaFiscal(Guid id, NotaFiscalEntity notaFiscalEntity)
        {
            if (notaFiscalEntity == null)
            {
                NotificarValidacoesErro(notaFiscalEntity.ValidationResult);
            }

            _notaFiscalRepository.Update(id, notaFiscalEntity);
            Commit();

        }
    }
}
