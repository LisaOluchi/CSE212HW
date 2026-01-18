using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Append  items with unlike priorities
    // Expected Result: The highest priority item is the first to be dequeued
    // Defect(s) Found: Highest priority item could not be picked out correctly
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("High", 5);
        pq.Enqueue("Mid", 3);

        var result = pq.Dequeue();
        Assert.AreEqual("High", result);

    }

    [TestMethod]
    // Scenario: Append countless of times with the same priority
    // Expected Result: The First in, First out order is maintained
    // Defect(s) Found: Item turned out to not be correctly dequeued first
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("First", 4);
        pq.Enqueue("Second", 4);
        

        var result = pq.Dequeue();
        Assert.AreEqual("First", result);
    }

    [TestMethod]
    // Scenario: Dequeue from the empty queue
    // Excpected Results: InvaildOperationException was thrown
    //Defect(s) found: None
    public void TestPriorityQueue_Empty()
    {
        var pq = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() =>
         {
            pq.Dequeue();
        });
       
    }

}