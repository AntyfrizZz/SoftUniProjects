﻿using System;
//Write an expression that checks if given integer is odd or even.

//https://softuni.bg/downloads/svn/csharp-basics/Feb-2014/3.%20Operators-Expressions-and-Statements-Homework.docx

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Title = "Problem 1. Odd or Even Integers";

        Console.Write("Enter the number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(inputNumber % 2 == 0 ? "The given number is even." : "The given number is odd.");
    }
}