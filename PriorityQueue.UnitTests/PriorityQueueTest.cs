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

        [Test]
        public void TestConflictingPriority()
        {
            PQueue.PriorityQueue<string> queue = new PQueue.PriorityQueue<string>();
            queue.Enqueue("test", 2);
            queue.Enqueue("test2", 2); // Now priority 2 and "test" is move down one

            // Act
            var result = queue.Dequeue();
            var result2 = queue.Dequeue();

            // Assert
            Assert.AreEqual("test2", result);
            Assert.AreEqual("test", result2);

        }

        [Test]
        public void TestMixedPriotyAndQueue()
        {
            PQueue.PriorityQueue<string> queue = new PQueue.PriorityQueue<string>();
            queue.Enqueue("test3");     // First priority
            queue.Enqueue("test", 2);   // Priority 2, so no conflict
            queue.Enqueue("test2", 2);  // New priority 2, so now test3, test2, test

            // Act
            var result = queue.Dequeue();
            var result2 = queue.Dequeue();
            var result3 = queue.Dequeue();

            // Assert
            Assert.AreEqual("test3", result);
            Assert.AreEqual("test2", result2);
            Assert.AreEqual("test", result3);

        }

        [Test]
        public void TestMixedPriotyAndQueueWithConflicts()
        {
            PQueue.PriorityQueue<string> queue = new PQueue.PriorityQueue<string>();
            queue.Enqueue("test");      // First priority
            queue.Enqueue("test2");     // Second priority
            queue.Enqueue("test3");     // Third priority
            queue.Enqueue("test4", 1);  // Priority 2, so test2 and test3 now move down
            queue.Enqueue("test5", 1);  // New priority 2, so now test, test5, test4, test2, test3

            // Act
            var result = queue.Dequeue();
            var result2 = queue.Dequeue();
            var result3 = queue.Dequeue();
            var result4 = queue.Dequeue();
            var result5 = queue.Dequeue();

            // Assert
            Assert.AreEqual("test", result);
            Assert.AreEqual("test5", result2);
            Assert.AreEqual("test4", result3);
            Assert.AreEqual("test2", result4);
            Assert.AreEqual("test3", result5);
        }

    }
}
