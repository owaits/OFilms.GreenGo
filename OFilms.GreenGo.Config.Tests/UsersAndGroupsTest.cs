using OFilms.GreenGo.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Config.Tests
{
    [TestClass]
    public class UsersAndGroupsTest
    {
        [TestMethod]
        public void CreateUserAndGroup()
        {
            var project = new GreenGoProject("Test Project 1");
            project.Settings.Colors.Free.Rate = LedRate.HalfSecondPulse;

            project.Users.Add(new User()
            {
                MyId = "1",
                Name = "Test User 1",
                Status = GreenGoStatus.Enabled
            });

            project.Groups.Add(new Group()
            {
                MyId = "2",
                Name = "Test Group 1",
                Status = Project.GreenGoStatus.Disabled
            });

            project.Users.First().Channels.Add(
                new Project.Channel()
                {
                    MyId = "1",
                    Status = GreenGoStatus.Enabled,
                }
            );

            project.Users.First().Channels[0].Assign.CreateLink(project.Groups[0]);

            project.Save("TestProject1.gg5");
        }
    }
}
