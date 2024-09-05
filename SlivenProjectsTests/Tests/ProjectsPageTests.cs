﻿using SlivenProjectsTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Tests
{
    internal class ProjectsPageTests : BaseTests
    {

        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            var projectsPage = new ProjectsPage(driver);
            projectsPage.GoToTargetPage(projectsPage.pageUrl);
            bool[] topMenuChecks = projectsPage.menuLinksTextsCheck(projectsPage.topMenuItems, projectsPage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {projectsPage.topMenuTexts[i]} " +
                    $"should be {projectsPage.topMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            var projectsPage = new ProjectsPage(driver);
            projectsPage.GoToTargetPage(projectsPage.pageUrl);
            bool[] inRegisterMenuChecks = projectsPage.menuLinksTextsCheck(projectsPage.inRegisterMenuItems, projectsPage.inRegisterMenuTexts);

            for (int i = 0; i < inRegisterMenuChecks.Length; i++)
            {
                Assert.IsTrue(inRegisterMenuChecks[i], $"InRegister menu item {projectsPage.inRegisterMenuTexts[i]} " +
                    $"should be {projectsPage.inRegisterMenuTexts[i]}, but is not");
            }
        }
    }
}
