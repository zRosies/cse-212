/// <summary>
/// These 3 functions will (in different ways) calculate the standard
/// deviation from a list of numbers.  The standard deviation
/// is defined as the square root of the variance.  The variance is 
/// defined as the average of the squared differences from the mean.
/// </summary>
public static class StandardDeviation {
    public static void Run() {
        var numbers = new[] { 600, 470, 170, 430, 300 };
        Console.WriteLine(StandardDeviation1(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation2(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation3(numbers)); // Should be 147.322 
    }

    private static double StandardDeviation1(int[] numbers) {
        var total = 0.0;
        var count = 0;
        foreach (var number in numbers) {
            total += number;
            count += 1;
        }

        var avg = total / count;
        var sumSquaredDifferences = 0.0;
        foreach (var number in numbers) {
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        var variance = sumSquaredDifferences / count;
        return Math.Sqrt(variance);
    }
    // The time complexity of the StandardDeviation1 function is O(n)

    private static double StandardDeviation2(int[] numbers) {
        var sumSquaredDifferences = 0.0;
        var countNumbers = 0;
        foreach (var number in numbers) {
            var total = 0;
            var count = 0;
            foreach (var value in numbers) {
                total += value;
                count += 1;
            }

            var avg = total / count;
            sumSquaredDifferences += Math.Pow(number - avg, 2);
            countNumbers += 1;
        }

        var variance = sumSquaredDifferences / countNumbers;
        return Math.Sqrt(variance);
    }

     // The time complexity of the StandardDeviation2 function is O(n^2)

    private static double StandardDeviation3(int[] numbers) {
        var count = numbers.Length;
        var avg = (double)numbers.Sum() / count;
        var sumSquaredDifferences = 0.0;
        foreach (var number in numbers) {
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        var variance = sumSquaredDifferences / count;
        return Math.Sqrt(variance);
    }
    // The time complexity of the StandardDeviation3 function is O(log n)
}

//  ---------- Highest performance --------

// 1- O(1)  Constant time complexity. This complexity means that the algorithm's runtime does not depend on the size of the input, making it the most efficient.
// 2- O(log n) Logarithmic time complexity. The runtime grows logarithmically with the size of the input, making it very efficient, especially as n becomes large.
// 3- O(n) Linear time complexity. The runtime increases linearly with the size of the input, making it less efficient than constant or logarithmic time complexities, but still reasonable for large inputs.
// 4- O(n log n)  Linearithmic time complexity. This complexity often occurs in efficient sorting algorithms like Merge Sort and Quick Sort. It's more efficient than quadratic time complexity but less efficient than linear or logarithmic complexities.
// 5- O(n^2) Quadratic time complexity. The runtime grows quadratically with the size of the input, making it less efficient than linear and linearithmic complexities, especially for large inputs.
// 6- O(2^n) Exponential time complexity. This complexity indicates an algorithm that grows very rapidly with the size of the input. It's the least efficient among the given complexities when n is large.

// ----------- Lowest performance --------- 



// 1-O(n^2) 
// 2-O(n) 
// 3- O(n^2) 
// 4- xxxx O(log n) xxxxxxxx
// 5- O(1) 
// 6- O(2^n) 
// 7 - O(log n) 
// 8 - O(n) 
// 9 - O(log n) 
// 10 - SearchSorted2