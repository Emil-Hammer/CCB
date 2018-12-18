using System;
using CCB.Data.Domain;
using CCB.ViewModels.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.AppContainer;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [UITestMethod]
        public void TestMethod1()
        {
            //Oprettelse af Projekt objekt som normalt vil blive oprettet i viewet.
            Project prj = new Project();
            prj.Address = "Test Adresse";
            prj.IsFinished = false;
            prj.Deadline = new DateTimeOffset(1991, 1, 30, 0, 0, 0, TimeSpan.Zero);
            prj.Description = "Test description";
            prj.Id = 1;
            prj.Start = new DateTimeOffset(1990, 12, 19, 0, 0, 0, TimeSpan.Zero);
            prj.Telephone = "29381230";

            //Oprettelse af ProjectDataViewModel objekt som tager projekt objektet som parameter.
            ProjectDataViewModel PDVM = new ProjectDataViewModel(prj);

            //Så tester vi om metoden ColorToNumber returnerer den korrekte værdi 0 baseret på det Projekt objekt vi skabte tidligere
            Assert.AreEqual(PDVM.ColorToNumber, 0);
        }
    }
}
