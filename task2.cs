bool inGame = true;
public void Game();
{
    while (inGame)
    {
        if (!atGoal)
        {
            if (Peek)
            {
                AddVisitedCells();
                Move();
            }
            else
            {
                Turn();
            }
        }
        else
        {
            inGame = false;
        }
    }
}

#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading.
}
Void AddVisitedCells()
{
    // Adds current cell to a list so the Peek function doesnt view it as open
}

void Turn()
{
    // Turns the car 90 deg clockwise.
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}

#endregion

