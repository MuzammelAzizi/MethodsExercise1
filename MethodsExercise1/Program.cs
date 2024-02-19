using System;
using System.Numerics;

namespace MethodsExercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            //---Exercise 1--
            //Name Muza
            //Favorite Color: Blue 
            //Favorite Animal: Walrus
            //Favorite Band: The Beatles

            Console.WriteLine("Hello - What is your first name");
            var muza = Console.ReadLine();

            Console.WriteLine($"Hey, {muza}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is great color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Amazing! Now, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {muza}! Here is your profile");
            Console.WriteLine("-");

            Console.WriteLine($"Name: {muza}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");

            Console.WriteLine("give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("give me a number to add");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("give me a number to multiple to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");

        }
        //---Exercise 2--

        public static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;

            return sum;

            //return num1 + num2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
    
