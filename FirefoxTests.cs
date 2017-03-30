using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEV_13
{
    class FirefoxTests : ChromeTests
    {
        [TestInitialize]
        override public void BrowserInitialisation()
        {
            driver = FirefoxDriver();
        }
    }
}
