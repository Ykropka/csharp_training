using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace caharp_training
{
    public static class CheckElement
    {
        public static IWebElement FindElementClickable(IWebDriver driver, By by, int timeoutInSeconds = 30)
        {
            var wait = new DefaultWait<IWebDriver>(driver);
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(NoSuchElementException));
            wait.Timeout = TimeSpan.FromSeconds(timeoutInSeconds);
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            wait.Until(d => d.FindElement(by).Displayed && d.FindElement(by).Enabled);
            return driver.FindElement(by);
        }
    }
}
