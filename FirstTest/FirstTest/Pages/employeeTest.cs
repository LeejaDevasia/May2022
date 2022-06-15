using FirstTest.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest.Pages
{
    internal class employeeTest
    {
        public void createEmployeeCheck(IWebDriver driver)
        {
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNew.Click();
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id='Name']", 5);
            ////*[@id="container"]/p/a
            //selecting type code
            IWebElement Name = driver.FindElement(By.XPath("//*[@id='Name']"));
            Name.SendKeys("Mary");
            IWebElement UserName = driver.FindElement(By.XPath("//*[@id='Username']"));
            UserName.SendKeys("reet1");
            IWebElement Contactbutton = driver.FindElement(By.Id("EditContactButton"));
            Contactbutton.Click();
            //opening new frame to add contact details
            driver.SwitchTo().Frame(0);
            //enter first name
            driver.FindElement(By.XPath("//*[@id='FirstName']")).SendKeys("Mary");
            //enter last name
            driver.FindElement(By.XPath("//*[@id='LastName']")).SendKeys("Nelson");
            //enter preffered name
            driver.FindElement(By.XPath("//*[@id='PreferedName']")).SendKeys("Hai");
            //enter phone number
            driver.FindElement(By.XPath("//*[@id='Phone']")).SendKeys("0222552242");
            //enter mobile number
            driver.FindElement(By.XPath("//*[@id='Mobile']")).SendKeys("0225414565");
            //enter email
            driver.FindElement(By.XPath("//*[@id='email']")).SendKeys("marynelson@gmail.com");
            //enter fax
            driver.FindElement(By.XPath("//*[@id='Fax']")).SendKeys("03828393");
            //enter address
            driver.FindElement(By.XPath("//*[@id='Street']")).SendKeys("32 rose road");
            driver.FindElement(By.XPath("//*[@id='City']")).SendKeys("Manukau");
            driver.FindElement(By.XPath("//*[@id='Postcode']")).SendKeys("2849");
            driver.FindElement(By.XPath("//*[@id='Country']")).SendKeys("New Zealand");
            driver.FindElement(By.XPath("//*[@id='submitButton']")).Click();

            //get back to original form window
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);

            driver.FindElement(By.Id("Password")).SendKeys("Hai@23");
            driver.FindElement(By.Id("RetypePassword")).SendKeys("Hai@23");
            driver.FindElement(By.Id("IsAdmin")).Click();
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(3500);
            driver.FindElement(By.XPath("//*[@id='container']/div/a")).Click();
            Thread.Sleep(2000);


            driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span")).Click();

        }
    }
}
