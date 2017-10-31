using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCRepo.Controllers;
using MVCRepo.Repository;
using MVCRepo.Models;

namespace UnitTests
{
    [TestClass]
    public class UnitTestExercise
    {
        [TestMethod]
        public void WhenStoringNewPersoonPersonRetrievedIsTheSame()
        {
            PersoonRepo persoonOpslag = new PersoonRepo();
            PersoonModel persoon = new PersoonModel();

            persoon.BSN = 12440;
            persoon.Naam = "KlaasVaak";
            persoonOpslag.slaOp(persoon);

            Assert.AreEqual(persoonOpslag.laad(12440).Naam, persoon.Naam);
        }
     }
}
