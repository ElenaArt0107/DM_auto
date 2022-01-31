using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ConsoleApp1;
using System.Collections.Generic;

namespace AutoProjectTestMocking
{
    [TestClass]
    public class AutoServiceTestWithMoq
    {
        private IAutoRepository _autoRepo;
        private IAutoService _autoService;

        [TestInitialize]
        public void TestInitializer()
        {
            Mock<IAutoRepository> autoRepoFactory = new Mock<IAutoRepository>();
            _autoRepo = autoRepoFactory.Object;

           autoRepoFactory.Setup(autoRepo => autoRepo.GetAuto(3))
                .Returns(new Auto
                {
                    Id = 3,
                    Kleur = "rod",
                    Prijs = 6000m
                });

            autoRepoFactory.Setup(autoRepo => autoRepo.GetAutos())
                .Returns(new List<Auto> ()
                {
                    new Auto
                    {
                        Id = 3,
                        Kleur = "rod",
                        Prijs = 6000m
                    },
                    new Auto
                    {
                        Id = 4,
                        Kleur = "grijs",
                        Prijs = 6000m
                    }
                });
            _autoService = new AutoService(_autoRepo);
        }

        [TestMethod]
        public void GetAuto_BestaandeAutoId_GeeftEenWagenTerug()
        {
            //Arrange
            int idToGetBack = 3;
            string verwachteKleur = "rod";
            //Act
            Auto auto = _autoService.GetAuto(idToGetBack);
            //Assert
            Assert.IsNotNull(auto);
            Assert.AreEqual(verwachteKleur, auto.Kleur);
        }

        [TestMethod]
        public void GetAuto_OnbestaandeAutoId_GeeftEenNullTerug()
        {
            //Arrange
            //TestInitializer()
            int idToGetBack = 1;
            //Act
            Auto auto = _autoService.GetAuto(idToGetBack);
            //Assert
            Assert.IsNull(auto);
        }

        [TestMethod]
        public void GetAutos_HaalLijstOpMeAutos_AantalWagensInLijstZijnCorrect()
        {
            //Arrange
            //TestInitializer()
            //Act
            var verwachteAantalWagens = 2;
            List<Auto> allAutos = _autoService.GetAutos();
            //Assert
            Assert.AreEqual(verwachteAantalWagens, allAutos.Count);
        }

        [TestMethod]
        public void GetPrijsVanAlleAutos_LijstWaarvanAllePrijzenBekendZijn_CorrecteSomVanAlleAutoPrijzen()
        {
            //Arrange
            //TestInitializer()

            //Act
            var verwachteAllePrijzen = 12000m;
            //Assert
            Assert.AreEqual(verwachteAllePrijzen, _autoService.GetPrijsVanAlleAutos());
        }
    }
}
