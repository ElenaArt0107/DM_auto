using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrialUnitTest;


namespace UnitTestProject1
{
    [TestClass]
    public class RekeningTest
    {
        [TestMethod]
        public void HaalBedragVanRekening_GeldigBedrag_BalansWijzigen()
        {
            //Arrange = all variables to test a metod
            decimal beginBalans = 5.8m;
            decimal bedragOmAfhallen = 11.8m;
            decimal verwachtEidbalans = beginBalans - bedragOmAfhallen;

            Rekening newRekening = new Rekening
            { 
                Naam = "B K V",
                Balans = beginBalans
            };

            //act = call the method to be tested

            newRekening.HaalBedragVanRekening(bedragOmAfhallen);

            //assert = compare with expectation
            var result = newRekening.Balans;
            Assert.AreEqual(result, verwachtEidbalans);
        }
    }
}
