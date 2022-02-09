using System;

namespace w3_schools
{
    class Program
    {
         //20.Write a C# program to get the absolute value of the difference between two given numbers.
            // Return double the absolute value of the difference if the first number is greater than second number.

            Console.Write("Enter one number - ");
			int number1 = int.Parse(Console.ReadLine());
			Console.Write("Enter another number - ");
			int number2 = int.Parse(Console.ReadLine());

			int difference = number1 - number2;
			int absoluteValue = Math.Abs(difference);
			Console.WriteLine("The Absolute value of {0} is {1}.", difference, absoluteValue);

			if(number1 > number2)
            {
				int doubleAbsoluteValue = absoluteValue * absoluteValue;
				Console.WriteLine("Since first number is greater than second, we will double the Absolute value: {0}.", doubleAbsoluteValue);
            }
    }
}
