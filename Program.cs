using Mission2Assignment;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        int rolls = 0;
        int[] results = new int[12];

        Console.WriteLine("Welcome to the dice throwing simulator!");

        Console.WriteLine("How many dice rolls would you like to simulate?");

        rolls = int.Parse(Console.ReadLine());

        results = DiceRoll.RollingDice(rolls);

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each * represents 1% of the total number of rolls.");
        Console.WriteLine("Total Number of Rolls = " + rolls +".");
        for (int i = 0; i < results.Length; i++)
        {
            double percent = (double)results[i] / rolls * 100; 
            int numStars = (int)Math.Round(percent);

            Console.Write((i + 1) + ": ");
            Console.WriteLine(new string('*', numStars));

        }
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }

}


