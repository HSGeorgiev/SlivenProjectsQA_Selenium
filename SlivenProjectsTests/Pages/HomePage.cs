﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Pages
{
    internal class HomePage : BasePage
    {

        // Descript the element and logic on the Home page,
        // excluding base elements, common for all pages.
        public HomePage(IWebDriver driver) : base(driver)
        {
            
        }

        
        public new string pageUrl => BASE_URL + "/";

        
    }
}
