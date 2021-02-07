using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestioneTest;
namespace Gestione_test
{
    [TestClass]
    public class Operazionetest
    {
        [TestMethod]
        public void TestCalcoloMisterioso()
        {
            int n = 5;
            long valore_aspettato = 240;
            long resp = Gestione.CalcoloMisterioso(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void TestCalcoloMisterioso2()
        {
            int n = 5;
            int valore_aspettato = -360;
            long resp = Gestione.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void TestMisurazioneMisteriosa()
        {
            double[] valori = new double[4] { 4, 6, 7, -9.1 };
            double valore_aspettato = 3;
            double min = Gestione.MisurazioneMisteriosa(valori);
            Assert.AreEqual(valore_aspettato, min);
        }
        [TestMethod]
        public void TestCalcoloMisterioso1()
        {
            int n = 7;
            long valore_aspettato = 10080;
            long resp = Gestione.CalcoloMisterioso(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void TestCalcoloMisterioso22()
        {
            int n = 4;
            int valore_aspettato = -72;
            long resp = Gestione.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
        [TestMethod]
        public void TestMisurazioneMisteriosa1()
        {
            double[] valori = new double[4] { 4, -9.1, 7, 6 };
            double valore_aspettato = 1;
            double min = Gestione.MisurazioneMisteriosa(valori);
            Assert.AreEqual(valore_aspettato, min);
        }

        [TestMethod]
        public void TestMisurazioneMisteriosa2()
        {
            double[] valori = new double[4] { 1, 9.1, -7, 6 };
            double valore_aspettato = 2;
            double min = Gestione.MisurazioneMisteriosa(valori);
            Assert.AreEqual(valore_aspettato, min);
        }
        [TestMethod]
        public void TestCalcoloMisterioso3()
        {
            int n = 7;
            int valore_aspettato = -15120;
            long resp = Gestione.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }
    }
}






