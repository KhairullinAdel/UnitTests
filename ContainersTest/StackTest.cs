using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests;

namespace StackTest
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void ChekingCreationTest()
        {
            MyStack stack = new MyStack();
            Assert.IsNotNull(stack);
        }

        [TestMethod]
        public void CheckOverflowTest()
        {
            MyStack stack = new MyStack();
            for (int i = 0; i < 12; i++)
            {
                stack.Push(i);
            }
            Assert.AreEqual(stack.GetArray().Length, 12);
        }
        [TestMethod]
        public void Test()
        {
            MyStack stack = new MyStack();
            for (int i = 0; i < 12; i++)
            {
                stack.Push(i);
            }
            for (int i = 0; i < 13; i++)
            {
                stack.Pop();
            }
            Assert.IsFalse(stack.IsEmpty());

        }

    }
}
