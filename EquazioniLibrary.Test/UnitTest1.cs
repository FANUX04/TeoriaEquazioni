using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;
namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 2;
            bool valoreaspettato = true;
            bool controllo = Equazioni.IsDetermined(a);
            Assert.AreEqual(valoreaspettato, controllo);

        }
    }
}
