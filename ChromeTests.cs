using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace DEV_13
{
    class ChromeTests : Tests
    {
        [TestInitialize]
        override public void BrowserInitialization()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions");
            options.AddArgument("test-type");
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("no-sandbox");
            driver = new ChromeDriver(options);
        }
    }
}
