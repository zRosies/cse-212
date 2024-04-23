public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // ---------------------------------------------  Plan  -----------------------------------------------------------------
        // 1. Set an array of doubles
        // 2. Interate through the input length in a loop, and multiply the input number by the index adding it in the new array until the loop is complete
        // 3. Return the new array of doubles
        //-----------------------------------------------------------------------------------------------------------------------

        // 1-  Declaring the new array containing only the multiple numbers
        List<double> multiples = new List<double>(); 
       
        // The loop will loop until it reaches the maximum number of multiples (length)
        // The index will increment one by one until it reaches the input length
        for(int index =1; index <= length; index++){
                // 2- Multiplying the index by the input number until the loop is complete.
              
                // double newNumber = number * index;
                // multiples.Add(newNumber);
                
                // Here I am just simplifying the the process above /\
                multiples.Add(number*index);
                
        }

        // 3- Return the new array
        return multiples.ToArray(); 
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    private static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        

     

        // -----------------------------------------  Plan  -------------------------------------------------
        // 1. Slice the first array with the specified amount.
        // 2. Slice the second array to get the remaining values.
        // 4. Clear the initial array.
        // 5. Add the first sliced array to the array cleared.
        // 6. Add the second sliced array to the array cleared.
        //------------------------------------------- -------------------------------------------------

        // Here I slice the first array getting the part that will be rotated to the left
        // If data us <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        // Slice array will equal to <List>{9}

        List<int> slicedArray = data.Slice(data.Count - amount, amount);

        
        // Here I slice the first array getting the part that will be rotated to the right
        // If data us <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        // Slice array will equal to  <List>{ 1, 2, 3, 4, 5, 6, 7, 8}
        List<int> remainingArray = data.Slice(0, data.Count- amount);


        // Since the function returns void, we need to update the current array instead of returning a new one.
        // Here I clear the initial array
        data.Clear();
        // Here I add the first part to the new array that will be placed on the left
        // <List>{9}
        data.AddRange(slicedArray);
        // Here I add the second part to the new array that will be placed  on the right
        // <List>{ 1, 2, 3, 4, 5, 6, 7, 8}
        data.AddRange(remainingArray);

        // The updated data will be <List>{9,1, 2, 3, 4, 5, 6, 7, 8}

    }
}
