using Microsoft.VisualStudio.TestTools.UnitTesting;
using Search;

namespace BinarySearchTest
{
    [TestClass]
    public class TestRun
    {
        int[] evenList = new int[]{-10,-6,-3,0,1,5,6,8,12,21,25};
        int[] oddList = new int[]{-11,-5,-4,1,2,3,10};
        int[] one = new int[]{3};

        [TestMethod]
        public void IsInList()
        {
            BinarySearch b = new BinarySearch();
            Assert.AreEqual(5, b.Run(evenList, 5));
            Assert.AreEqual(0, b.Run(evenList, 0));
            Assert.AreEqual(21, b.Run(evenList, 21));
            Assert.AreEqual(3, b.Run(oddList, 3));
            Assert.AreEqual(-11, b.Run(oddList, -11));
            Assert.AreEqual(3, b.Run(one, 3));
        }

        [TestMethod]
        public void IsNotInList()
        {
            BinarySearch b = new BinarySearch();
            Assert.IsNull(b.Run(one, 4));
            Assert.IsNull(b.Run(evenList, 7));
            Assert.IsNull(b.Run(oddList, 4));
        }
    }
}
