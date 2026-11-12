using System.Runtime.InteropServices;

namespace DataTypes9D26
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Concatenation

            Console.WriteLine("Please enter your first name:");
            string firstname = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            string lastname = Console.ReadLine(); 
            
            Console.WriteLine("Please enter your age:");
            string age = Console.ReadLine();

            Console.WriteLine("Please enter your height:");
            string height = Console.ReadLine();
          
            Console.WriteLine("Is it raining?");
            string raining = Console.ReadLine();

            Console.WriteLine("Please enter a symbol:");
            string symbol = Console.ReadLine();

            Console.WriteLine($"Hello, {firstname} {lastname}, you are {age} years old, {height}, is it raining right now?: {raining}, and your symbol is: {symbol}. Goodbye! ");






        }
    }
}