using System;

namespace HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int desiredHeight = int.Parse(Console.ReadLine());
            int jumpHeight = int.Parse(Console.ReadLine());
            int firstJump = desiredHeight - 30;
            int numJumps = 1;
            int failJumps = 0;

            while (true)
            {

                if (jumpHeight > firstJump)
                {
                    if (firstJump >= desiredHeight)
                    {
                        Console.WriteLine($"Tihomir succeeded, he jumped over {desiredHeight}cm after {numJumps} jumps.");
                        return;
                    }
                    firstJump += 5;
                    failJumps = 0;
                }
                else
                {
                    failJumps++;
                    if (failJumps == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {firstJump}cm after {numJumps} jumps.");
                        return;
                    }
                }
                jumpHeight = int.Parse(Console.ReadLine());
                numJumps++;

            }


        }
    }
}
