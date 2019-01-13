using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaContabil.Core.Aggregates.Fiscal.Entities;
using System;

namespace SistemaContabil.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_NumeroNf()
        {
            var notaFiscal = new NotaFiscalEntity
            {
                CnpjDestinatarioNf = "00909909090",
                DataNf = DateTime.Now,
                ValorTotal = -100

            };

            var result = notaFiscal.IsValid();

            Assert.AreEqual(true, result, "o número da nota fiscal tem que se informado");
        }

        [TestMethod]
        public void TestMethod_ValorTotal()
        {
            var notaFiscal = new NotaFiscalEntity
            {
                CnpjDestinatarioNf = "00909909090",
                DataNf = DateTime.Now,
                NumeroNf = 1,
                ValorTotal = -100

            };

            var result = notaFiscal.IsValid();

            Assert.AreEqual(true, result, "O Valor tem que ser maior que zero");
        }
    }
}
