using System;

namespace w3_schools
{
    class Program
    {
        //19. Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
            Console.Write("Enter first integer - ");
            int int1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer - ");
            int int2 = int.Parse(Console.ReadLine());

            int output1 = int1 + int2;
            int output2 = output1 * output1 * output1;
            if (int1 != int2)
            {
                Console.WriteLine("Since the values are not equal then we will add = {0}", output1);
            }
            else
            {
                Console.WriteLine("Since the values are equal then we will tripple their sum = {0}", output2);
            }
        
    }
    
}
    
          
