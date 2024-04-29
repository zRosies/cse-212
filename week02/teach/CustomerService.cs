/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        Console.WriteLine("Test 1");
        // var cs = new CustomerService(5);
        // Console.WriteLine(cs);
        // cs.AddNewCustomer();
        // cs.ServeCustomer();

        // Scenario: 
        // Expected Result: User
        // Defect(s) Found: The terminal was trying to print the customer after it was erased from the array.

        Console.WriteLine("=================");

        // Test 2
        // Scenario: Testing if the error messages will display if the the queue is full 
        // Expected Result: An error should prompt because the queue is full.
        Console.WriteLine("Test 2");
        // var cs1 = new CustomerService(2);
        // Console.WriteLine(cs1);
        // cs1.AddNewCustomer();
        // cs1.AddNewCustomer();
        // cs1.AddNewCustomer();
        // cs1.ServeCustomer();
        // cs1.ServeCustomer();
        // cs1.ServeCustomer();

        // Defect(s) Found: An error is found because the queue size is bigger than its instantiation.

        // Test 3
        // Scenario: Queueing and unqueueing customers orders to see if the program works as the expected and no error is prompted.
        // Expected Result: The list shoudn't be full of orders and teh program shall work as expected.

        Console.WriteLine("Test 3");
        var cs3 = new CustomerService(2);
        Console.WriteLine(cs3);
        cs3.AddNewCustomer();
        cs3.AddNewCustomer();
        cs3.ServeCustomer();
        cs3.AddNewCustomer();
        cs3.ServeCustomer();
        cs3.ServeCustomer();
        cs3.ServeCustomer();


        Console.WriteLine("=================");

        // Program working as expected

        // Add more Test Cases As Needed Below
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0){

            _maxSize = 10;
        }
        else{
            // Readjusting the query parameters according to the index of the array.
            _maxSize = maxSize -1;
        }
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count > _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        // Console.WriteLine(_queue.Count);

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
       _queue.Add(customer);

        // _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        if(_queue.Count == 0 || _queue[0]== null){
            Console.WriteLine("Attempting to serve a customer when the queue is empty");
            return;
        }
        var customer = _queue[0];
        _queue.RemoveAt(0);
        Console.WriteLine(customer);
        Console.WriteLine("Order delivered successfully");
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + String.Join(", ", _queue) + "]";
    }
}