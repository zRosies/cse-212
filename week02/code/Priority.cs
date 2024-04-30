public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();

        // Test Cases
   

        // Test 1
        // Scenario: Trying to dequeue when a queue is empty.
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Rice", 1);
        priorityQueue.Enqueue("Emergency", 3);
        priorityQueue.Enqueue("Dice", 2);
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        Console.WriteLine(  priorityQueue.Dequeue());

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}