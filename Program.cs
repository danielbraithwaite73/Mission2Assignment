using Mission2Assignment;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int rolls = 0;
        int[] results = new int[12];

        System.Console.WriteLine("Welcome to the dice throwing simulator!");

        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        rolls = int.Parse(System.Console.ReadLine());

        results = DiceRoll.RollingDice(rolls);

        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each * represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total Number of Rolls = " + rolls +".");
        for (int i = 0; i < results.Length; i++)
        {
            double percent = (double)results[i] / rolls * 100; 
            int numStars = (int)Math.Round(percent);

            System.Console.Write((i + 1) + ": ");
            System.Console.WriteLine(new string('*', numStars));

        }
        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        System.Console.ReadLine(); //added this at the end so when you run the .exe it doesn't immediately close
    }

}


