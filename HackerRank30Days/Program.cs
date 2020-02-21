using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int inputTimes = Convert.ToInt32(Console.ReadLine());
        var phoneBook = new Dictionary<string, int>();

        for (int i = 0; i < inputTimes; i++)
        {
            var directInput = Console.ReadLine();

            var inputArr = directInput.Split(' ');

            phoneBook.Add(inputArr[0], Convert.ToInt32(inputArr[1]));
        }

        while (true)
        {
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                break;
            }
            if (phoneBook.ContainsKey(input))
            {
                Console.WriteLine("{0}={1}", input, phoneBook[input]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}

