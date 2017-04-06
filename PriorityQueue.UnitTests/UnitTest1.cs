using NUnit.Framework;
using System;


namespace PriorityQueue.UnitTests
{
    [TestFixture]
    public class BasicTestQueue
    {
        [Test]
        public void QueueAdd()
        {
            // Arrange
            PQueue.PriorityQueue<string> queue = new PQueue.PriorityQueue<string>();

            // Act
            queue.Add("test");
            queue.Add("test2");

            // Assert
            Assert.AreEqual(2, queue.Count());
        }
    }
}
