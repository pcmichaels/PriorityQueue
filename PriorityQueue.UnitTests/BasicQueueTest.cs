using NUnit.Framework;
using System;


namespace PriorityQueue.UnitTests
{
    [TestFixture]
    public class BasicQueueTest
    {
        [Test]
        public void Queue_NoEntries_CheckCount()
        {
            // Arrange
            PQueue.PriorityQueue<string> queue = new PQueue.PriorityQueue<string>();

            // Act
            int count = queue.Count();

            // Assert
            Assert.AreEqual(0, count);
        }

        [Test]
        public void Queue_Add_CheckCount()
        {
            // Arrange
            PQueue.PriorityQueue<string> queue = new PQueue.PriorityQueue<string>();

            // Act
            queue.Enqueue("test");
            queue.Enqueue("test2");

            // Assert
            Assert.AreEqual(2, queue.Count());            
        }

        [Test]
        public void Queue_Peek_CheckResult()
        {
            // Arrange
            PQueue.PriorityQueue<string> queue = new PQueue.PriorityQueue<string>();
            queue.Enqueue("test");
            queue.Enqueue("test2");

            // Act
            var result = queue.Peek();

            // Assert
            Assert.AreEqual(queue.Peek(), "test");
        }

        [Test]
        public void Queue_Dequeue_CheckCount()
        {
            // Arrange
            PQueue.PriorityQueue<string> queue = new PQueue.PriorityQueue<string>();
            queue.Enqueue("test");
            queue.Enqueue("test2");

            // Act
            var result = queue.Dequeue();

            // Assert
            Assert.AreEqual(1, queue.Count());
        }

        [Test]
        public void Queue_Dequeue_CheckResult()
        {
            // Arrange
            PQueue.PriorityQueue<string> queue = new PQueue.PriorityQueue<string>();
            queue.Enqueue("test");
            queue.Enqueue("test2");

            // Act
            var result = queue.Dequeue();

            // Assert
            Assert.AreEqual("test", result);
        }

        [Test]
        public void Queue_Dequeue_CheckAllResults()
        {
            // Arrange
            PQueue.PriorityQueue<string> queue = new PQueue.PriorityQueue<string>();
            queue.Enqueue("test");
            queue.Enqueue("test2");

            // Act
            var result = queue.Dequeue();
            var result2 = queue.Dequeue();

            // Assert
            Assert.AreEqual("test", result);
            Assert.AreEqual("test2", result2);
        }

        [Test]
        public void Queue_DequeueEmpty_CheckNull()
        {
            // Arrange
            PQueue.PriorityQueue<string> queue = new PQueue.PriorityQueue<string>();

            // Act
            var result = queue.Dequeue();

            // Assert
            Assert.IsNull(result);
        }

    }
}
