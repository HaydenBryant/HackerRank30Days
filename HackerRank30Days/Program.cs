using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int wordsCount = Convert.ToInt32(Console.ReadLine());

        for (int i = wordsCount; i > 0; i--)
        {
            List<char> oddList = new List<char>();
            List<char> evenList = new List<char>();

            string userInput = Console.ReadLine();
            for (int j = 0; j < userInput.Length; j++)
            {
                if (j % 2 == 0)
                {
                    evenList.Add(userInput[j]);
                }
                else
                {
                    oddList.Add(userInput[j]);
                }
            }
            foreach (char letter in evenList)
            {
                Console.Write(letter);
            }
            Console.Write(" ");
            foreach (char letter in oddList)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
        }
    }
}

