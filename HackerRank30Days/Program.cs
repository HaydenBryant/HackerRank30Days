using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    // Add your code here
    public Difference(int[] elements)
    {
        this.elements = elements;
    }

    public void computeDifference()
    {
        int max = 0;
        foreach (int num in elements)
        {
            foreach (int num2 in elements)
            {
                int absoluteValue = Math.Abs(num - num2);
                if (absoluteValue > max)
                {
                    max = absoluteValue;
                }
            }
        }
        maximumDifference = max;
    }

} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}