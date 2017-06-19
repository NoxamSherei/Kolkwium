using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KolokwiumKaty;

namespace JednostkaTestująca
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestyModoluLiczacegoRozniceKatow()
        {
            KolokwiumKaty.ModulLiczacy target = new KolokwiumKaty.ModulLiczacy(); // TODO: Initialize to an appropriate value
            double numberAlpha = 45; // TODO: Initialize to an appropriate value
            double numberBeta = 90; // TODO: Initialize to an appropriate value
            double expected = 45; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.KatPomiedzy(numberAlpha, numberBeta);
            Assert.AreEqual(expected, actual);
        }
        public void TestyModoluLiczacegoKatAlpha1()
        {
            KolokwiumKaty.ModulLiczacy target = new KolokwiumKaty.ModulLiczacy(); // TODO: Initialize to an appropriate value
            int x = 10; // TODO: Initialize to an appropriate value
            int y = 10; // TODO: Initialize to an appropriate value
            double expected = 45; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Kat(x, y);
            Assert.AreEqual(expected, actual);
        }
        public void TestyModoluLiczacegoKatAlpha2()
        {
            KolokwiumKaty.ModulLiczacy target = new KolokwiumKaty.ModulLiczacy(); // TODO: Initialize to an appropriate value
            int x = 10; // TODO: Initialize to an appropriate value
            int y = 0; // TODO: Initialize to an appropriate value
            double expected =0; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Kat(x, y);
            Assert.AreEqual(expected, actual);
        }
        public void TestyModoluLiczacegoKatBeta()
        {
            KolokwiumKaty.ModulLiczacy target = new KolokwiumKaty.ModulLiczacy(); // TODO: Initialize to an appropriate value
            int x1 = 0; // TODO: Initialize to an appropriate value
            int y1 = 0; // TODO: Initialize to an appropriate value
            int x2 = 10; // TODO: Initialize to an appropriate value
            int y2 = 10; // TODO: Initialize to an appropriate value
            double expected = 45; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Kat(x1, y1,x2,y2);
            Assert.AreEqual(expected, actual);
        }
    }
}
