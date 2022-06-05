using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListTask2;
using System.Collections.Generic;
using System.Linq;

namespace LinkedListTests
{
    [TestClass]
    public  class ExtendsTest
    { 
        

        Extends<int> extend = new Extends<int>();

       [TestMethod]
        public void AnyTest()
        {
            int[] arr = new[] { 0,1,2 };
            Assert.AreEqual(extend.Any(arr), true);
        }

        [TestMethod]
        public void ElementAtTest()
        {
            int[] arr = new[] { 0,1,2};
            Assert.AreEqual(extend.ElementAt(arr, 2), 2);
        }

        [TestMethod]
        public void ElementAtOrDefaultTest()
        {
            int[] arr = new[] { 0,1,2 };

                Assert.AreEqual(extend.ElementAtOrDefault(arr, 5), 0);
                Assert.AreEqual(extend.ElementAtOrDefault(arr, 2), 2);
            
        }
        [TestMethod]
        public void CountTest()
        {
            int[] arr = new[] { 0,1,2};
            Assert.AreEqual(extend.Count(arr), 3);
        }

        [TestMethod]

        public void FirstTest()
        {
            int[] arr = new[] { 0,1,2 };
            Assert.AreEqual(extend.First(arr), 0);
        }

        [TestMethod]
        public void LastTest()
        {
            int[] arr = new[] { 0,1,2};
            Assert.AreEqual(extend.Last(arr), 2);
        }
        [TestMethod]
        public void MaxTest()
        {
            int[] arr = new[] { 5, 10, 7, 5 };
            Assert.AreEqual(extend.Max(arr, (i1, i2) => i1 < i2), 10);
        }

        [TestMethod]
        public void MinTest()
        {
            int[] arr = new[] { 15, 10, 1, 15 };
            Assert.AreEqual(extend.Min(arr, (i1, i2) => i1 < i2), 1);
        }

        [TestMethod]
        public void ReverseTest()
        {
            int[] arr = new[] { 1, 2, 3 };
            int[] reversedArr = extend.Reverse(arr);
            Enumerable.SequenceEqual(reversedArr, new int[] { 3, 2, 1 });
        }





    }
}
