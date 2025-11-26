using System;

namespace Greetings
{
    public class Greeting
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Programming!");

            string name = "yassine baazi";
            int age = 25;

            Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");

            int x = 10;
            int y = 5;
            int sum = x + y;
            Console.WriteLine("The sum of " + x + " and " + y + " is " + sum + ".");

            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }

            while (x > 0)
            {
                Console.WriteLine("Countdown: " + x);
                x--;
            }
            Console.WriteLine("Liftoff!");

            Console.WriteLine(SayHello(name));

            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is even.");
                }
                else
                {
                    Console.WriteLine(i + " is odd.");
                }
            }

            // Call helper methods (preserve original order)
            tempConvertion();
            numberSwapping();
            multplicationTable();
        }

        private static string SayHello(string name)
        {
            return "Hello, " + name + "!";
        }

        private static int tempConvertion()
        {
            Console.WriteLine("Enter temperature in Celsius:");
            string input = Console.ReadLine();
            double celsius;
            if (double.TryParse(input, out celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine(celsius + "°C is " + fahrenheit + "°F.");
                return 0;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return 1;
            }
        }

        private static int numberSwapping()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before swapping: a = " + a + ", b = " + b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping: a = " + a + ", b = " + b);
            return 0;
        }

        private static int multplicationTable()
        {
            int input;
            Console.WriteLine("Enter a number to display its multiplication table:");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(input + " x " + i + " = " + (input * i));
                }
                return 0;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return 1;
            }
        }
    }
}