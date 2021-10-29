using System;
using System.Threading;

namespace BouncingBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instansiera bollar
            BouncingBall ball1 = new BouncingBall();
            BouncingBall ball2 = new BouncingBall(-1, 1);

            // Ge dem startposition
            ball1.SetBallPosition(10, 10);
            ball2.SetBallPosition(32, 11);

            // Göm cursorn
            Console.CursorVisible = false;

            // Loopa bollarna
            while (true)
            {
                ball1.MoveIt();
                ball2.MoveIt();
                // Paus
                Thread.Sleep(75);
            }

        }
    }
}
