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
    // Scenario: Order elements by priority number when using the Enqueue method
    // Expected Result: [tany (Pri:0), tum (Pri:1), tim (Pri:2), tom (Pri:3), tunes (Pri:3), tiny (Pri:8), tuna (Pri:9)]
    // Defect(s) Found: There was no code that ordered by priority number inside the "Enqueue" method.
    Console.WriteLine("Test 1");

    Console.WriteLine(priorityQueue);
    
    Console.WriteLine("---------");

    // Test 2
    // Scenario: Delete and print element with highest priority using Dequeue method
    // Expected Result: tuna
    // Defect(s) Found: It printed the highest priority -1 which made it not the last,
    // RemoveAt method was added that takes the last index
    Console.WriteLine("Test 2");

    Console.WriteLine(priorityQueue.Dequeue());

    Console.WriteLine("---------");

    // Test 3
    // Scenario: add elements with the same priority and delete to verify that FIFO is met
    // Expected Result: [tim (Pri:5), tom (Pri:5)]
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