using System;

namespace SistemaContabil.Application.ViewModels
{
    public class NotaFiscalViewModel
    {
        //public Guid Id { get; set; }
        public int NumeroNf { get; set; }

        public decimal ValorTotal { get; set; }

        public DateTime DataNf { get; set; }

        public string CnpjEmissorNf { get; set; }

        public string CnpjDestinatarioNf { get; set; }
    }
}
