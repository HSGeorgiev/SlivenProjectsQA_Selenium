﻿using SlivenProjectsTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Tests
{
    internal class PreEUFundsPageTests  : BaseTests
    {

        

        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            var preEUFundsPage = new PreEUFundsPage(driver);
            preEUFundsPage.GoToTargetPage(preEUFundsPage.pageUrl);
            bool[] topMenuChecks = preEUFundsPage.menuLinksTextsCheck(preEUFundsPage.topMenuItems, preEUFundsPage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {preEUFundsPage.topMenuTexts[i]} " +
                    $"should be {preEUFundsPage.topMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            var preEUFundsPage = new PreEUFundsPage(driver);
            preEUFundsPage.GoToTargetPage(preEUFundsPage.pageUrl);
            bool[] topMenuChecks = preEUFundsPage.menuLinksTextsCheck(preEUFundsPage.inRegisterMenuItems, preEUFundsPage.inRegisterMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"InRegister menu item {preEUFundsPage.inRegisterMenuTexts[i]} " +
                    $"should be {preEUFundsPage.inRegisterMenuTexts[i]}, but is not");
            }
        }

    }
}
