using OFilms.GreenGo.Project;

namespace OFilms.GreenGo.Config.Tests
{
    [TestClass]
    public class LoadAndSaveTests
    {
        [TestMethod]
        [DeploymentItem("TestFiles/OFilms Default v3 10.11.a.gg5")]
        public void LoadTest()
        {
            var project = GreenGoProject.Load("OFilms Default v3 10.11.a.gg5");
            Assert.AreEqual(33,project.Users.Count);
            Assert.AreEqual(14, project.Groups.Count);

            Assert.AreEqual("OFilms Default 10.11.a", project.Settings.Name);
            Assert.AreEqual("Director 1", project.Users.OrderBy(u=>u.MyId).First().Name);
            Assert.AreEqual("Tech", project.Groups.OrderBy(u => u.MyId).First().Name);
        }

        [TestMethod]
        [DeploymentItem("TestFiles/OFilms Default v3 10.11.a.gg5")]
        public void LoadSaveComparisonTest()
        {
            var project = GreenGoProject.Load("OFilms Default v3 10.11.a.gg5");
            project.Save("CompareProject.gg5");
        }

        [TestMethod]
        [DeploymentItem("TestFiles/Bede's GreenGo.gg5")]
        public void LoadSaveComparisonTest2()
        {
            var project = GreenGoProject.Load("Bede's GreenGo.gg5");
            project.Save("CompareProject2.gg5");
        }
    }
}