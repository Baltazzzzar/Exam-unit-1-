
int[] moveCounts = { 4, 4, 1, 1, 3, 1, 5, 3, 1, 1, 2, 1, 1, 2, 5, 1, 1, 2, 3, 3, 1, 2, 3, 3, 5, 1, 4, 1, 1, 1, 2, 1, 4, 2 };
int[] moveDirections = { 1, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 1, 2, 2, 1, 2, 1, 2, 1, 2, 1, 2, 2, 1, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

public void init()
{
    for (int i = 0; i < moveCounts.Length; i++)
    {
        Turn(moveDirections[i])
        for (int j = 0; j < moveCounts[i]; j++)
        {
            Move();
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
    // Turns the car 90 deg if the value is 1, turns it 270 degrees if the value is 2.
}

#endregion