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
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void LanzarExcepcionTest()
        {
            Logic.LanzarExcepcion();
        }

        [TestMethod()]
        [ExpectedException(typeof(ExcepcionesPersonalizadas))]
        public void LanzarExcepcionPersonalizadaTest()
        {
            Logic.LanzarExcepcionPersonalizada();
        }
    }
}