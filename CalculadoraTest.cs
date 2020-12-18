using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matemat.Logica;
using System;

namespace Matemat.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        [TestMethod]
        public void Suma2Numeros()
        {
            // arrange -> prepación
            var numero1 = 7;
            var numero2 = 10;
            var esperado = 17;


            //act -> ejecucion
            var calculadora = new Calculadora();
            var resultado = calculadora.Sumar(numero1, numero2);


            //assert -> esta es la verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [TestMethod]

        public void Dividir2Numeros()
        {
            //arrange
            var numero1 = 30;
            var numero2 = 3;
            var espero = 10;

            //act 
            var miCalculadora = new Calculadora();
            var resul = miCalculadora.Dividir(numero1, numero2);

            //assert -> esta es la verificacion
            Assert.AreEqual(espero, resul);

        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirPara0()
        {
            //arrange
            var num1 = 40;
            var num2 = 0;

            //act 
            var calculadora = new Calculadora();
            var resultado = calculadora.Dividir(num1, num2);

            //assert -> esta es la verificacion
            Assert.IsTrue(double.IsInfinity(resultado));

        }
        [TestMethod]

        public void DividirResulEntero()
        {
            //arrange
            var nu1 = 20;
            var nu2 = 2;
            var esperores = 10;

            //act 
            var calculadora = new Calculadora();
            var resul = calculadora.Dividir(nu1, nu2);

            //assert -> esta es la verificacion
            Assert.AreEqual(esperores, resul);


        }
        [TestMethod]
        public void DividisionConRespDecimal()
        {
            //arrange
            var number1 = 59;
            var number2 = 4;
            var esperodou = 14.75;

            //act 
            var calculadora = new Calculadora();
            var resul = calculadora.Dividir(number1, number2);

            //assert -> esta es la verificacion
            Assert.AreEqual(esperodou, resul);

        }
        [TestMethod]
        public void ObtenerUnNumeroConDosDecimal()
        {
            // Arrange -> Preparacion
            var numeroPiCon5Decimales = 3.14159;
            var numeroPiCon2Decimales = 3.14;

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultado = calculadora.TomarDosDecimales(numeroPiCon5Decimales);

            // assert -> Verificación
            Assert.AreEqual(numeroPiCon2Decimales, resultado);

        }

        [TestMethod]
        public void ObtenerUnNumeroCon3Decimal()
        {
            // Arrange -> Preparacion
            var numeroPiConDecimales = 3.141592653589793238462643383;
            var numeroPiCon3Decimales = 3.141;

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultado = calculadora.TomarTresDecimales(numeroPiConDecimales);

            // assert -> Verificación
            Assert.AreEqual(numeroPiCon3Decimales, resultado);

        }
        [TestMethod]
        public void ObteneNDecimales()
        {
            // Arrange -> Preparacion
            var numeroAureo = 1.61803398874988;
            var numeroDeDecimales = 5;
            var esperado = 1.61803;

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultado = calculadora.TomarDecimales(numeroAureo, numeroDeDecimales);

            // assert -> Verificación
            Assert.AreEqual(esperado, resultado);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ObteneNDecimalesNegativos()
        {
            // Arrange -> Preparacion
            var numeroAureo = 1.61803398874988;
            var numeroDeDecimales = -5;

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            _ = calculadora.TomarDecimales(numeroAureo, numeroDeDecimales);


        }

        [TestMethod]
        [DataSource(@"Provider=Microsoft.SqlServerCe.Client.4.0; Data Source=C:\Data\MathsData.sdf;", "Numbers")]
        public void AumentarEntero()
        {

            var numeroEntero1 = 2;
            // int x = Convert.ToInt32(TestContext.DataRow["FirstNumber"]);
            var numeroEntero2 = -3;
            var esperado = -1;

            var calculadora = new Calculadora();
            int resultado = calculadora.AumentarEntero(numeroEntero1, numeroEntero2);


            Assert.AreEqual(esperado, resultado);

        }

    }
}
