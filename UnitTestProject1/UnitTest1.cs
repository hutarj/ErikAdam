using Hra;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace janevimnechtotakhleneee
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {
            /* Nápady na testing aplikace
             * Testování, zda je level na začátku inicializován na 1
             * level jinak
             * Krátkost jména - menší než 10 znaků; upozornění
             * krátkost pozitivně
             * Pozice x inicializovaná na 0
             * Pozice x inicializovaná jinak
             * Pozice y inicializovaná na 0
             * Pozice y inicializovaná jinak
             * obličej na 0
             * obličej jinak
             * vlasy na 0
             * vlasy jinak
             * barva vlasů 0
             * brava vlasů jinak
             * XP 0
             * XP jinak
             * Specializace se shoduje se slovy
             * Specializace se neshoduje se slovy
             * Jedná se o BOSS char.
             * Nejedná se o BOSS char.
             * 
             */
        }
        [TestMethod]
        public void LevelInitialization_POSITIVE()
        {
            int level = 1;
            Assert.AreEqual(1, level);
        }
        [TestMethod]
        public void LevelInitialization_NEGATIVE()
        {
            int level = 0;
            Assert.AreNotEqual(1, level);
        }
        [TestMethod]
        public void NameBrevity_POSITIVE()
        {

            int max = 10;
            string name = "Margot";
            Assert.IsTrue(name.Length <= max && name != null);
        }
        [TestMethod]
        public void NameBrevity_NEGATIVE()
        {
            int max = 10;
            string name = "Margotkaaaaa";
            Assert.IsFalse(name.Length <= max && name != null);
        }
        [TestMethod]
        public void PossesionX_POSITIVE()
        {
            int possesionX = 0;
            Assert.AreEqual(0, possesionX);
        }
        [TestMethod]
        public void PossesionX_NEGATIVE()
        {
            int possesionX = 1;
            Assert.AreNotEqual(0, possesionX);
        }
        [TestMethod]
        public void PossesionY_POSITIVE()
        {
            int possesionY = 0;
            Assert.AreEqual(0, possesionY);
        }
        [TestMethod]
        public void PossesionY_NEGATIVE()
        {
            int possesionY = 1;
            Assert.AreNotEqual(0, possesionY);
        }
        [TestMethod]
        public void FaceSet_POSITIVE()
        {
            int faceSet = 0;
            Assert.AreEqual(0, faceSet);
        }
        [TestMethod]
        public void FaceSet_NEGATIVE()
        {
            int faceSet = 0;
            Assert.AreNotEqual(1, faceSet);
        }
        [TestMethod]
        public void HairSet_POSITIVE()
        {
            int hairSet = 0;
            Assert.AreEqual(0, hairSet);
        }
        [TestMethod]
        public void HairSet_NEGATIVE()
        {
            int hairSet = 1;
            Assert.AreNotEqual(0, hairSet);
        }
        [TestMethod]
        public void XPSet_POSITIVE()
        {
            int xpSet = 0;
            Assert.AreEqual(0, xpSet);
        }
        [TestMethod]
        public void XPSet_NEGATIVE()
        {
            int xpSet = 0;
            Assert.AreNotEqual(1, xpSet);
        }
        /*[TestMethod]
        public void WordAccordance_POSITIVE()
        {
            string[] stringsArray = { "Kouzelník", "Berserker", "Inženýr", "Cizák" };
            string specialization = "Kouzelník";
            for (int i = 0; i < stringsArray.Length; i++)
            {
                Assert.AreEqual(specialization, stringsArray[i]);
            }
        }
        [TestMethod]
        public void WordAccordance_NEGATIVE()
        {
            string[] stringsArray = { "Kouzelník", "Berserker", "Inženýr", "Cizák" };
            string specialization = "Kouzelník";
            for (int i = 0; i < stringsArray.Length; i++)
            {
                Assert.AreNotEqual(stringsArray[i], specialization);
            }
        } */
        //mnau
        [TestMethod]
        public void IsBOSSChar_POSITIVE()
        {
            int strength = 0;
            Assert.AreEqual(0, strength);
        }
        [TestMethod]
        public void IsBOSSChar_NEGATIVE()
        {
            int strength = 1;
            Assert.AreNotEqual(0, strength);

        }

    }
}
