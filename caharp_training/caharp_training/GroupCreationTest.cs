using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace caharp_training
{
    [TestFixture]
    public class GroupCreationTests
    {
        private IWebDriver driver;
        private string baseURL;
        [SetUp]
        public void SetUpTest()
        {
            driver = new ChromeDriver();
            baseURL = "http://localhost";
        }
        [TearDown]
        public void TearDown()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                //bla bla
            }
        }
        [Test]
        public void GroupCreationTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/addressbook/");
            driver.FindElement(By.XPath(SelectorHomePage.User)).Clear();
            driver.FindElement(By.XPath(SelectorHomePage.User)).SendKeys("admin");
            driver.FindElement(By.XPath(SelectorHomePage.Password)).Clear();
            driver.FindElement(By.XPath(SelectorHomePage.Password)).SendKeys("secret");
            driver.FindElement(By.XPath(SelectorHomePage.Login)).Click();
            Thread.Sleep(8000);
            IWebElement Groups = CheckElement.FindElementClickable(driver, By.LinkText(NavigationSelector.Groups));
            Groups.Click(); Thread.Sleep(5000);
            IWebElement NewGroups = CheckElement.FindElementClickable(driver, By.Name(SelectorGroups.NewGroups));
            NewGroups.Click();
            IWebElement GroupName = CheckElement.FindElementClickable(driver, By.XPath(SelectorGroups.GroupName));
            GroupName.Clear(); GroupName.SendKeys("q");
            IWebElement GroupHeader = CheckElement.FindElementClickable(driver, By.XPath(SelectorGroups.GroupHeader));
            GroupHeader.Clear(); GroupHeader.SendKeys("q");
            IWebElement GroupFooter = CheckElement.FindElementClickable(driver, By.XPath(SelectorGroups.GroupFooter));
            GroupFooter.Clear(); GroupFooter.SendKeys("q");
            IWebElement Submit = CheckElement.FindElementClickable(driver, By.XPath(SelectorGroups.Submit));
            Submit.Click(); Thread.Sleep(5000);
            IWebElement ReturnGroupPage = CheckElement.FindElementClickable(driver, By.LinkText(SelectorGroups.ReturnGroupPage));
            ReturnGroupPage.Click(); Thread.Sleep(5000);
            IWebElement LogOut = CheckElement.FindElementClickable(driver, By.XPath(NavigationSelector.LogOut));
            LogOut.Click();
            Thread.Sleep(2000);
        }
    }

}
