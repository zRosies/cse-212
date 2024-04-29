public static class MysteryStack1 {
    public static string Run(string text) {
        // "a,b,c,d"    

        // Result : d,c,b,a
        var stack = new Stack<char>();
        foreach (var letter in text)
            stack.Push(letter);

        var result = "";
        while (stack.Count > 0)
            result += stack.Pop();

        return result;
    }
}