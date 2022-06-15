using FirstTest.Pages;
using FirstTest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest.Tests
{
    public class employeeTests
    {
        [TestFixture]
        public class TM_Tests : CommonDriver
        {
            //open chrome browser
            //HomePage homePageObj = new HomePage();
            //employeePage employeePageObj = new employeePage();

            [SetUp]
            public void LoginActions()
            {
                driver = new ChromeDriver();

                LoginPage loginPageObj = new LoginPage();
                loginPageObj.LoginSteps(driver);
                HomePage homePageObj = new HomePage();
                homePageObj.GoToEmployeePage(driver);

            }
            [Test]
            public void CreateEmployee()
            {
                employeeTest employeePageobj = new employeeTest();
               employeePageobj.createEmployeeCheck(driver);

            }
            [Test]
            public void EditEmployee()
            {
                employeePage employeePageobj = new employeePage();
                employeePageobj.EditEmployee(driver);

            }
            [Test]
            public void DeleteEmployee()
            {
                employeePage employeePageobj = new employeePage();
                employeePageobj.DeleteEmployee(driver);
            }

            //public void employeeOperations(IWebDriver driver)
            //{
            //    // IWebDriver driver = new ChromeDriver();
            //    LoginPage loginPageObj = new LoginPage();
            //    loginPageObj.LoginSteps(driver);
            //    HomePage homePageObj = new HomePage();
            //    homePageObj.GoToEmployeePage(driver);
            //    employeePage employeePageObj = new employeePage();
            //    employeePageObj.CreateEmployee(driver);
            //    employeePageObj.EditEmployee(driver);
            //    employeePageObj.DeleteEmployee(driver);

            //}
        }
    }
}
