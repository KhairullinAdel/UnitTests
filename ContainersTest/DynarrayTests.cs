using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests;

namespace ContainersTest
{
    [TestClass]
    public class DynarrayTests
    {
        [TestMethod]
        public void GetLengthTest()
        {
            DynArray dyn = new DynArray(10);
            Assert.AreEqual(10, dyn.GetLength());
        }
        [TestMethod]
        public void CheckRandomFillingTest()
        {
            DynArray dyn = new DynArray();
            dyn.FillRandom(1, 9);
            foreach (int i in dyn.GetArray())
            {
                Assert.AreNotEqual(i < 1, i);
                Assert.AreNotEqual(i > 9, i);
            }
        }
        [TestMethod]
        public void PushBackTest()
        {
            DynArray dyn = new DynArray(10);

            for (int i = 0; i < 10; i++)
            {
                dyn.Insert(i, i);
            }

            int[] temp = new int[10]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            
            CollectionAssert.Equals(temp, dyn.GetArray());
        }

        [TestMethod]
        public void ArrayPushBackTest()
        {
            DynArray dyn = new DynArray(10);

            for (int i = 0; i <= 10; i++)
            {
                dyn.Insert(i, i);
            }

            dyn.PushBack(10);

            Assert.AreEqual(10, dyn.GetArray()[10]);
        }

        [TestMethod]
        public void ArrayDeleteAndPopTest()
        {
            DynArray dyn = new DynArray(10);

            for (int i = 0; i <= 10; i++)
            {
                dyn.Insert(i, i);
            }

            dyn.PopBack();

            int[] temp = new int[9] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            CollectionAssert.Equals(temp, dyn.GetArray());

            dyn.Delete(3);
            Assert.AreEqual(dyn.GetArray()[3], 4);
        }
    }
}
