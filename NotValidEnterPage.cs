using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace DEV_13
{
    [TestClass]
    public class NotValidEnterPage
    {
        IWebDriver driver;
        By errorPage = By.XPath("//*[contains(text(),'Вход')]");
        public NotValidEnterPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FindNeedElement()
        {
            driver.FindElement(errorPage);
        }
    }
}
