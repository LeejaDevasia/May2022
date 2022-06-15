using FirstTest.Pages;
using FirstTest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace FirstTest.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions: CommonDriver
    {
        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            // open chrome browser
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [When(@"I navigate to time and material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I create time and material record")]
        public void WhenICreateTimeAndMaterialRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMPage tmPageObj = new TMPage();

            string newCode = tmPageObj.GetNewCode(driver);
            string newTypeCode = tmPageObj.GetNewTypeCode(driver);
            string newDescription = tmPageObj.GetNewDescription(driver);
            string newPrice = tmPageObj.GetnewPrice(driver);

            Assert.That(newCode == "CD_1000", "Actual code and expected code do not match.");
            Assert.That(newTypeCode == "M", "Actual type code and expected type code do not match.");
            Assert.That(newDescription == "this is newly created element", "Actual description and expected description do not match.");
            Assert.That(newPrice == "$1,050.00", "Actual price and expected price do not match.");

        }

        [When(@"I update '([^']*)','([^']*)','([^']*)' on an existing time and material record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string p0, string p1, string p2)
        {
            TMPage TMPageobj = new TMPage();
            TMPageobj.EditTM(driver, p0, p1, p2);

        }

        [Then(@"the record should have updated '([^']*)','([^']*)','([^']*)'")]
        public void ThenTheRecordShouldHaveUpdated(string p0, string p1, string p2)
        {
            TMPage TMPageobj = new TMPage();

            string EditedCode = TMPageobj.GetEditedCode(driver);
            string EditedDescription = TMPageobj.GetEditedDescription(driver);
            string EditedPrice = TMPageobj.GetEditedPrice(driver);

            Assert.That(EditedDescription == p0, "Actual description and expected description do not match.");
            Assert.That(EditedCode == p1, "Actual code and expected code do not match.");
            Assert.That(EditedPrice == p2, "Actual price and expected price do not match.");

        }
        [When(@"I deleted an existing time and material record")]
        public void WhenIDeletedAnExistingTimeAndMaterialRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);


        }

        [Then(@"the record should have deleted succesfully")]
        public void ThenTheRecordShouldHaveDeletedSuccesfully()
        {
            TMPage tmPageObj = new TMPage();
            string deletedCode = tmPageObj.deletedCode(driver);
            Assert.That(deletedCode != "003", "Time and material record hasn't been deleted succesfully.");

        }


    }
}
