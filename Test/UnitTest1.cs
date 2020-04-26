using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 0, -7, 8, 9 };
            int result = OOP_lab_2_4_4.Program.IndexOfMax(a);
            Assert.AreEqual(9, result);
        }
        public void TestMethod2()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 0, -7, 8, 9 };
            int result = OOP_lab_2_4_4.Program.AbsSumBetweenFirstAndLastZeroes(a);
            Assert.AreEqual(0, result);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 81, 85, 96, -41, -77, -81, 11, 43, 90, 6 };
            int result = OOP_lab_2_4_4.Program.IndexOfMax(a);
            Assert.AreEqual(2, result);
        }
        public void TestMethod2()
        {
            int[] a = { 81, 85, 96, -41, -77, -81, 11, 43, 90, 6 };
            int result = OOP_lab_2_4_4.Program.AbsSumBetweenFirstAndLastZeroes(a);
            Assert.AreEqual(0, result);
        }
    }

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 100, 17, 9, 15, 54, 67, 21, 65, 44, 8 };
            int result = OOP_lab_2_4_4.Program.IndexOfMax(a);
            Assert.AreEqual(0, result);
        }
        public void TestMethod2()
        {
            int[] a = { 100, 17, 9, 15, 54, 67, 21, 65, 44, 8 };
            int result = OOP_lab_2_4_4.Program.AbsSumBetweenFirstAndLastZeroes(a);
            Assert.AreEqual(0, result);
        }
    }
}
