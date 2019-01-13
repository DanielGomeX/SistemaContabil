using SistemaContabil.Application.ViewModels;
using System;
using System.Threading.Tasks;

namespace SistemaContabil.Application.Contracts
{
    public interface INotaFiscalAppService
    {
        Task<NotaFiscalViewModel> CriarNotaFiscal(NotaFiscalViewModel notaFiscalViewModel);
        Task<NotaFiscalViewModel> ObterNotaFiscal(Guid id);
        void DetelarNotaFiscal(Guid id);
        void AtualizarNotaFiscal(Guid id, NotaFiscalViewModel notaFiscalViewModel);
    }
}
