using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTests;
using System.Collections;
using System;

namespace ContainersTest
{
    [TestClass]
    class MyQueueTest
    {
        [TestMethod]
        public void TestIsEpmty()
        {
            Queue<int> queue = new Queue<int>();
            Assert.IsNotNull(queue);
        }


        [TestMethod]
        public void TestQueue()
        {
            var queue = new MyQueue();
            queue.Push(1);

            Assert.AreEqual(queue.GetArray().GetLength(), 1);

            queue.Pop();

            Assert.AreEqual(queue.GetArray().GetLength(), 0);
        }
    }
}
