using System;
using System.Globalization;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 99999;
        int sum = 0;
        int largest = 0;
        int smallest = 99999;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.WriteLine("Enter a Number");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        foreach (int num in numbers)
        {
            sum += num;
            if (num > largest)
            {
                largest = num;
            }
            if (num > 0 && num < smallest)
            {
                smallest = num;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {largest}");
        Console.WriteLine($"The smallest is: {smallest}");
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }


    }
}