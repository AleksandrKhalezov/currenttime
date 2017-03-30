using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;


namespace DEV_13
{
    class OperaTests : Tests
    {
        [TestInitialize]
        override public void BrowserInitialization()
        {
            driver = OperaDriver();
        }
    }
}
