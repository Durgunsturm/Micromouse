/*
Maze formatting:
3D array with each a 1D array of walls adjacent to a square in a 2D grid of squares

*/

{
    //Times it takes to move to the next square if it is:
    public static const float st = 1; //Straight
    public static const float tn = 1.4; //Turning takes longer

    public static (int, int, int, int)[][] grid;

    public void InsertWall((int, int) coord, bool vert)
    {
        (int, int, int, int) thisSq = vert ? (0, 1, 0, 0) : (0, 0, 1, 0); //Right and bottom wall
        (int, int, int, int) nextSq = vert ? (0, 0, 0, 1) : (1, 0, 0, 0); //Left and top wall

        (int, int) nextCoord = coord + (vert ? (0, 1) : (1, 0));
    }

    private void InitGrid(int height, int width) //Testing module
    {
        grid = new grid[height][width];
        for (int row = 0; row < grid.length; row++) //Filling out grid as empty interior and walled exterior
        {
            for (int col = 0; col < grid[row].length; col++)
            {
                (int, int, int, int) newSq = (0, 0, 0, 0); //New square to be inserted

                if (row == 0) { newSq += (1, 0, 0, 0); } //Top wall
                if (col == 0) { newSq += (0, 0, 0, 1); } //Left
                if (row == grid.length - 1) { newSq += (0, 0, 1, 0); } //Bottom
                if (col == grid[row].length - 1) { newSq += (0, 1, 0, 0); } //Right

                grid[row][col] = newSq;
            }
        }
    }
    private void DisplayGrid() //Testing module
    {
        
    }

    public ShortestPath()
    {
        InitGrid(3, 3);
    }
}