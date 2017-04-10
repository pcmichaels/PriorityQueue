using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue.UnitTests
{
    public class PriorityQueueTest
    {
        [Test]
        public void TestSimplePriority()
        {
            PQueue.PriorityQueue<string> queue = new PQueue.PriorityQueue<string>();
            queue.Enqueue("test", 2);
            queue.Enqueue("test2", 1);

            // Act
            var result = queue.Dequeue();
            var result2 = queue.Dequeue();

            // Assert
            Assert.AreEqual("test2", result);
            Assert.AreEqual("test", result2);

        }
        
    }
}
