using Microsoft.AspNetCore.Mvc;
using SistemaContabil.Application.Contracts;
using SistemaContabil.Application.ViewModels;
using SistemaContabil.Core.SharedKernel.Contracts;
using System;
using System.Threading.Tasks;

namespace SistemaContabil.API.Controllers
{
    [Route("api/notafiscal")]
    [ApiController]
    public class NotaFiscalController : SistemaContabilController
    {
        private INotaFiscalAppService _notaFiscalAppService;

        public NotaFiscalController(INotaFiscalAppService notaFiscalAppService,
            INotificationHandler notificationHandler)
            : base(notificationHandler)
        {
            _notaFiscalAppService = notaFiscalAppService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] NotaFiscalViewModel notaFiscalViewModel)
        {
            var novaNotaFiscal = await _notaFiscalAppService.CriarNotaFiscal(notaFiscalViewModel);

            return Response(novaNotaFiscal);
        }

        [HttpPut]
        public void Put(Guid id,[FromBody] NotaFiscalViewModel notaFiscalViewModel)
        {
            _notaFiscalAppService.AtualizarNotaFiscal(id, notaFiscalViewModel);

        }

        [HttpGet]
        public async Task<IActionResult> Get(Guid id)
        {
            var novaNotaFiscal = _notaFiscalAppService.ObterNotaFiscal(id);
            return Ok(novaNotaFiscal);
        }

        [HttpDelete]
        public void Delete(Guid guid)
        {
            _notaFiscalAppService.DetelarNotaFiscal(guid);
        }
    }
}