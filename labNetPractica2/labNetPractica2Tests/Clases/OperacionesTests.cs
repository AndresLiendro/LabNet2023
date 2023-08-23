using Microsoft.VisualStudio.TestTools.UnitTesting;
using labNetPractica2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.Clases.Tests
{
    [TestClass()]
    public class OperacionesTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionEj1Test()
        {

            decimal dividendo = 20;
            Operaciones.DivisionEj1(dividendo);
        }

        [TestMethod()]
        public void DivisionEj2Test()
        {
            //Arrange
            decimal dividendo = 10;
            decimal divisor = 2;
            decimal resultadoEsperado = 5;

            //Act
            decimal resultadoOperacion = Operaciones.DivisionEj2(dividendo, divisor);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoOperacion);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionEj2NegativoTest()
        {
            decimal dividendo = 10;
            decimal divisor = 0;

            Operaciones.DivisionEj2(dividendo, divisor);
        }
    }
}