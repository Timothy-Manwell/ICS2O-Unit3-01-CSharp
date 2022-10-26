// Created by: Timothy Manwell
// Created on: Oct 2022
//
// This program calculates the area of a trapezoid
using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double baseA;
        double baseB;
        double height;
        double area;

        Console.WriteLine("This program calculates the area of a trapezoid");
        Console.Write("\nEnter base a in cm: ");
        baseA = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nEnter base b in cm: ");
        baseB = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nEnter height in cm: ");
        height = Convert.ToDouble(Console.ReadLine());

        area = ((baseA + baseB) / 2) * height;
        Console.WriteLine("\nThe area is: " + area.ToString("0.00") + " cm². ");
    }
}