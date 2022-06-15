using FirstTest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstTest.Pages
{
    public class TMPage
    {
        private object Alert;

        public void CreateTM(IWebDriver driver)
        {
            //Opening create new 
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNew.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]", 5);
            //selecting type code
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            typeCode.Click();
            //
            IWebElement codeTextBox = driver.FindElement(By.XPath("//*[@id='Code']"));
            codeTextBox.SendKeys("CD_1000");

            //entering data to description box 
            IWebElement desriptionTextBox = driver.FindElement(By.XPath("//*[@id='Description']"));

            desriptionTextBox.SendKeys("this is newly created element");
            ///////////////checking 
            //enter Price per Unit
            //if an error message come like element not interactable
            //just find double tagging is there if so try to find first tag ID and make a click on it

            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();
            IWebElement pricePerUnit = driver.FindElement(By.XPath("//*[@id='Price']"));
            pricePerUnit.SendKeys("1050");
            //click on save button

            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            saveButton.Click();
            Thread.Sleep(1000);
            //go to last page of the list to check whether the item added or not
            IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpageButton.Click();
            Thread.Sleep(100);
            //get the code of the last item of last page
            IWebElement lastItemAdded = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (lastItemAdded.Text == "CD_1000")
            {
                Console.WriteLine("New material record created succefully");

            }
            else
            {
                Console.WriteLine("New material record hasn't been created");
            }
            Thread.Sleep(100);


        }

        public string GetNewCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;
        }
        public string GetNewTypeCode(IWebDriver driver)
        {
            IWebElement newTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return newTypeCode.Text;
        }

        public string GetNewDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }
        public string GetnewPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }

        public void EditTM(IWebDriver driver, string description, string code, string price)
        {
            Thread.Sleep(1000);
            IWebElement lastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpagebutton.Click();
            Thread.Sleep(1000);
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(1000);
            //checking description of selected row is same as displayed one for edit

            //IWebElement selectDescription = driver.FindElement(By.XPath("//*[@id='Description']"));
            //selectDescription.Clear();
            //selectDescription.SendKeys("Edited Now");

            //checking price of selected row is same as displayed one for edit


            

            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='Description']"));
            editedDescription.Clear();
            editedDescription.Click();
            editedDescription.SendKeys(description);
            Thread.Sleep(500);


            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='Code']"));
            editedCode.Clear();
            editedCode.Click();
            editedCode.SendKeys(code);
            Thread.Sleep(500);

            IWebElement tagPrice = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
            tagPrice.Click();
            Thread.Sleep(1000);
            IWebElement selectPrice = driver.FindElement(By.Id("Price"));
            selectPrice.Clear();
           Thread.Sleep(500);

            tagPrice.Click();
            Thread.Sleep(500);

            selectPrice.SendKeys(price);
            Thread.Sleep(500);

            IWebElement editSave = driver.FindElement(By.Id("SaveButton"));
            editSave.Click();
            //check whether the edit has happend 
            Thread.Sleep(1000);
            //go to last page
            IWebElement lastpageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpageButton1.Click();
            Thread.Sleep(1000);
          
        }
        public string GetEditedDescription(IWebDriver driver)
        {
            Thread.Sleep(500);
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return editedDescription.Text;
        }

        public string GetEditedCode(IWebDriver driver)
        {
            Thread.Sleep(500);
            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedCode.Text;
        }

        public string GetEditedPrice(IWebDriver driver)
        {
            Thread.Sleep(500);
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return editedPrice.Text;
        }
        public void DeleteTM(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement lastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpagebutton.Click();
            Thread.Sleep(1000);

            //Delete function
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(1000);
            
            IAlert promptAlert = driver.SwitchTo().Alert();
            promptAlert.Accept();
            Thread.Sleep(2000);

           // WaitHelpers.WaitToBeVisible()
            IWebElement goToLastPageBtn1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageBtn1.Click();
            Thread.Sleep(2000);

            
        
           


        }
        public string deletedCode(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement deletedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            return deletedCode.Text;
        }


    }
}
