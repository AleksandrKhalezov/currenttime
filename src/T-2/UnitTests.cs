using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_6;

namespace Dev_6_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingDateInputing()
        {
            DateTime actual = DateTime.Now;
            Inputer inputer = new Inputer();
            actual = inputer.InputDate();
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void TestingConvertationOfDate()
        {
            DateTime now = DateTime.Now;
            Converter converter = new Converter();
            string expected = now.ToString();
            string actual = converter.ConvertDate(now);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingDayParser()
        {
            DateTime now = DateTime.Now;
            Parser parser = new Parser();
            string expected = now.ToString("dd");
            string actual = parser.ParseDay(now.ToString());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingMounthParser()
        {
            DateTime now = DateTime.Now;
            Parser parser = new Parser();
            string expected = now.ToString("MM");
            string actual = parser.ParseMounth(now.ToString());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingYearParser()
        {
            DateTime now = DateTime.Now;
            Parser parser = new Parser();
            string expected = now.ToString("yyyy");
            string actual = parser.ParseYear(now.ToString());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingHoursParser()
        {
            DateTime now = DateTime.Now;
            Parser parser = new Parser();
            string expected = now.ToString("HH");
            string actual = parser.ParseHours(now.ToString());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingMinutesParser()
        {
            DateTime now = DateTime.Now;
            Parser parser = new Parser();
            string expected = now.ToString("mm");
            string actual = parser.ParseMinutes(now.ToString());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingSecondsParser()
        {
            DateTime now = DateTime.Now;
            Parser parser = new Parser();
            string expected = now.ToString("ss");
            string actual = parser.ParseSeconds(now.ToString());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingOutputingOnlyDate()
        {
            string key = "1";
            string day = "12";
            string mounth = "12";
            string year = "2012";
            string hours = "12";
            string minutes = "12";
            string seconds = "12";
            Outputer outputer = new Outputer();
            string expected = "12/12/2012 ";
            string actual = outputer.DateOutputer(key, day, mounth, year, hours, minutes, seconds);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingOutputingOnlyTime()
        {
            string key = "2";
            string day = "12";
            string mounth = "12";
            string year = "2012";
            string hours = "12";
            string minutes = "12";
            string seconds = "12";
            Outputer outputer = new Outputer();
            string expected = "12:12:12 ";
            string actual = outputer.DateOutputer(key, day, mounth, year, hours, minutes, seconds);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingOutputingDateAndTime()
        {
            string key = "3";
            string day = "12";
            string mounth = "12";
            string year = "2012";
            string hours = "12";
            string minutes = "12";
            string seconds = "12";
            Outputer outputer = new Outputer();
            string expected = "12/12/2012 12:12:12 ";
            string actual = outputer.DateOutputer(key, day, mounth, year, hours, minutes, seconds);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingOutputingDateAndTimeWithoutSeconds()
        {
            string key = "4";
            string day = "12";
            string mounth = "12";
            string year = "2012";
            string hours = "12";
            string minutes = "12";
            string seconds = "12";
            Outputer outputer = new Outputer();
            string expected = "12/12/2012 12:12 ";
            string actual = outputer.DateOutputer(key, day, mounth, year, hours, minutes, seconds);
            Assert.AreEqual(expected, actual);
        }
    }
}
