public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();

        // Test Cases
   

        // Test 1
        // Scenario: Trying to add the elements in the queue and dequeue them by priority. 
        // Expected Result: The elements are queued and dequeued by priority correctly.

        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Family", 1);
        priorityQueue.Enqueue("Emergency", 5);
        priorityQueue.Enqueue("Children", 3);
        Console.WriteLine( priorityQueue.Dequeue());
        Console.WriteLine( priorityQueue.Dequeue());
        Console.WriteLine( priorityQueue.Dequeue());

        // Defect(s) Found: The loop was not running correctly, It was stopping before interating through all
        // the eleements within the queue and the elements were not being removed from the queue.

        Console.WriteLine("---------");

        // Test 2
  
        // Scenario: Trying to dequeue when a queue is empty.
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 2");
        Console.WriteLine( priorityQueue.Dequeue());
        

        // Defect(s) Found: Program works correclty

        Console.WriteLine("---------");

        Console.WriteLine("Test 3");

        // Scenario: Elements added to the queue that has the same priority should be displayed(dequeued) 
        // according to its placement in the queue(closest to the front of the queue will be dequeued)
        // Expected Results: Elements with same priority should be displayed according to their placement in the queue.
        priorityQueue.Enqueue("Family", 3);
        priorityQueue.Enqueue("Emergency", 5);
        priorityQueue.Enqueue("Children", 3);
        priorityQueue.Enqueue("Grocery", 3);
        Console.WriteLine( priorityQueue.Dequeue());
        Console.WriteLine( priorityQueue.Dequeue());
        Console.WriteLine( priorityQueue.Dequeue());
        Console.WriteLine( priorityQueue.Dequeue());


        //Defect(s) Found: The program still gets the last with highest priority instead of the first.

        // To fix this problem was necessary to change the comparission value inside the loop. 
        // Now all the values are dequeued correctly according to its placement in the queue.


        // Add more Test Cases As Needed Below
    }
}