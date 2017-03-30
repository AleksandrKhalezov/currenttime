using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DEV_13
{
    [TestClass]
    abstract public class Tests
    {
        string validLogin = "tat-dev13@mail.ru";
        string validPassword = "23.03.2017";

        protected IWebDriver driver;
        HomePage homePage;
        TestingPage testPage;
        NotValidEnterPage notValidEnterPage;

        [TestInitialize]
        abstract public void BrowserInitialization();

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void ValidInputtingTesting()
        {
            using (driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                testPage = new TestingPage(driver);
                testPage.FillForm(validLogin, validPassword);
                homePage = new HomePage(driver);
                homePage.FindNeedElement();
            }
        }

        [DataSource(@"Provider=Microsoft.Excel.2016; Data Source=D:\Programming\C#\Projects\DEV-12\DataSource.xlsx;", "Table")]
        [TestMethod]
        public void NotValidInputtingTesting()
        {
            driver.Navigate().GoToUrl("https://mail.ru");
            string login = (TestContext.DataRow["Login"].ToString());
            string password = (TestContext.DataRow["Password"].ToString());
            testPage = new TestingPage(driver);
            testPage.FillForm(login, password);
            notValidEnterPage = new NotValidEnterPage(driver);
            notValidEnterPage.FindNeedElement();
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}

