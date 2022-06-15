using FirstTest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest.Pages
{
    public class employeePage
    {
        private object promptAlert;

        public void CreateEmployee(IWebDriver driver)
        {
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNew.Click();
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id='Name']", 5);
            ////*[@id="container"]/p/a
            //selecting type code
            IWebElement Name = driver.FindElement(By.XPath("//*[@id='Name']"));
            Name.SendKeys("Mary");
            IWebElement UserName = driver.FindElement(By.XPath("//*[@id='Username']"));
            UserName.SendKeys("mary");
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


////---------------------------------------------------------------------------------------------------------//

            //Send text to Password textbox
            driver.FindElement(By.Id("Password")).SendKeys("marynelson@gmail.com");
            Thread.Sleep(1000);
            //Send text to Retype passowrd textbox
            driver.FindElement(By.Id("RetypePassword")).SendKeys("marynelson@gmail.com");
            Thread.Sleep(1000);
            //Click checkbox IsAdmin
            driver.FindElement(By.Id("IsAdmin")).Click();
            Thread.Sleep(1000);
            //Select Vehicle
            driver.FindElement(By.XPath("//input[@name='VehicleId_input']")).SendKeys("Honda");

            //Actions action = new Actions(driver);
            //IWebElement moveToBackToList = driver.FindElement(By.LinkText("Back to List"));
            //action.MoveToElement(moveToBackToList);
            //action.Perform();

            Thread.Sleep(1000);

            //Input Groups
            driver.FindElement(By.XPath("//div[@class='k-multiselect-wrap k-floatwrap']")).Click();
            Thread.Sleep(1000);

            //Actions action = new Actions(driver);
            //IWebElement childElement = driver.FindElement(By.XPath("//li[normalize-space()='nztest']"));
            //action.MoveToElement(childElement).Perform();
            //Thread.Sleep(1000);
            //action.Click().Build().Perform();

            //Click Save
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(1000);
            //Click Back to List
            driver.FindElement(By.LinkText("Back to List")).Click();
            Thread.Sleep(2000);

            //Click go to Last page
            driver.FindElement(By.XPath("//span[contains(text(),'Go to the last page')]")).Click();
            Thread.Sleep(1000);

            //Check if record created.
            
            
            //Assert.That(nameCheck.Text == "Mary Nelson", "Name found does not match as expected");
            //Assert.That(usernameCheck.Text == "marynelson", "Username found does not match as expected");

        }
        public string GetNewName(IWebDriver driver)
        {
            IWebElement nameCheck = driver.FindElement(By.XPath("//tbody/tr[last()]/td[1]"));
            return nameCheck.Text;

        }
        public string GeNewUserName(IWebDriver driver)
        {
            IWebElement usernameCheck = driver.FindElement(By.XPath("//tbody/tr[last()]/td[2]"));
            return usernameCheck.Text;
        }
        public void EditEmployee(IWebDriver driver)
        {
            //Click go to Last page
            Thread.Sleep(1500);
            driver.FindElement(By.XPath("//span[contains(text(),'Go to the last page')]")).Click();
            Thread.Sleep(1500);

            IWebElement checkName = driver.FindElement(By.XPath("//tbody/tr[last()]/td[1]"));
            if (checkName.Text == "Mary Nelson")
            {
                driver.FindElement(By.XPath("//tbody/tr[last()]/td[3]/a[1]")).Click();
                Thread.Sleep(1000);

                //edit Name
                IWebElement editName = driver.FindElement(By.Id("Name"));
                editName.Clear();
                editName.SendKeys("Mary Nelson");

                //username
                IWebElement editUsername = driver.FindElement(By.Id("Username"));
                editUsername.Clear();
                editUsername.SendKeys("marynelson");

              /////////////////****************************  //edit contact

                IWebElement EditcontactButton = driver.FindElement(By.XPath("//*[@id='EditContactButton']"));
                EditcontactButton.Click();
                driver.SwitchTo().Frame(0);

               


                //Click save button
                driver.FindElement(By.Id("SaveButton")).Click();

                //click Back to list
                driver.FindElement(By.LinkText("Back to List")).Click();
                Thread.Sleep(1500);

                //Go to last page
                driver.FindElement(By.XPath("//span[contains(text(),'Go to the last page')]")).Click();

                Thread.Sleep(1500);

              
               

                //Assert.That(nameCheck2.Text != "Mary Nelson", "Name is found. Record is not deleted.");
                //Assert.That(usernameCheck2.Text != "marynelson", "Username is found. Record is not deleted");

            }
            else
            {
                Assert.Fail("Record found doesn't contain Name as expected");
            }

            ////edit name
            //IWebElement EditName = driver.FindElement(By.Id("Name"));
            //EditName.Clear();
            //EditName.SendKeys(Name);
            //Thread.Sleep(1000);

            ////edit USer Name
            //IWebElement EditUserName = driver.FindElement(By.Id("Username"));
            //EditUserName.Clear();
            //EditUserName.SendKeys(Username);
            //Thread.Sleep(1000);

            //IWebElement EditMobile = driver.FindElement(By.XPath("//*[@id='Mobile']"));
            //EditMobile.SendKeys(Mobile);


            //IWebElement EditEmail = driver.FindElement(By.XPath("//*[@id='email']"));
            //EditEmail.SendKeys(Email);

            //IWebElement EditStreet = driver.FindElement(By.Id("Street"));
            //EditStreet.SendKeys(Street);


            //IWebElement EditCity = driver.FindElement(By.Id("City"));
            //EditStreet.SendKeys(City);

            //IWebElement EditPostCode = driver.FindElement(By.Id("Postcode"));
            //EditStreet.SendKeys(PostCode);

            //IWebElement EditCountry = driver.FindElement(By.Id("Country"));
            //EditStreet.SendKeys(Country);

            IWebElement EditSaveContactButton = driver.FindElement(By.Id("submitButton"));
            EditSaveContactButton.Click();


            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);


            IWebElement EditSave = driver.FindElement(By.Id("SaveButton"));
            EditSave.Click();
            Thread.Sleep(2000);

            string EditedConfirmText = driver.SwitchTo().Alert().Text;
            Assert.IsTrue(EditedConfirmText.Contains("Saved Succesfully"));

        }
        public string GetEditedName (IWebDriver driver)
        {
            IWebElement nameCheck2 = driver.FindElement(By.XPath("//tbody/tr[last()]/td[1]"));
            return nameCheck2.Text;
        }
        public string GetEditedUserName(IWebDriver driver)
        {
            IWebElement usernameCheck2 = driver.FindElement(By.XPath("//tbody/tr[last()]/td[2]"));
            return usernameCheck2.Text;
        }
        public void DeleteEmployee(IWebDriver driver)
        {
            //Click go to Last page
            Thread.Sleep(1500);
            driver.FindElement(By.XPath("//span[contains(text(),'Go to the last page')]")).Click();
            Thread.Sleep(1500);

            IWebElement checkName = driver.FindElement(By.XPath("//tbody/tr[last()]/td[1]"));
            if (checkName.Text == "Mary Nelson")
            {
                driver.FindElement(By.XPath("//tbody/tr[last()]/td[3]/a[2]")).Click();
                Thread.Sleep(1000);
                driver.SwitchTo().Alert().Accept();

                Thread.Sleep(1000);

                IWebElement nameCheck2 = driver.FindElement(By.XPath("//tbody/tr[last()]/td[1]"));
                IWebElement usernameCheck2 = driver.FindElement(By.XPath("//tbody/tr[last()]/td[2]"));

                Assert.That(nameCheck2.Text != "Mary Nelson", "Name is found. Record is not deleted.");
                Assert.That(usernameCheck2.Text != "marynelson", "Username is found. Record is not deleted");

            }
            else
            {
                Assert.Fail("Record found doesn't contain Name as expected");
            }
        }
    }
}
