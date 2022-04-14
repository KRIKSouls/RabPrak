using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WaterSupply;
namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidSortNameCompany_True()
        {
            bool IsTrue = TestClass.SortPlaceObj();
            Assert.AreEqual(true, IsTrue);
        }

        [TestMethod]
        public void ValidSortPlaceName_True()
        {
            bool IsTrue = TestClass.SortPlaceName();
            Assert.AreEqual(true, IsTrue);
        }

        [TestMethod]
        public void Test3()
        {
            bool IsTrue = TestClass.SortPlaceName();
            Assert.AreEqual(true, IsTrue);
        }

        [TestMethod]
        public void Test4()
        {
            bool IsTrue = TestClass.SortPlaceName();
            Assert.AreEqual(true, IsTrue);
        }

        [TestMethod]
        public void Test5()
        {
            bool IsTrue = TestClass.SortPlaceName();
            Assert.AreEqual(true, IsTrue);
        }

        [TestMethod]
        public void Test6()
        {
            bool IsTrue = TestClass.SortPlaceName();
            Assert.AreEqual(true, IsTrue);
        }

        [TestMethod]
        public void Test7()
        {
            bool IsTrue = TestClass.SortPlaceName();
            Assert.AreEqual(true, IsTrue);
        }

        [TestMethod]
        public void Test8()
        {
            bool IsTrue = TestClass.SortPlaceName();
            Assert.AreEqual(true, IsTrue);
        }

        [TestMethod]
        public void Test9()
        {
            bool IsTrue = TestClass.SortPlaceName();
            Assert.AreEqual(true, IsTrue);
        }

        [TestMethod]
        public void Test10()
        {
            bool IsTrue = TestClass.SortPlaceName();
            Assert.AreEqual(true, IsTrue);
        }

        [TestMethod]
        public void AddDate_True()
        {
            bool IsTrue = TestClass.AddContract(10, "16.06.2021", 200, "17.06.2021", 1, 1, 1, 1);
            Assert.AreEqual(true, IsTrue);
        }

        [TestMethod]
        public void AddDate_False()
        {
            bool IsFalse = TestClass.AddContract(10, "16.06.2021c", 200, "17.06", 1, 1, 1, 1);
            Assert.AreEqual(false, IsFalse);
        }

        [TestMethod]
        public void AddContract_True()
        {
            bool IsTrue = TestClass.AddContract(10, "16.06.2021", 200, "17.06.2021", 1, 1, 1, 1);
            Assert.AreEqual(true, IsTrue);
        }

        [TestMethod]
        public void AddContract_False()
        {
            bool IsFalse = TestClass.AddContract(10, "16.06.2021c", 200, "17.06", 1, 1, 1, 1);
            Assert.AreEqual(false, IsFalse);
        }

        [TestMethod]
        public void AddSubcriber_True()
        {
            bool IsTrue = TestClass.AddSubcriber("10", "фф", "aa", "aa", "aa", "aaa", 1);
            Assert.AreEqual(true, IsTrue);
        }

        [TestMethod]
        public void AddSubcriber_False()
        {
            bool IsFalse = TestClass.AddSubcriber("10f", "фф", "aa", "aa", "aa", "пп", 1);
            Assert.AreEqual(false, IsFalse);
        }

        [TestMethod]
        public void AddPlace_True()
        {
            bool IsTrue = TestClass.AddPlace("10", "фф", "aa", 1);
            Assert.AreEqual(true, IsTrue);
        }

        [TestMethod]
        public void AddPlace_False()
        {
            bool IsFalse = TestClass.AddPlace("10h", "фф", "", 1);
            Assert.AreEqual(false, IsFalse);
        }

        [TestMethod]
        public void AddTitle_True()
        {
            bool IsTrue = TestClass.AddPlace("10", "фb", "bb", 1);
            Assert.AreEqual(true, IsTrue);
        }

        [TestMethod]
        public void AddTitle_False()
        {
            bool IsFalse = TestClass.AddPlace("10r", "фb", "", 1);
            Assert.AreEqual(false, IsFalse);
        }
    }
}
