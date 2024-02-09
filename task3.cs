while (!AtGoal())
{
    if (PeekRight())
    {
        Move();
    }
    else
    {
        if (Peek270())
        {
            Move();
        }
        else
        {
            if (Peek270())
            {
                Move();
            }
            else
            {
                Turn270();
                Move();
            }
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

bool PeekRight()
{
    Turn();
    Peek();
}

void Turn270()
{
    Turn();
    Turn();
    Turn();
}

bool Peek270()
{
    Turn270();
    Peek();
}

#endregion

