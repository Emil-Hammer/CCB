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
            Project prj = new Project();
            prj.Address = "Test Adresse";
            prj.IsFinished = false;
            prj.Deadline = new DateTimeOffset(1991, 1, 30, 0, 0, 0, TimeSpan.Zero);
            prj.Description = "Test description";
            prj.Id = 1;
            prj.Start = new DateTimeOffset(1990, 12, 19, 0, 0, 0, TimeSpan.Zero);
            prj.Telephone = "29381230";
            ProjectDataViewModel PDVM = new ProjectDataViewModel(prj);

            //Testing if the project obj we just created returns a 0 which means the deadline of the project is overdue.
            Assert.AreEqual(PDVM.ColorToNumber, 0);
        }
    }
}
