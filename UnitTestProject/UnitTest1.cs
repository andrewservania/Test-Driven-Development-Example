using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopedApplicationExample;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// Test om te kijke of getallen goed opgeteld worden.
        /// Test-Driven Development (TDD):
        /// http://agiledata.org/essays/tdd.html
        /// </summary>
        [TestMethod]
        public void GetalKanOpgeteldWorden()
        {
            //Geef aan het verwachte resultaat
            int expectedResult = 7;

            //Maak een instantie aan van de opteller class
            Opteller opteller = new Opteller();

            //Voor een simpele berekening uit om de gemaakt methode te testen.
            int actualResult = opteller.getallenOptellen(2, 5);

            //Laat de unit test project samen met de Unit Test Framework zelf checken
            //of de uiteindelijke resultaat hetzelfde is als de verwachte resultaat.
            //Als dat niet het geval is, geef aan in de Test Explorer aan met een
            //simpele bericht.
            Assert.AreEqual(expectedResult, actualResult,
                "Getallen worden niet goed opgeteld. De antwoord is niet het verwachte resultaat");


        }
    }
}
