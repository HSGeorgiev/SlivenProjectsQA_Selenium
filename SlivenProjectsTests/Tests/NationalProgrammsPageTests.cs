﻿using SlivenProjectsTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Tests
{
    internal class NationalProgrammsPageTests : BaseTests
    {
        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            var nationalProgrammsPage = new NationalProgrammsPage(driver);
            nationalProgrammsPage.GoToTargetPage(nationalProgrammsPage.pageUrl);
            bool[] topMenuChecks = nationalProgrammsPage.menuLinksTextsCheck(nationalProgrammsPage.topMenuItems, nationalProgrammsPage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {nationalProgrammsPage.topMenuTexts[i]} " +
                    $"should be {nationalProgrammsPage.topMenuTexts[i]}, but is not");
            }
        }

 

    }
}
