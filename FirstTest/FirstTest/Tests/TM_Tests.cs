
// See https://aka.ms/new-console-template for more information
using FirstTest.Pages;
using FirstTest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace FirstTest
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {
        //open chrome browser
        TMPage tmPageObj = new TMPage();
        HomePage homePageObj = new HomePage();
        [Test]
        public void CreateTM()
        {
            homePageObj.GoToTMPage(driver);
            tmPageObj.CreateTM(driver);

        }
        [Test]
        public void EditTM()
        {
            homePageObj.GoToTMPage(driver);
            tmPageObj.EditTM(driver, "dummy1","dummy2","dummy3");

        }
        [Test]
        public void DeleteTM()
        {
            homePageObj.GoToTMPage(driver);
            tmPageObj.DeleteTM(driver);
        }
        //[TearDown]
        //public void CloseTestRun()
        //{
        //    driver.Close();
        //}

    }
}
