
// See https://aka.ms/new-console-template for more information
using FirstTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


//open chrome browser
IWebDriver driver = new ChromeDriver();

LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginSteps(driver);
HomePage homePageObj = new HomePage();
homePageObj.GoToTMPage(driver);
TMPage TMPageobj = new TMPage();
TMPageobj.CreateTM(driver);
TMPageobj.EditTM(driver);
TMPageobj.DeleteTM(driver);