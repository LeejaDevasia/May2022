using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            // open administration tab  
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();
            //navigate to time and material

            IWebElement timeAndMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterial.Click();

        }

        public void GoToEmployeePage(IWebDriver driver)
        {
            // open administration tab  
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();
            //navigate to time and material

            IWebElement employee = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employee.Click();

        }
    }
}
