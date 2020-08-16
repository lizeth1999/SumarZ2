using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sumar.Controllers;

namespace UnitTestSumar1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            //Arrange
            SumaController sumaController = new SumaController();
            int a = 1;
            int b = 5;
            int esperado = 6;
            //ACT
            int resultado = sumaController.Add(a, b);
            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
