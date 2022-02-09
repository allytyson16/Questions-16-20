using System;

namespace w3_schools
{
    class Program
    {
	       //18. Write a C# program to check two given integers and return true if one is negative and one is positive.
            Console.Write("Enter a negative/positive integer - ");
            int integer1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another negative/postive integer - ");
            int integer2 = int.Parse(Console.ReadLine());

            if ((integer1 < 0 && integer2 > 0) || (integer1 > 0 && integer2 < 0))
            {
                Console.WriteLine("True");

            }
         }
       }
  }
