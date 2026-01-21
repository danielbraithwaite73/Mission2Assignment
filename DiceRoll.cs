using System;

namespace Mission2Assignment
{
    internal class DiceRoll
    {
        public static int[] RollingDice(int numOfRolls)
        {//Method to simulate rolling two dice a specified number of times
            int[] results = new int[12];
            Random r = new Random();

            for (int i = 0; i < numOfRolls; i++)
            {
                int roll1 = r.Next(1, 7);
                int roll2 = r.Next(1, 7);
                int total = roll1 + roll2;

                results[total - 1]++;
            }

            return results;
        }


    }
}
