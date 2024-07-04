public static class Priority
{
  public static void Test()
  {
    // TODO Problem 2 - Write and run test cases and fix the code to match requirements
    // Example of creating and using the priority queue
    var priorityQueue = new PriorityQueue();
    priorityQueue.Enqueue("tim", 2);
    priorityQueue.Enqueue("tom", 3);
    priorityQueue.Enqueue("tum", 1);
    priorityQueue.Enqueue("tiny", 8);
    priorityQueue.Enqueue("tuna", 9);
    priorityQueue.Enqueue("tunes", 3);
    priorityQueue.Enqueue("tany", 0);

    var priorityQueue2 = new PriorityQueue();
    priorityQueue2.Enqueue("tim", 6);
    priorityQueue2.Enqueue("tom", 3);

    // Test Cases

    // Test 1
    // Scenario: Testing Enqueue add item method at the end of the queue
    // Expected Result: [tim (Pri:2), tom (Pri:3), tum (Pri:1), tiny (Pri:8), tuna (Pri:9), tunes (Pri:3), tany (Pri:0)]
    // Defect(s) Found: The Enqueue method works as expected
    Console.WriteLine("Test 1");

    Console.WriteLine(priorityQueue);
    
    Console.WriteLine("---------");

    // Test 2
    // Scenario: Delete and print element with highest priority using Dequeue method
    // Expected Result: tuna
    // Defect(s) Found: It printed the highest priority -1 which made it not the last, changed >= to just > to remove the highest priority
    // RemoveAt method was added that takes the last index
    Console.WriteLine("Test 2");

    Console.WriteLine(priorityQueue.Dequeue());

    Console.WriteLine("---------");

    // Test 3
    // Scenario: add elements with the same priority and delete to verify that FIFO is met
    // Expected Result: [tom (Pri:5), tany (Pri:5)]
    Console.WriteLine("Test 3");

    var priorityQueue3 = new PriorityQueue();
    priorityQueue3.Enqueue("tim", 5);
    priorityQueue3.Enqueue("tom", 5);
    priorityQueue3.Enqueue("tany", 5);
    Console.WriteLine(priorityQueue3);
    Console.WriteLine(priorityQueue3.Dequeue());
    Console.WriteLine(priorityQueue3);
    Console.WriteLine("---------");

    // Test 4
    // Scenario: Remove elements from the list, and throw an error when there are no more elements to remove
    // Expected Result: tim, tom, throw Error
    // Defect(s) Found: There was no exception code, instead there was a message "The queue is empty".
    Console.WriteLine("Test 4");

    Console.WriteLine(priorityQueue2.Dequeue());
    Console.WriteLine(priorityQueue2.Dequeue());
    Console.WriteLine(priorityQueue2.Dequeue());
    Console.WriteLine("---------");

    // Add more Test Cases As Needed Below
  }
}