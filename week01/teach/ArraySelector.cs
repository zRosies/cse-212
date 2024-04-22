public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        List<int> newNumbers = new List<int>();
        int counter1 = 0;
        int counter2 = 0;
        for(int index = 0 ; index < select.Length ; index++){
            if(select[index] ==1 ){
                newNumbers.Add(list1[counter1]);
                counter1++;
            }

            if(select[index]==2){
                newNumbers.Add(list2[counter2]);
                  counter2++;  
                // newNumbers.Add(list2[counter2++]);
                // it's possible to increment the counter inside the index O.O
            }
            
        }

        return newNumbers.ToArray();
    }
}