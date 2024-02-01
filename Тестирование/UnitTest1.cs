using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sort;

namespace Тестирование
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Main corr = new Main();
            // arrange
            int[] inputArray = new int[] { 297, 254, 505 };
            int[] expectedOutput = new int[] { 254, 297, 505};
            int expectedCount = 9;
            int actualCount;
            corr.array = inputArray;
            int[] actualOutput = corr.Algorithm(false, out actualCount);
            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput.Length, actualOutput.Length);
            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.AreEqual(expectedOutput[i], actualOutput[i]);
            }
        }

        [TestMethod]
        //тест на возвращаение нужного количества элементов массива
        public void TestMethod2()
        {
            Main corr = new Main();
            // arrange
            int[] inputArray = new int[] { 5, 3, 8, 1, 9 };
            int expectedCount = 5;
            int actualCount;
            corr.array = inputArray;
            int[] actualOutput = corr.Algorithm(false, out actualCount, expectedCount);
            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(inputArray.Length, actualOutput.Length);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Main corr = new Main();
            // arrange
            int[] inputArray = new int[] { 302, 330, 484, 371, 692 };
            int[] expectedOutput = new int[] { 302, 330, 371, 484, 692 };
            int expectedCount = 25;
            int actualCount;
            corr.array = inputArray;
            int[] actualOutput = corr.Algorithm(false, out actualCount);
            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput.Length, actualOutput.Length);
            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.AreEqual(expectedOutput[i], actualOutput[i]);
            }
        }
    }
}
