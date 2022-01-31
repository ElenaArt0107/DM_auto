using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using UnitTest.stub;
using System;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTestAutoService
    {

        [TestMethod]
        public void GetAuto_BestaandeAutoId_GeeftEenWagenTerug()
        {
            //Arrange
            IAutoRepository autoRepo = new AutoRepositoryStub();

            IAutoService autoService = new AutoService(autoRepo);
            
            int idToGetBack = 2;
            string verwachteKleur = "white";
            //Act
            Auto auto = autoService.GetAuto(idToGetBack);
            //Assert
            Assert.IsNotNull(auto);
            Assert.AreEqual(verwachteKleur, auto.Kleur);
        }

        [TestMethod]
        public void GetAuto_OnbestaandeAutoId_GeeftEenNullTerug()
        {
            //Arrange
            IAutoRepository autoRepo = new AutoRepositoryStub();
            IAutoService autoService = new AutoService(autoRepo);
            int idToGetBack = 1;
            //Act
            Auto auto = autoService.GetAuto(idToGetBack);
            //Assert
            Assert.IsNull(auto);
        }

        [TestMethod]
        public void GetAutos_HaalLijstOpMeAutos_AantalWagensInLijstZijnCorrect()
        {
            //Arrange
            IAutoRepository autoRepo = new AutoRepositoryStub();
            IAutoService autoService = new AutoService(autoRepo);
            //Act
            var verwachteAantalWagens = 2;
            List<Auto> allAutos = autoService.GetAutos();
            //Assert
            Assert.AreEqual(verwachteAantalWagens, allAutos.Count);
        }

        [TestMethod]
        public void GetPrijsVanAlleAutos_LijstWaarvanAllePrijzenBekendZijn_CorrecteSomVanAlleAutoPrijzen()
        {
            //Arrange
            IAutoRepository autoRepo = new AutoRepositoryStub();
            IAutoService autoService = new AutoService(autoRepo);
            //Act
            var verwachteAllePrijzen = 50000.10m;
            //Assert
            Assert.AreEqual(verwachteAllePrijzen, autoService.GetPrijsVanAlleAutos());
        }
    }
}
