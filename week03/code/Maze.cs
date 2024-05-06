/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then display "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze {
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    // private Array[] position;

    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap) {
        _mazeMap = mazeMap;
    
    }
    
    //       The positions goes like this:
    //       //left     //Right   //Up        //Down
    //       false      true      false       true 
    //        
    // ----------------------- Mock here ----------------------
    //         { (1, 1), new[] { false, true, false, true } },
    //         { (1, 2), new[] { false, true, true, false } },
    //         { (1, 3), new[] { false, false, false, false } },
    //         { (1, 4), new[] { false, true, false, true } },
    //         { (1, 5), new[] { false, false, true, true } },
    //         { (1, 6), new[] { false, false, true, false } },
    //         { (2, 1), new[] { true, false, false, true } },
    //         { (2, 2), new[] { true, false, true, true } },
    //         { (2, 3), new[] { false, false, true, true } },
    // --------------------------------------------------------  

    // Todo Maze Problem - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveLeft() {
        // FILL IN CODE
        var position = _mazeMap[(_currX, _currY)].ToArray();
            //   Console.WriteLine($"Position: [{string.Join(", ", position)}]");

        if (position[0]) {
            _currX--;
              Console.WriteLine("Moved Left.");
        } else {
            Console.WriteLine("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveRight() {
        var position = _mazeMap[(_currX, _currY)].ToArray();
        // FILL IN CODE

        if (position[1]) {
            _currX++;
            Console.WriteLine("Moved right.");
        } else {
            Console.WriteLine("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveUp() {
        var position = _mazeMap[(_currX, _currY)].ToArray();

            // Console.WriteLine($"Position: [{string.Join(", ", position)}]");
        
        if (position[2]) {
            _currY--;
            Console.WriteLine("Moved Up.");
        } else {
            Console.WriteLine("Can't go that way!");
        }

        // Console.WriteLine(position);
        // Console.WriteLine($"Position: [{string.Join(", ", position)}]");
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveDown() {
        var position = _mazeMap[(_currX, _currY)].ToArray();
        // FILL IN CODE
        if (position[3]) {
            _currY++;
              Console.WriteLine("Moved Down.");
        } else {
            Console.WriteLine("Can't go that way!");
        }
    }

    public void ShowStatus() {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }
}