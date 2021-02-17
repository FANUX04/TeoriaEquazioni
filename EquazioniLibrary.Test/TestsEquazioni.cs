using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;
namespace EquazioniLibrary.Test
{
    [TestClass]
    public class TestsEquazioni
    {
        [TestMethod]
        public void TestEquazionePrimoGradoDeterminata()
        {
            double a = 2;
            bool valoreaspettato =true;
            bool controllo = Equazioni.IsDetermined(a);
            Assert.AreEqual(valoreaspettato, controllo);

        }
        [TestMethod]
        public void testIsInconsisted()
        {
            double a = 0;
            double b = 12;
            bool valoreaspettato = true;
            bool controllo = Equazioni.IsInconsisted(a,b);
            Assert.AreEqual(valoreaspettato, controllo);

        }
    }
}
