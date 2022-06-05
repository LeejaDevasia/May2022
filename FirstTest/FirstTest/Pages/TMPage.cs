using FirstTest.Utilities;
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
        public void CreateTM(IWebDriver driver)
        {
            //Opening create new 
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNew.Click();
            WaitHelpers.WaitToBeClickable(driver,"XPath", "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]", 5);
            //selecting type code
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            typeCode.Click();
            //
            IWebElement codeTextBox = driver.FindElement(By.XPath("//*[@id='Code']"));
            codeTextBox.SendKeys("CD_1000");

            //entering data to description box 
            IWebElement desriptionTextBox = driver.FindElement(By.XPath("//*[@id='Description']"));


            ///////////////checking 
            if (desriptionTextBox.Text == "this is newly created element")
            {
                desriptionTextBox.SendKeys("this is newly created element");
            }
            else
            {
                Console.WriteLine("Description doesn't match expected descirption");
            }
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

            if (lastItemAdded.Text == "CD_001")
            {
                Console.WriteLine("New material record created succefully");

            }
            else
            {
                Console.WriteLine("New material record hasn't been created");
            }
            Thread.Sleep(100);


        }
        public void EditTM(IWebDriver driver)
        {
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            //checking typecode of selected row is same as displayed one for edit


            //IWebElement tagselection = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span"));
            //tagselection.Click();
            //IWebElement list = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]"));
            //list.Click();
            //IWebElement selectTypeCode = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            //selectTypeCode.Click();

            //IWebElement selectTypeCodeNew = driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']"));
            //Thread.Sleep(1000);

            //Thread.Sleep(100);


            //checking code of selected row is same as displayed one for edit


            ////if code needs to edit, can add this code
            //IWebElement selectCode = driver.FindElement(By.XPath("//*[@id='Code']"));
            //selectCode.Clear();
            //selectCode.SendKeys("C00-025");

            //checking description of selected row is same as displayed one for edit

            IWebElement selectDescription = driver.FindElement(By.XPath("//*[@id='Description']"));
            selectDescription.Clear();
            selectDescription.SendKeys("Edited Now");

            //checking price of selected row is same as displayed one for edit


            IWebElement tagPrice = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            tagPrice.Click();
            IWebElement selectPrice = driver.FindElement(By.Id("Price"));
            selectPrice.Clear();
            tagPrice.Click();
            selectPrice.SendKeys("10050");
            IWebElement editSave = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            editSave.Click();
            //check whether the edit has happend 
            Thread.Sleep(100);



            //***************************************//

            IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpageButton.Click();
            Thread.Sleep(1000);

            IWebElement editprice1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            /////////////////////////

            //if (editDescription.Text == "Edited Now"||editPrice.Text== "10050"||editTypeCode.Text== "T")
            if (editprice1.Text == "$10,050.00")
            {
                Console.WriteLine("Record has been edited succefully");

            }
            else
            {
                Console.WriteLine("Record hasn't been edited ");
            }
        }
        public void DeleteTM(IWebDriver driver)
        {
            //Delete function
        }

    }
}
