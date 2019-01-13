using AutoMapper;
using SistemaContabil.Application.Contracts;
using SistemaContabil.Application.ViewModels;
using SistemaContabil.Core.Aggregates.Fiscal.Contracts;
using SistemaContabil.Core.Aggregates.Fiscal.Entities;
using System;
using System.Threading.Tasks;

namespace SistemaContabil.Application.AppServices
{
    public class NotaFiscalAppService : INotaFiscalAppService
    {
        private readonly INotaFiscalService _notaFiscalService;
        private readonly IMapper _mapper;

        public NotaFiscalAppService(INotaFiscalService notaFiscalService, IMapper mapper)
        {
            _mapper = mapper;
            _notaFiscalService = notaFiscalService;
        }

        public void AtualizarNotaFiscal(Guid id, NotaFiscalViewModel notaFiscalViewModel)
        {
            var notaFiscalEntity = _mapper.Map<NotaFiscalEntity>(notaFiscalViewModel);

            _notaFiscalService.UpdateNotaFiscal(id, notaFiscalEntity);
        }

        public async Task<NotaFiscalViewModel> CriarNotaFiscal(NotaFiscalViewModel notaFiscalViewModel)
        {
            var notaFiscalEntity = _mapper.Map<NotaFiscalEntity>(notaFiscalViewModel);

            var novaNotaFiscal = await _notaFiscalService.InsertNotaFiscal(notaFiscalEntity);

            return _mapper.Map<NotaFiscalViewModel>(novaNotaFiscal);
        }

        public void DetelarNotaFiscal(Guid id)
        {
            _notaFiscalService.DeleteNotaFiscal(id);
        }

        public async Task<NotaFiscalViewModel> ObterNotaFiscal(Guid id)
        {
            var notaFiscal = await _notaFiscalService.GetNotaFiscal(id);

            return _mapper.Map<NotaFiscalViewModel>(notaFiscal);
        }
    }
}
