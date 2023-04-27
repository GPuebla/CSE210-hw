using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------------------------ Lists ------------------------");

        List<int> numbers = new List<int>();
        int numSum = 0;
        float numAvg = 0;
        int largestNum = 0;

        int userNum = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        do
        {
            Console.Write("Enter number: ");
            userNum = int.Parse(Console.ReadLine());
            numbers.Add(userNum);
        } while (userNum != 0);

        foreach (var num in numbers)
        {
          numSum += num; 
        }

        Console.WriteLine($"The sum is:{numSum}");
        
    }
}