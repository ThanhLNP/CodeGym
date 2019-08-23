using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace MSTest
{
    [TestClass]
    public class ListTest
    {
        private MyList<int> myList = new MyList<int>();
        [TestMethod]
        public void TestMethod1()
        {
            myList.add(5);
            Assert.IsNotNull(myList.Elements);

        }
    }
}
