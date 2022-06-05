using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
           //maximise the window
            driver.Manage().Window.Maximize();
            //launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2fTimeMaterial");
            //identify username textbox
            IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
            //enter valid username to username textbox
            usernameTextBox.SendKeys("hari");
            //identify password textbox
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            //enter valid username to username textbox
            passwordTextBox.SendKeys("123123");
            //Click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(1000);
            //check whether successfully loggedin
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Successfully logged in");
            }
            else
            {
                Console.WriteLine("Unfortunately not logged in");
            }
        }

    }
}
