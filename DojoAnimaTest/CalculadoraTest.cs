using DojoAnima01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DojoAnimaTest
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void DeveSomar2()
        {
            var calculadora = new Calculadora();
            var soma = calculadora.Soma(1, 1);

            Assert.AreEqual(2, soma);
        }
    }
}
