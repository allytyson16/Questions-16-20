using System;

namespace w3_schools
{
    class Program
    {
		  static void Main(string[] args)
		  {


          // 16.Write a C# program to create a new string from a given string where the first and last characters will change their positions.
               Console.WriteLine(first_last("GitHub"));
               Console.WriteLine(first_last("LinkedIn"));
               Console.WriteLine(first_last("Game Development"));

             static string first_last(string ustr)
             {
                 return ustr.Length > 1
                 ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
             }
       }
     }
 }
