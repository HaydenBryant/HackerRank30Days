using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";


        // Declare second integer, double, and String variables.
        int numInt;
        double numDbl;
        string inputStr;
        // Read and save an integer, double, and String to your variables.
        numInt = Convert.ToInt32(Console.ReadLine());
        numDbl = Convert.ToDouble(Console.ReadLine());
        inputStr = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(numInt + i);
        // Print the sum of the double variables on a new line.
        Console.WriteLine(string.Format("{0:0.0}", numDbl + d));
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + inputStr);

    }
}