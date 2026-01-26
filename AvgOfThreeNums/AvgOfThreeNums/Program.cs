// Juvenal Nava,    1/21/2026
// Homework Assignment 1A

namespace AvgOfThreeNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Description of the Application
            Console.WriteLine("This program will ask you for three numbers.");
            Console.WriteLine("You need to enter one number at a time.");
            Console.WriteLine("Once all three numbers are entered, the sum and the average will be displayed on the screen.");
            Console.WriteLine("Each in a separate line.");
            Console.WriteLine();

            // Definition Section
            double num1, num2, num3, sum, avg;

            // Input Section
            Console.Write("Enter First Number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter Third Number: ");
            num3 = double.Parse(Console.ReadLine());

            // Process Section 
            sum = num1 + num2 + num3;
            avg = sum / 3.0;

            // Output Section
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The avg is {avg}");

            num3 = double.Parse(Console.ReadLine());
        }
    }
}
