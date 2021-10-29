using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBalls
{
    class BouncingBall
    {
        int X = 10;
        int Y = 10;
        int PlusX = 1;
        int PlusY = 1;

        public BouncingBall(int plusX, int plusY)
        {
            this.PlusX = plusX;
            this.PlusY = plusY;
        }
        public BouncingBall()
        {
            PlusX = 1;
            PlusY = 1;
        }

public void SetBallPosition(int x, int y)
{
    X = x;
    Y = y;
}

public void MoveIt()
{
    CheckBoundaries();
    // Radera bollen först
    Console.SetCursorPosition(X, Y);
    Console.Write(" ");
    // Flytta bollen
    X += PlusX;
    Y += PlusY;
    // Sätt ut bollen
    Console.SetCursorPosition(X, Y);
    Console.Write("O");
}

private void CheckBoundaries()
{
    if (X <= 1 || X >= Console.WindowWidth - 1)
    {
        PlusX = -PlusX;
    }
    if (Y <= 1 || Y >= Console.WindowHeight - 1)
    {
        PlusY = -PlusY;
    }
}
    }
}
