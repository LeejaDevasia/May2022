using FirstTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest.Utilities
{

    public class CommonDriver
    {
        public static IWebDriver driver;
        LoginPage loginPageObj = new LoginPage();

        [OneTimeSetUp]

        public void LoginActions()
        {
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}