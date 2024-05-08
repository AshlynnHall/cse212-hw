public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: I will enqueue 3 items.
        // Expected Result: Ashlynn (Pri:1), Amanda (Pri:2), Sylisa (Pri:3)
        Console.WriteLine("Test 1");

        priorityQueue.Enqueue("Ashlynn", 1);
        priorityQueue.Enqueue("Amanda", 2);
        priorityQueue.Enqueue("Sylisa", 3);

        Console.WriteLine(priorityQueue);


        // Defect(s) Found: No errors

        Console.WriteLine("---------");

        // Test 2
        // Scenario: It will dequeue and it will show nothing.
        // Expected Result: 
        Console.WriteLine("Test 2");
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();

        if (priorityQueue == null) {
            Console.WriteLine("The queue is empty.");
        }
        else {Console.WriteLine(priorityQueue);
        }

        // Defect(s) Found: I couldn't get it to print 'The queue is empty'

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}