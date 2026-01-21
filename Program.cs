//Mission 2 Assignment
//By Daniel Braithwaite
using Mission2Assignment;
using System;

internal class Program
{
    private static void Main(string[] args)
    {//Dialog between the user to get the number of dice rolls
        int rolls = 0;
        int[] results = new int[12];

        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine();
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        rolls = int.Parse(System.Console.ReadLine());
        //Call the RollingDice method from the DiceRoll class to perform the simulation
        results = DiceRoll.RollingDice(rolls);

        //Display the results as a histogram
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each * represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total Number of Rolls = " + rolls +".");
        System.Console.WriteLine();
        for (int i = 0; i < results.Length; i++)
        {
            double percent = (double)results[i] / rolls * 100; 
            int numStars = (int)Math.Round(percent);

            System.Console.Write((i + 1) + ": ");
            System.Console.WriteLine(new string('*', numStars));

        }
        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        System.Console.WriteLine();
        //added this at the end so when you run the .exe it doesn't immediately close
        System.Console.WriteLine("Press Enter to exit..."); 
        System.Console.ReadLine(); 
    }

}


