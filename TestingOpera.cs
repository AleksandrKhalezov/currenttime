﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEV_13
{
    /// <summary>
    /// Summary description for TestingOpera
    /// </summary>
    [TestClass]
    public class TestingOpera
    {
        string login = "tat-de13@mail.ru";
        string password = "23.03.2017";

        IWebDriver driver;
        HomePage homePage;
        TestingPage testPage;
        NotValidEnterPage notValidEnterPage;

        [TestMethod]
        public void ValidInputtingTesting()
        {
            using (driver = new OperaDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                testPage = new TestingPage(driver);
                testPage.FillForm(login, password);
                homePage = new HomePage(driver);
                homePage.FindNeedElement();
            }
        }

        [TestMethod]
        public void EmptyPasswordInputtingTesting()
        {
            using (driver = new OperaDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                testPage = new TestingPage(driver);
                testPage.FillForm(login, "");
                notValidEnterPage = new NotValidEnterPage(driver);
                notValidEnterPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void EmptyLoginInputtingTesting()
        {
            using (driver = new OperaDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                testPage = new TestingPage(driver);
                testPage.FillForm("", password);
                notValidEnterPage = new NotValidEnterPage(driver);
                notValidEnterPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void EmptyLoginAndPasswordInputtingTesting()
        {
            using (driver = new OperaDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                testPage = new TestingPage(driver);
                testPage.FillForm("", "");
                notValidEnterPage = new NotValidEnterPage(driver);
                notValidEnterPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void NotValidPasswordInputtingTesting()
        {
            using (driver = new OperaDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                testPage = new TestingPage(driver);
                testPage.FillForm(login, "asdfghjkl");
                notValidEnterPage = new NotValidEnterPage(driver);
                notValidEnterPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void NotValidLoginInputtingTesting()
        {
            using (driver = new OperaDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                testPage = new TestingPage(driver);
                testPage.FillForm("asdfghjkl", password);
                notValidEnterPage = new NotValidEnterPage(driver);
                notValidEnterPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void NotValidLoginAndPasswordInputtingTesting()
        {
            using (driver = new OperaDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                testPage = new TestingPage(driver);
                testPage.FillForm("asdfghjkl", "asdfghjkl");
                notValidEnterPage = new NotValidEnterPage(driver);
                notValidEnterPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void HardNotValidSimbolsLoginInputtingTesting()
        {
            using (driver = new OperaDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                testPage = new TestingPage(driver);
                testPage.FillForm("“♣☺♂” , “”‘~!@#$%^&*()?>,./<][ /*<!–“”, “${code}”;–>", password);
                notValidEnterPage = new NotValidEnterPage(driver);
                notValidEnterPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void HardNotValidSimbolsPasswordInputtingTesting()
        {
            using (driver = new OperaDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                testPage = new TestingPage(driver);
                testPage.FillForm(password, " “♣☺♂” , “”‘~!@#$%^&*()?>,./<][ /*<!–“”, “${code}”;–>");
                notValidEnterPage = new NotValidEnterPage(driver);
                notValidEnterPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void HardNotValidSimbolsLoginAndPasswordInputtingTesting()
        {
            using (driver = new OperaDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                testPage = new TestingPage(driver);
                testPage.FillForm(" “♣☺♂” , “”‘~!@#$%^&*()?>,./<][ /*<!–“”, “${code}”;–>", " “♣☺♂” , “”‘~!@#$%^&*()?>,./<][ /*<!–“”, “${code}”;–>");
                notValidEnterPage = new NotValidEnterPage(driver);
                notValidEnterPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void SpacesLoginInputtingTesting()
        {
            using (driver = new OperaDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                testPage = new TestingPage(driver);
                testPage.FillForm("                             ", password);
                notValidEnterPage = new NotValidEnterPage(driver);
                notValidEnterPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void SpacesPasswordInputtingTesting()
        {
            using (driver = new OperaDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                testPage = new TestingPage(driver);
                testPage.FillForm(login, "                 ");
                notValidEnterPage = new NotValidEnterPage(driver);
                notValidEnterPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void SpacesLoginAndPasswordInputtingTesting()
        {
            using (driver = new OperaDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                testPage = new TestingPage(driver);
                testPage.FillForm("                 ", "                 ");
                notValidEnterPage = new NotValidEnterPage(driver);
                notValidEnterPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void NOtValidRegisterLoginInputtingTesting()
        {
            using (driver = new OperaDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                testPage = new TestingPage(driver);
                testPage.FillForm("tAt-deE13@maIl.rU", password);
                notValidEnterPage = new NotValidEnterPage(driver);
                notValidEnterPage.FindNeedElement();
            }
        }

        [TestMethod]
        public void NOtValidRegisterPasswordInputtingTesting()
        {
            using (driver = new OperaDriver())
            {
                driver.Navigate().GoToUrl("https://mail.ru");
                testPage = new TestingPage(driver);
                testPage.FillForm(login, "@#.03.2)1?");
                notValidEnterPage = new NotValidEnterPage(driver);
                notValidEnterPage.FindNeedElement();
            }
        }

    }
}
