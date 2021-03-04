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
        [TestMethod]
        public void testIsDegree2()
        {
            double a = 0;
            bool valoreaspettato = false;
            bool controllo = Equazioni.IsDetermined(a);
            Assert.AreEqual(valoreaspettato, controllo);
        }
       [TestMethod]
        public void testDelta()
        {
            double a = 0;
            double b = 3;
            double c = 12;
            double  valoreaspettato = double.NaN;
            double controllo = Equazioni.Delta(a,b,c);
            Assert.AreEqual(valoreaspettato, controllo);
        }
        [TestMethod]
        public void testDelta2()
        {
            double a = 1;
            double b = 5;
            double c = 6;
            double valoreaspettato = 1;
            double controllo = Equazioni.Delta(a, b, c);
            Assert.AreEqual(valoreaspettato, controllo);
        }
        [TestMethod]
        public void testEquazione1()
        {
            double a = 1;
            double b = 5;
            double c = 6;
            string valoreaspettato = $"due soluzioni che sono {-2} e {-3}"; 
            string controllo = Equazioni.RisoluzioneEquazioneSecondoGrado(a, b, c);
            Assert.AreEqual(valoreaspettato, controllo);
        }
        [TestMethod]
        public void testEquazione2()
        {
            double a = 12;
            double b = 12;
            double c = 3;
            double risultato = -1.0/ 2;
            string valoreaspettato = $"una sola soluzione che è {risultato}";
            string controllo = Equazioni.RisoluzioneEquazioneSecondoGrado(a, b, c);
            Assert.AreEqual(valoreaspettato, controllo);
        }
        [TestMethod]
        public void testEquazione3()
        {
            double a = 0;
            double b = 5;
            double c = 6;
            string valoreaspettato = "non eseguibile";
            string controllo = Equazioni.RisoluzioneEquazioneSecondoGrado(a, b, c);
            Assert.AreEqual(valoreaspettato, controllo);
        }
        [TestMethod]
        public void testEquazione4()
        {
            double a = 2;
            double b = 0;
            double c = 1;
            string valoreaspettato = $"nessuna soluzione, perché è impossibile";
            string controllo = Equazioni.RisoluzioneEquazioneSecondoGrado(a, b, c);
            Assert.AreEqual(valoreaspettato, controllo);
        }
        [TestMethod]
        public void testEquazionePrimoGrado()
        {
            double a = 0;
            double b = 2;
            string valoreaspettato = "l'equazione è IMPOSSIBILE";
            string controllo = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valoreaspettato, controllo);
        }
        [TestMethod]
        public void testEquazionePrimoGrado2()
        {
            double a = -2;
            double b = 4;
            string valoreaspettato = $"la soluzione dell'equazione è {-2}";
            string controllo = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valoreaspettato, controllo);
        }
        [TestMethod]
        public void testEquazionePrimoGrado3()
        {
            double a = 0;
            double b = 0;         
            string valoreaspettato = "l'equazione è INDETERMINATA";
            string controllo = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valoreaspettato, controllo);
        }
    }
}
