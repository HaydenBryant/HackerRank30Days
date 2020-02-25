using System;

namespace day11Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] arr = new int[,] { { 1, 1, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 1, 1, 1, 0, 0, 0 },
            //    { 0, 0, 2, 4, 4, 0 }, {0, 0, 0, 2, 0, 0 }, { 0, 0 , 1, 2, 4, 0 } };

            int[,] arr = new int[,] { { 1, 1, 1, 2 }, { 0, 1, 0, 0 }, { 1, 1, 1, 2 } };

            int sum = HourglassSum(arr);
            Console.WriteLine(sum);
        }

        public static int[,] FindHourglass(int[,] arr)
        {

        }

        public static int HourglassSum(int[,] hourglassArr)
        {
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                if (i == 0 || i == 2)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        sum += hourglassArr[i, j];
                    }
                }
                else
                {
                    sum += hourglassArr[i, 1];
                }
            }
            return sum;
        }
    }
}
