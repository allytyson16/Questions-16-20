using System;

namespace w3_schools
{
    class Program
    {
		  static void Main(string[] args)
		  {
          
        //17.Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
			     Console.Write("Enter a word/sentence - ");
            string str = Console.ReadLine();
            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
            }
            
          }
        }
  }
