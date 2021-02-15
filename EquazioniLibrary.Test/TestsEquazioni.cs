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
    }
}
