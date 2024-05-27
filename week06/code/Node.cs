public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        
        // Removing duplicated values here //
        if(this.Contains(value)){
            return;
        }
        

        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        
        // Adding the Contains method here //
        if(Data == value){
            return true;
        }

        if(Left != null && this.Left.Contains(value)){
            return true;
        }

        if(Right!= null && this.Right.Contains(value)){
            return true;
        }

        return false;
    }

    public int GetHeight() {
        // TODO Start Problem 4

        int leftHigh = Left?.GetHeight() ?? 0;
        int rightHight = Right?.GetHeight() ?? 0;
        
        // Returning 1 (root) plus the height of each subtree
        return 1 + Math.Max(leftHigh, rightHight); // Replace this line with the correct return statement(s)
    }
}