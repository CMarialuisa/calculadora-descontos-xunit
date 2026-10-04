using Xunit;
using CalculadoraDescontos.App;

namespace CalculadoraDescontos.Tests
{
    public class DescontoServiceTests
    {
        [Theory]
        [InlineData(2, "BRONZE")]
        [InlineData(7, "PRATA")]
        [InlineData(15, "OURO")]
        public void Teste1_ObterCategoriaCliente(int totalCompras, string resultadoEsperado)
        {
            var service = new DescontoService();
            var resultado = service.ObterCategoriaCliente(totalCompras);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(100, 10, 90)]
        [InlineData(200, 20, 160)]
        [InlineData(50, 0, 50)]
        public void Teste2_CalcularDescontoPorPercentual(int valorOriginal, int percentual, int resultadoEsperado)
        {
            var service = new DescontoService();
            var resultado = service.CalcularDescontoPorPercentual(valorOriginal, percentual);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(20, false, true)]
        [InlineData(16, true, true)]
        [InlineData(17, false, false)]
        public void Teste3_EValidoParaCupom(int idade, bool primeiraCompra, bool resultadoEsperado)
        {
            var service = new DescontoService();
            var resultado = service.EValidoParaCupom(idade, primeiraCompra);
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}