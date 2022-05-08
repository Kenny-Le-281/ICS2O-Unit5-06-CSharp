// Created by: Kenny Le
// Created on: May 2022
//
// This program performs a loop

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function performs a loop
        int firstInteger;
        int secondInteger;
        var answer = 0;
        int negativeOne = -1;

        // input
        Console.WriteLine("This program performs a loop by doing repeated addition.");

        Console.WriteLine("");
        Console.Write("Please input the first integer: ");
        firstInteger = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please input the second integer: ");
        secondInteger = Convert.ToInt32(Console.ReadLine());

        // process
        int counter = 0;
        
        while (counter < secondInteger)
        {
            answer += firstInteger;
            counter++;
        }

        if ((firstInteger < 0) && (secondInteger < 0))
        {
            answer = (firstInteger * negativeOne) * (secondInteger * negativeOne);
        }

        // output
        Console.WriteLine("The answer is " + answer);
        Console.WriteLine("\nDone.");
    }
}