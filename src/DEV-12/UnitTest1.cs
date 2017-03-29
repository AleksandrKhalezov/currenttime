using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_12;

namespace DEV_12_TESTS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SelectionColorForWhiteUpperCaseTesting()
        {
            ColorSelector colorSelector = new ColorSelector();
            char expected = 'w';

            Assert.AreEqual(expected, colorSelector.SelectColor("W"));
        }

        [TestMethod]
        public void SelectionColorForWhiteLowerCaseTesting()
        {
            ColorSelector colorSelector = new ColorSelector();
            char expected = 'w';

            Assert.AreEqual(expected, colorSelector.SelectColor("w"));
        }

        [TestMethod]
        public void SelectionColorForBlackUpperCaseTesting()
        {
            ColorSelector colorSelector = new ColorSelector();
            char expected = 'b';

            Assert.AreEqual(expected, colorSelector.SelectColor("B"));
        }

        [TestMethod]
        public void SelectionColorForBlackLowerCaseTesting()
        {
            ColorSelector colorSelector = new ColorSelector();
            char expected = 'b';

            Assert.AreEqual(expected, colorSelector.SelectColor("b"));
        }

        [TestMethod]
        [ExpectedException (typeof(FormatException), "Error! Wrong format of color!")]
        public void SelectionColorForExeptionStringTesting()
        {
            ColorSelector colorSelector = new ColorSelector();
            colorSelector.SelectColor("n");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException), "Error! Wrong format of color!")]
        public void SelectionColorForExeptionDigitTesting()
        {
            ColorSelector colorSelector = new ColorSelector();
            colorSelector.SelectColor("2");
        }

        [TestMethod]
        public void SelectCoordinateForTrimStringTesting()
        {
            CoordinateParser coordinateSelector = new CoordinateParser();
            int [] expected = { 1, 1 };

            Assert.AreEqual(expected , coordinateSelector.SelectCoordinate("   a  1  "));
        }

        [TestMethod]
        public void SelectCoordinateWithoutSpasesStringTesting()
        {
            CoordinateParser coordinateSelector = new CoordinateParser();
            int [] expected = { 1, 1 };

            Assert.AreEqual(expected, coordinateSelector.SelectCoordinate("a1"));
        }

        [TestMethod]
        public void SelectCoordinateUpperCaseStringTesting()
        {
            CoordinateParser coordinateSelector = new CoordinateParser();
            int [] expected = { 1, 1 };

            Assert.AreEqual(expected, coordinateSelector.SelectCoordinate("A1"));
        }

        [TestMethod]
        public void SelectCoordinateEightStringTesting()
        {
            CoordinateParser selectCoordinate = new CoordinateParser();
            int [] expected = { 8, 8 };

            Assert.AreEqual(expected, selectCoordinate.SelectCoordinate("h8"));
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException), " Error! By rules only black fields are allowed! ")]
        public void SelectCoordinateFirstFormatExeptionTesting()
        {
            CoordinateParser coordinateSelector = new CoordinateParser();
            coordinateSelector.SelectCoordinate("a2");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), " Error! By rules only black fields are allowed! ")]
        public void SelectCoordinateSecondFormatExeptionTesting()
        {
            CoordinateParser coordinateSelector = new CoordinateParser();
            coordinateSelector.SelectCoordinate("n9");
        }

        [TestMethod]
        public void StepsCheckerBlackReachableFieldTesting()
         {
            StepsChecker stepsChecker = new StepsChecker();
            int [] start = { 5, 7 };
            int [] finish = { 6, 2 };

            Assert.AreEqual(5, stepsChecker.Count('b', start, finish));
        }

        [TestMethod]
        public void StepsCheckerWhiteReachableFieldTesting()
        {
            StepsChecker stepsChecker = new StepsChecker();
            int [] start = { 6, 2 };
            int [] finish = { 5, 7 };

            Assert.AreEqual(5, stepsChecker.Count('w', start, finish));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Not reachable field")]
        public void StepsCheckerFormatExeptionTesting()
        {
            StepsChecker stepsChecker = new StepsChecker();
            int [] start = { 6, 2 };
            int [] finish = { 5, 7 };

            stepsChecker.Count('b', start, finish);
        }
    }
}
