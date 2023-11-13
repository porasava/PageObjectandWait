using OpenQA.Selenium;
using PageObjectandWait.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectandWait.Pages
{
    public class TMPage
    {
        public void Create_TimeRecord(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "Xpath","//*[@id=\"container\"]/p/a", 5);
            //Add
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNew.Click();
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCode.Click();
            IWebElement typeCodeTime = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            typeCodeTime.Click();
            IWebElement createCode = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            createCode.SendKeys("HelloTan");
            IWebElement createDescription = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            createDescription.SendKeys("HelloTanDes");
            Thread.Sleep(1000);
            IWebElement pricePerUnit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            pricePerUnit.SendKeys("111");
            IWebElement createSave = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            createSave.Click();
            Wait.WaitToBeClickable(driver, "Xpath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 3);
            //Go to last page
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPage.Click();
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));



            if (newCode.Text == "HelloTan")
            {
                Console.WriteLine("New record has been created successfully.");
            }
            else
            {
                Console.WriteLine("Record has not been created.");
            }

        }
        public void Update_TimeRecord(IWebDriver driver) 
        {
            //Edit
            IWebElement editLastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editLastRecord.Click();
            Wait.WaitToBeClickable(driver, "Xpath", "//*[@id=\"Code\"]", 3);
         
            IWebElement editCode = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            editCode.Clear();
            editCode.SendKeys("HelloTan1");
            IWebElement editDescription = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            editDescription.Clear();
            editDescription.SendKeys("HelloTanDes1");
            IWebElement EditSave = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            EditSave.Click();
            Wait.WaitToBeClickable(driver, "Xpath", "/html/body/div[4]/div/div/div[4]/a[4]/span", 3);
            
            //Go to last page
            IWebElement lastPageEdit = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[4]/a[4]/span"));
            lastPageEdit.Click();
            Thread.Sleep(4000);


        }

        public void Delete_TimeRecord(IWebDriver driver) 
        {
            IWebElement lastPageDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[6]/td[5]/a[2]"));
            lastPageDelete.Click();
            driver.SwitchTo().Alert().Accept();
        }
        //

    }
}
