using Microsoft.VisualStudio.TestTools.UnitTesting;
using aspnetcorewebapp;

namespace aspnetcorewebapp.test
{
    [TestClass]
    public class CalculadoraUnitTest
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.Somar(10, 5);

            Assert.AreEqual(15, resultado);
        }

        [TestMethod]
        public void SomarTresNumeros()
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.Somar(10, 5, 5);

            Assert.AreEqual(20, resultado);
        }

        [TestMethod]
        public void SubtrairDoisNumeros()
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.Subtrair(10, 5);

            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void DividirDoisNumeros()
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.Dividir(10, 2);

            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void MultiplicarDoisNumeros()
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.Multiplicar(10, 2);

            Assert.AreEqual(20, resultado);
        }
    }
}